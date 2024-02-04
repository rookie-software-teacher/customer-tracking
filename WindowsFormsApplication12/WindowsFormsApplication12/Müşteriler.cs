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
    public partial class Müşteriler : Form
    {
        public Müşteriler()
        {
            InitializeComponent();
        }

        private void Müşteriler_Load(object sender, EventArgs e)
        {
            musteriGriGetir();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            newMusteri news = new newMusteri();
            news.ShowDialog();
            musteriGriGetir();
        }
        public void musteriGriGetir()
        {
            DataSet1TableAdapters.Müşteriler1TableAdapter taMusteri = new DataSet1TableAdapters.Müşteriler1TableAdapter();
            dataGridView1.DataSource = taMusteri.GetDataMüşteri();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataGridViewRow seciliSil = dataGridView1.CurrentRow;
            düzenleMüşteri düzmüş = new düzenleMüşteri();
            düzmüş.textBox1.Text = seciliSil.Cells["ad"].Value.ToString();
            düzmüş.textBox2.Text = seciliSil.Cells["soyad"].Value.ToString();
            düzmüş.label4.Text = seciliSil.Cells["müşteriNo"].Value.ToString();
            düzmüş.ShowDialog();
            musteriGriGetir();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Müşteri Silinecek emin misiniz", "warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                DataGridViewRow seciliSil = dataGridView1.CurrentRow;
                DataSet1TableAdapters.Müşteriler1TableAdapter düzmüş = new DataSet1TableAdapters.Müşteriler1TableAdapter();
                düzmüş.müşteriSil(Convert.ToInt32(seciliSil.Cells["müşteriNo"].Value.ToString()));
                musteriGriGetir();
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataGridViewRow seciliSil = dataGridView1.CurrentRow;
            borcEkleMuşteri borcAdd = new borcEkleMuşteri();
            borcAdd.label2.Text = seciliSil.Cells["müşteriNo"].Value.ToString();
            borcAdd.label4.Text = seciliSil.Cells["ad"].Value.ToString();
            borcAdd.ShowDialog();
            musteriGriGetir();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataGridViewRow seciliSil = dataGridView1.CurrentRow;
            borçAzalt borcAdd = new borçAzalt();
            borcAdd.label2.Text = seciliSil.Cells["müşteriNo"].Value.ToString();
            borcAdd.label4.Text = seciliSil.Cells["ad"].Value.ToString();
            borcAdd.ShowDialog();
            musteriGriGetir();
        }
    }
}
