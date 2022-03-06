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
    public partial class addmeasurements : UserControl
    {
        string sName;

        Measurement measurement = new Measurement();

        public addmeasurements(string sp)
        {
            sName = sp;
            InitializeComponent();
        }

        private void CmdSubmit_Click(object sender, EventArgs e)
        {
            measurement.MorningReading = float.Parse(TxtMornWe.Text);
            measurement.EveningReading = float.Parse(TxtEvenW.Text);
            measurement.MorningWaist = float.Parse(TxtwaistM.Text);
            measurement.EveningWaist = float.Parse(TxtWE.Text);

           

            measurement.DayWeight  = measurement.MorningReading + measurement.EveningReading / 2;
            measurement.DayMeasurement = measurement.MorningWaist + measurement.EveningWaist / 2;

            if(Txtdate.Text != null)
            {
                measurement.AddMeasurements(sName, Txtdate.Text);
                MessageBox.Show("Measurements added");
            }


        }
    }
}
