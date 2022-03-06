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
    public partial class estimateIntake : UserControl
    {
        string Sname;
        Measurement measurement = new Measurement();
        Activity activity = new Activity();
        Specie specie = new Specie();
        Horse horse = new Horse();
        Bear bear = new Bear();
        Sheep sheep = new Sheep();


        public estimateIntake(string sp)
        {
            Sname = sp;
            InitializeComponent();
        }

        private void EstimateIntake_Load(object sender, EventArgs e)
        {
            activity.ActivityLevel = activity.getSpecieActivityLevel(Sname);

            if(Sname == "Horse")
            {
                specie.Gender = horse.getSpecie();
            }
            if(Sname == "Bear")
            {
                specie.Gender = bear.getSpecie();
            }
            if(Sname == "Sheep")
            {
                specie.Gender = sheep.getSpecie();
            }

            measurement.WeightReading = measurement.AverageWeightChange(Sname);
            lblSpecie.Text = Sname;
            lblEstimate.Text = measurement.EstimateCalorieIntake(measurement.DayWeight,specie.Gender,activity.ActivityLevel).ToString() + " Kcals";
        }
    }
}
