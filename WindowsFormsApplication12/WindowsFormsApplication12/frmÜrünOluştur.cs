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
    public partial class frmÜrünOluştur : Form
    {
        public frmÜrünOluştur()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void frmÜrünOluştur_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.Kategoriler1TableAdapter ta = new DataSet1TableAdapters.Kategoriler1TableAdapter();
            comboBox1.DisplayMember = "kategoriAd";
            comboBox1.ValueMember = "kategoriId";
            comboBox1.DataSource = ta.GetDataKategori();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.ÜrünlerTableAdapter ta = new DataSet1TableAdapters.ÜrünlerTableAdapter();
            ta.yeniÜrün(textBox1.Text, Convert.ToDecimal(textBox2.Text), Convert.ToInt32(textBox3.Text), (int)comboBox1.SelectedValue);
            this.Close();
        }
    }
}
