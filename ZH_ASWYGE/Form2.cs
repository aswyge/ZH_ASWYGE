using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZH_ASWYGE.Models;

namespace ZH_ASWYGE
{
    public partial class Form2 : Form
    {
        WebshopContext webshopContext = new WebshopContext();
        public Form2()
        {
            InitializeComponent();
            comboBox1.ValueMember = "KatId";
            comboBox1.DisplayMember = "KatNev";
            var k = from x in webshopContext.Termekkategoria
                    select x;
            comboBox1.DataSource = k.ToList();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void buttonOK_Validating(object sender, CancelEventArgs e)
        {

        }

        private void buttonOK_Validated(object sender, EventArgs e)
        {

        }
    }
}
