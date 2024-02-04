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
    public partial class borcEkleMuşteri : Form
    {
        public borcEkleMuşteri()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.Müşteriler1TableAdapter düzmüş = new DataSet1TableAdapters.Müşteriler1TableAdapter();
            düzmüş.borçArttır(Convert.ToDecimal(textBox1.Text), Convert.ToInt32(label2.Text));

            DataSet1TableAdapters.MüşteriDetayları1TableAdapter detaymüş = new DataSet1TableAdapters.MüşteriDetayları1TableAdapter();
            detaymüş.detayEkle(Convert.ToInt32(label2.Text), 0, Convert.ToDecimal(textBox1.Text),dateTimePicker1.Value, textBox3.Text);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
