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
    public partial class viewmeasurements : UserControl
    {
        Measurement measurement = new Measurement();
        public viewmeasurements()
        {
            InitializeComponent();
        }

        private void Viewmeasurements_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = measurement.GetMeasurements();
        }
    }
}
