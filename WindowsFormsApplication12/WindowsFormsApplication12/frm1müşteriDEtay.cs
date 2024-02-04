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
    public partial class frm1müşteriDEtay : Form
    {
        public frm1müşteriDEtay()
        {
            InitializeComponent();
        }

        private void frm1müşteriDEtay_Load(object sender, EventArgs e)
        {
            comboBox1.ValueMember = "müşteriNo";
            comboBox1.DisplayMember = "ad";
            DataSet1TableAdapters.MüşteriDetayları1TableAdapter taMüşteriDetay = new DataSet1TableAdapters.MüşteriDetayları1TableAdapter();
            dataGridView1.DataSource = taMüşteriDetay.GetDataMüşteriDetaylar();
            DataSet1TableAdapters.Müşteriler1TableAdapter taMüşteriler = new DataSet1TableAdapters.Müşteriler1TableAdapter();
            comboBox1.DataSource = taMüşteriler.GetDataMüşteri();
        }
    }
}
