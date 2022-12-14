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
            �gyf�lSz�r�s();
            Term�kSz�r�s();
        }

        private void textBox�gyf�l_TextChanged(object sender, EventArgs e)
        {
            �gyf�lSz�r�s();
        }

        private void �gyf�lSz�r�s()
        {
            var �gyf�l = from x in webshopContext.Ugyfel
                         where x.Nev.Contains(textBox�gyf�l.Text)
                         select x;
            listBox�gyf�l.DisplayMember = "Nev";
            listBox�gyf�l.DataSource = �gyf�l.ToList();
        }

        private void listBox�gyf�l_SelectedIndexChanged(object sender, EventArgs e)
        {
            var �gyf�lid = ((Ugyfel)listBox�gyf�l.SelectedItem).Login;
            var rendel�s = from x in webshopContext.Rendeles
                           where x.Login==�gyf�lid
                           select x;
            listBoxRendel�s.DisplayMember = "RendDatum";
            listBoxRendel�s.DataSource = rendel�s.ToList();
        }

        private void listBoxRendel�s_SelectedIndexChanged(object sender, EventArgs e)
        {
            var rendel�sid = ((Rendeles)listBoxRendel�s.SelectedItem).Sorszam;
            var t�tel = from x in webshopContext.RendelesTetel
                        where x.Sorszam == rendel�sid
                        select new T�telek
                        {
                            Term�kk�d = x.Termekkod,
                            Term�kn�v = x.TermekkodNavigation.Megnevezes,
                            Kateg�ria = x.TermekkodNavigation.Kat.KatNev,
                            Egys�g�r = x.Egysegar,
                            M�rt�kegys�g = x.TermekkodNavigation.Megys,
                            Mennyis�g = x.Mennyiseg,
                            �r = x.Egysegar * x.Mennyiseg
                        };
            t�telekBindingSource3.DataSource = t�tel.ToList();
            var �ssz�rt�k = (from x in t�tel select x.�r).Sum();
            textBox�ssz�rt�k.Text = �ssz�rt�k.ToString();
        }

        private void textBoxTerm�k_TextChanged(object sender, EventArgs e)
        {
            Term�kSz�r�s();
        }

        private void Term�kSz�r�s()
        {
            var term�k = from x in webshopContext.Termek
                         where x.Megnevezes.Contains(textBoxTerm�k.Text)
                         select x;
            listBoxTerm�k.DisplayMember = "Megnevezes";
            listBoxTerm�k.DataSource = term�k.ToList();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            RendelesTetel rt = new RendelesTetel();
            rt.Sorszam = ((Rendeles)listBoxRendel�s.SelectedItem).Sorszam;
            rt.Termekkod = ((Termek)listBoxTerm�k.SelectedItem).Termekkod;
            rt.Egysegar = ((Termek)listBoxTerm�k.SelectedItem).Listaar;
            double m;
            if (!double.TryParse(textBoxMennyis�g.Text, out m)) return;
            rt.Mennyiseg=m;
            webshopContext.RendelesTetel.Add(rt);
            webshopContext.SaveChanges();
            �gyf�lSz�r�s();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            var t�telid = ((T�telek)t�telekBindingSource3.Current).Term�kk�d;
            var rendel�sid = ((Rendeles)listBoxRendel�s.SelectedItem).Sorszam;
            var t�rlend� = from x in webshopContext.RendelesTetel
                           where x.Termekkod==t�telid
                           where x.Sorszam==rendel�sid
                           select x;
            webshopContext.RendelesTetel.Remove(t�rlend�.FirstOrDefault());
            webshopContext.SaveChanges();
            �gyf�lSz�r�s();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            if (f2.DialogResult==DialogResult.OK)
            {
                var tk = Guid.NewGuid().ToString();
                var mn = f2.textBoxMegnevez�s.Text;
                var kat = ((Termekkategoria)f2.comboBox1.SelectedItem).KatId;
                var e� = f2.textBoxEgys�g�r.Text;
                var me = f2.textBoxMe.Text;
                Termek t = new Termek();
                t.Termekkod = tk;
                t.Megnevezes=mn;
                t.KatId = kat;
                t.Listaar = double.Parse(e�);
                webshopContext.Termek.Add(t);
                webshopContext.SaveChanges();
                Term�kSz�r�s();

            }
        }
    }
    public class T�telek
    {
        public string? Term�kk�d { get; set; }
        public string? Term�kn�v { get; set; }
        public string? Kateg�ria { get; set; }
        public double? Egys�g�r { get; set; }
        public double? Mennyis�g { get; set; }
        public string? M�rt�kegys�g { get; set; }
        public double? �r { get; set; }
    }
}