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
    public partial class frmürünSatışları : Form
    {
        public frmürünSatışları()
        {
            InitializeComponent();
        }

        private void frmürünSatışları_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.SatışlarTableAdapter taSatişlar = new DataSet1TableAdapters.SatışlarTableAdapter();
            dataGridView1.DataSource = taSatişlar.GetDataBy1Satışlar();
            comboBox1.DisplayMember = "ürünAd";
            comboBox1.ValueMember = "ürünNo";
            DataSet1TableAdapters.ÜrünlerTableAdapter taurunler = new DataSet1TableAdapters.ÜrünlerTableAdapter();
            comboBox1.DataSource = taurunler.GetDataÜrünler();
            comboBox2.DisplayMember = "müşteriAd";
            comboBox2.ValueMember = "müşteriNo";
            DataSet1TableAdapters.Müşteriler1TableAdapter taMüşteriler = new DataSet1TableAdapters.Müşteriler1TableAdapter();
            comboBox2.DataSource = taMüşteriler.GetDataMüşteri();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.SatışlarTableAdapter taSatışlar = new DataSet1TableAdapters.SatışlarTableAdapter();
            dataGridView1.DataSource = taSatışlar.GetDataSatışlarÜrünün(Convert.ToInt32(comboBox1.SelectedValue.ToString()));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.SatışlarTableAdapter taSatışlar = new DataSet1TableAdapters.SatışlarTableAdapter();
            dataGridView1.DataSource = taSatışlar.GetDataBy1Satışlar();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.SatışlarTableAdapter taSatışlar = new DataSet1TableAdapters.SatışlarTableAdapter();
            dataGridView1.DataSource = taSatışlar.GetDataBy1MüşteriyeGöre(Convert.ToInt32(comboBox2.SelectedValue.ToString()));

        }
    }
}
