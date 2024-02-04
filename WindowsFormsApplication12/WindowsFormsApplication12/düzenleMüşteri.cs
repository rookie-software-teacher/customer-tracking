using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication12
{
    public partial class düzenleMüşteri : Form
    {
        public düzenleMüşteri()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.Müşteriler1TableAdapter müş = new DataSet1TableAdapters.Müşteriler1TableAdapter();
            müş.AdSoyadGüncelle(textBox1.Text, textBox2.Text,Convert.ToInt32(label4.Text));
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
                
        }
    }
}
