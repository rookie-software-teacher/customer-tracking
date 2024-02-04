using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WindowsFormsApplication12
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=L455017;Initial Catalog=takip;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void kategorilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kateegoriler kategori = new Kateegoriler();
            kategori.ShowDialog();
        }

        private void müşterilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Müşteriler müşteri = new Müşteriler();
            müşteri.ShowDialog();
        }

        private void müşteriDetayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm1müşteriDEtay f1 = new frm1müşteriDEtay();
            f1.ShowDialog();
        }

        private void ürünlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ürünler ürün = new Ürünler();
            ürün.ShowDialog();
        }

        private void satışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmsatış sat = new frmsatış();
            sat.ShowDialog();
        }

        private void satışRaporuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmürünSatışları fr1 = new frmürünSatışları();
            fr1.ShowDialog();
        }
    }
}
