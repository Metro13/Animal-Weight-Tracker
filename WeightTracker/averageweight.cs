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
    public partial class averageweight : UserControl
    {
        string Sname;
        Measurement Measurement = new Measurement();
        public averageweight(string sp)
        {
            Sname = sp;
            InitializeComponent();
        }

        private void Averageweight_Load(object sender, EventArgs e)
        {
            lblSpecie.Text = Sname;

            lblAvgWeight.Text = Measurement.AverageWeightChange(Sname).ToString() + " Kgs";
        }
    }
}
