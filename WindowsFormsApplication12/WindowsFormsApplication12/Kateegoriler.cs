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
    public partial class Kateegoriler : Form
    {
        public Kateegoriler()
        {
            InitializeComponent();
        }

        private void Kateegoriler_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.Kategoriler1TableAdapter ta = new DataSet1TableAdapters.Kategoriler1TableAdapter();
            dataGridView1.DataSource = ta.GetDataKategori();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Kategori adını boş bırakma","Hata",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                DataSet1TableAdapters.Kategoriler1TableAdapter ta = new DataSet1TableAdapters.Kategoriler1TableAdapter();
                ta.InsertQueryKategori(textBox1.Text);
                dataGridView1.DataSource = ta.GetDataKategori();
                textBox1.Text = "";
            }
        }
    }
}
