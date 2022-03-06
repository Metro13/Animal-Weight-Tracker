using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeightTracker
{
    public partial class deletemeasurements : UserControl
    {
        string Sname;
        Measurement measurement = new Measurement();
        public deletemeasurements(string sp)
        {
            Sname = sp;
            InitializeComponent();
        }

        private void CmdSubmit_Click(object sender, EventArgs e)
        {
            if(Txtdate.Text != null)
            {
                measurement.DeleteMeasurements(Txtdate.Text);
                MessageBox.Show("Measurements deleted");
            }
        }
    }
}
