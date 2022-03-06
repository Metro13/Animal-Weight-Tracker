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
    public partial class viewActivityInfo : UserControl
    {
        Activity Activity = new Activity();
        public viewActivityInfo()
        {
            InitializeComponent();
        }

        private void ViewActivityInfo_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Activity.GetActivities();
        }
    }
}
