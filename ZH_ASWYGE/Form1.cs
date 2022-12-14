using ZH_ASWYGE.Models;

namespace ZH_ASWYGE
{
    public partial class Form1 : Form
    {
        WebshopContext webshopContext = new WebshopContext();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ÜgyfélSzûrés();
            TermékSzûrés();
        }

        private void textBoxÜgyfél_TextChanged(object sender, EventArgs e)
        {
            ÜgyfélSzûrés();
        }

        private void ÜgyfélSzûrés()
        {
            var ügyfél = from x in webshopContext.Ugyfel
                         where x.Nev.Contains(textBoxÜgyfél.Text)
                         select x;
            listBoxÜgyfél.DisplayMember = "Nev";
            listBoxÜgyfél.DataSource = ügyfél.ToList();
        }

        private void listBoxÜgyfél_SelectedIndexChanged(object sender, EventArgs e)
        {
            var ügyfélid = ((Ugyfel)listBoxÜgyfél.SelectedItem).Login;
            var rendelés = from x in webshopContext.Rendeles
                           where x.Login==ügyfélid
                           select x;
            listBoxRendelés.DisplayMember = "RendDatum";
            listBoxRendelés.DataSource = rendelés.ToList();
        }

        private void listBoxRendelés_SelectedIndexChanged(object sender, EventArgs e)
        {
            var rendelésid = ((Rendeles)listBoxRendelés.SelectedItem).Sorszam;
            var tétel = from x in webshopContext.RendelesTetel
                        where x.Sorszam == rendelésid
                        select new Tételek
                        {
                            Termékkód = x.Termekkod,
                            Terméknév = x.TermekkodNavigation.Megnevezes,
                            Kategória = x.TermekkodNavigation.Kat.KatNev,
                            Egységár = x.Egysegar,
                            Mértékegység = x.TermekkodNavigation.Megys,
                            Mennyiség = x.Mennyiseg,
                            Ár = x.Egysegar * x.Mennyiseg
                        };
            tételekBindingSource3.DataSource = tétel.ToList();
            var összérték = (from x in tétel select x.Ár).Sum();
            textBoxÖsszérték.Text = összérték.ToString();
        }

        private void textBoxTermék_TextChanged(object sender, EventArgs e)
        {
            TermékSzûrés();
        }

        private void TermékSzûrés()
        {
            var termék = from x in webshopContext.Termek
                         where x.Megnevezes.Contains(textBoxTermék.Text)
                         select x;
            listBoxTermék.DisplayMember = "Megnevezes";
            listBoxTermék.DataSource = termék.ToList();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            RendelesTetel rt = new RendelesTetel();
            rt.Sorszam = ((Rendeles)listBoxRendelés.SelectedItem).Sorszam;
            rt.Termekkod = ((Termek)listBoxTermék.SelectedItem).Termekkod;
            rt.Egysegar = ((Termek)listBoxTermék.SelectedItem).Listaar;
            double m;
            if (!double.TryParse(textBoxMennyiség.Text, out m)) return;
            rt.Mennyiseg=m;
            webshopContext.RendelesTetel.Add(rt);
            webshopContext.SaveChanges();
            ÜgyfélSzûrés();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            var tételid = ((Tételek)tételekBindingSource3.Current).Termékkód;
            var rendelésid = ((Rendeles)listBoxRendelés.SelectedItem).Sorszam;
            var törlendõ = from x in webshopContext.RendelesTetel
                           where x.Termekkod==tételid
                           where x.Sorszam==rendelésid
                           select x;
            webshopContext.RendelesTetel.Remove(törlendõ.FirstOrDefault());
            webshopContext.SaveChanges();
            ÜgyfélSzûrés();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            if (f2.DialogResult==DialogResult.OK)
            {
                var tk = Guid.NewGuid().ToString();
                var mn = f2.textBoxMegnevezés.Text;
                var kat = ((Termekkategoria)f2.comboBox1.SelectedItem).KatId;
                var eá = f2.textBoxEgységár.Text;
                var me = f2.textBoxMe.Text;
                Termek t = new Termek();
                t.Termekkod = tk;
                t.Megnevezes=mn;
                t.KatId = kat;
                t.Listaar = double.Parse(eá);
                webshopContext.Termek.Add(t);
                webshopContext.SaveChanges();
                TermékSzûrés();

            }
        }
    }
    public class Tételek
    {
        public string? Termékkód { get; set; }
        public string? Terméknév { get; set; }
        public string? Kategória { get; set; }
        public double? Egységár { get; set; }
        public double? Mennyiség { get; set; }
        public string? Mértékegység { get; set; }
        public double? Ár { get; set; }
    }
}