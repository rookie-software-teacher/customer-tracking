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
    public partial class müşteriDEtay : Form
    {
        public müşteriDEtay()
        {
            InitializeComponent();
        }

        private void müşteriDEtay_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.MüşteriDetaylarıTableAdapter ta = new DataSet1TableAdapters.MüşteriDetaylarıTableAdapter();
            ta.GetDataMüşterininDetayları(Convert.ToInt32(label1.Text));
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
               
        }
    }
}
