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
    public partial class Ürünler : Form
    {
        public Ürünler()
        {
            InitializeComponent();
        }

        private void Ürünler_Load(object sender, EventArgs e)
        {
            getirÜrünler();
        }
        public void getirÜrünler()
        {
            DataSet1TableAdapters.ÜrünlerTableAdapter ta = new DataSet1TableAdapters.ÜrünlerTableAdapter();
            dataGridView1.DataSource = ta.GetDataÜrünler();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmÜrünOluştur frmÜrünOluştur = new frmÜrünOluştur();
            frmÜrünOluştur.ShowDialog();
            getirÜrünler();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmÜrünAlış al = new frmÜrünAlış();
            DataGridViewRow secili = dataGridView1.CurrentRow;

            al.label1.Text = secili.Cells["ürünNo"].Value.ToString();
            al.label2.Text = secili.Cells["ürünad"].Value.ToString();
            al.ShowDialog();
            getirÜrünler();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmürünSatışları f1 = new frmürünSatışları();
            f1.ShowDialog();
        }
    }
}
