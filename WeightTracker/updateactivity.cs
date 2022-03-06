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
    public partial class updateactivity : UserControl
    {
        string spname;
        Activity activity = new Activity();
        public updateactivity(string sp)
        {
            spname = sp;
            InitializeComponent();
        }

        private void CmdSubmit_Click(object sender, EventArgs e)
        {
            activity.Name = TxtAddname.Text;
            activity.Duration = int.Parse(TxtAddduration.Text);
            activity.ActivityLevel = comboBox1.SelectedItem.ToString();

            if (activity.Name != null && activity.ActivityLevel != null && TxtDate.Text != null)
            {
                activity.CalculateCaloriesBurned();
                activity.UpdateExercise(TxtDate.Text);

                MessageBox.Show("Activity Updated");
            }
        }
    }
}
