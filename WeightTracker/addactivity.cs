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
    public partial class addactivity : UserControl
    {
        Specie specie = new Specie();
        string spname;
        Activity activity = new Activity();
        public addactivity(string sp)
        {
            spname = sp;
            InitializeComponent();
        }

        private void CmdSubmit_Click(object sender, EventArgs e)
        {
            specie.Name = spname;
            activity.Name = TxtAddname.Text;
            activity.Duration = int.Parse(TxtAddDuration.Text);
            activity.ActivityLevel = comboBox1.SelectedItem.ToString();


            if (activity.Name != null && activity.ActivityLevel != null && specie.Name != null && txtDate.Text != null)
            {
                activity.CalculateCaloriesBurned();
                activity.AddExercise(specie.Name, txtDate.Text);

                MessageBox.Show("Exercise Added");
            }
        }
    }
}
