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
    public partial class frmsatış : Form
    {
        DataSet1TableAdapters.Müşteriler1TableAdapter taMüşteriler = new DataSet1TableAdapters.Müşteriler1TableAdapter() ;
        DataSet1TableAdapters.ÜrünlerTableAdapter taÜrünler = new DataSet1TableAdapters.ÜrünlerTableAdapter();
        DataSet1TableAdapters.MüşteriDetayları1TableAdapter tamüşteriDetay = new DataSet1TableAdapters.MüşteriDetayları1TableAdapter();
        DataSet1TableAdapters.SatışlarTableAdapter taSatışlar = new DataSet1TableAdapters.SatışlarTableAdapter();
        public frmsatış()
        {
            InitializeComponent();
        }

        private void frmsatış_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = taMüşteriler.GetDataMüşteri();
            dataGridView2.DataSource = taÜrünler.GetDataÜrünler();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataGridViewRow secili = dataGridView2.CurrentRow;
            decimal fiyat = Convert.ToDecimal(secili.Cells["fiyat"].Value.ToString());
            tbPrice.Text = (fiyat * Convert.ToInt16(tbad.Text)).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewRow seciliUrun = dataGridView2.CurrentRow;
            DataGridViewRow seciliMüşteri = dataGridView1.CurrentRow;
            taSatışlar.SatışEkle(Convert.ToInt32(seciliUrun.Cells["ürünNo"].Value.ToString()),
                Convert.ToInt16(seciliMüşteri.Cells["müşteriNo"].Value.ToString()),
                Convert.ToInt32(tbad.Text),
                Convert.ToDecimal(seciliUrun.Cells["fiyat"].Value.ToString()),
                dateTimePicker1.Value.ToString());
            taÜrünler.adetAzalt(Convert.ToInt32(tbad.Text), Convert.ToInt16(seciliUrun.Cells["ürünNo"].Value.ToString()));
            taMüşteriler.borçArttır(Convert.ToDecimal(tbPrice.Text), Convert.ToInt32(seciliMüşteri.Cells["müşteriNo"].Value.ToString()));
            tamüşteriDetay.detayEkle(Convert.ToInt32(seciliMüşteri.Cells["müşteriNo"].Value.ToString()),
                Convert.ToDecimal(tbPrice.Text), 0, dateTimePicker1.Value, tbdescription.Text);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
