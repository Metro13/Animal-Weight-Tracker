using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeightTracker
{
    public partial class Choice : Form
    {
        string specieName;
        
        public Choice(string name)
        {
            specieName = name;
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void CmdMeals_Click(object sender, EventArgs e)
        {
            ManageMeals manage = new ManageMeals(specieName);
            manage.Show();
            Hide();

        }

        private void CmdActivities_Click(object sender, EventArgs e)
        {
            ManageActivities manage = new ManageActivities(specieName);
            manage.Show();
            Hide();
        }

        private void CmdMeasurements_Click(object sender, EventArgs e)
        {
            ManageMeasurements manage = new ManageMeasurements(specieName);
            manage.Show();
            Hide();
        }

        private void CmdSpecie_Click(object sender, EventArgs e)
        {
            ManageSpecie manage = new ManageSpecie(specieName);
            manage.Show();
            Hide();
        }
    }
}
