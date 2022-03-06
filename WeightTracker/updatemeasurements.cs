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
    public partial class updatemeasurements : UserControl
    {
        string Sname;
        Measurement measurement = new Measurement();
        public updatemeasurements(string sp)
        {
            Sname = sp;
            InitializeComponent();
        }

        private void CmdSubmit_Click(object sender, EventArgs e)
        {
            measurement.MorningReading = float.Parse(TxtMornWe.Text);
            measurement.EveningReading = float.Parse(TxtEvenW.Text);
            measurement.MorningWaist = float.Parse(TxtwaistM.Text);
            measurement.EveningWaist = float.Parse(TxtWE.Text);

            if(Txtdate.Text != null)
            {
                measurement.UpdateMeasurements(Sname, Txtdate.Text);
                MessageBox.Show("Measurements updated");
            }
           
        }
    }
}
