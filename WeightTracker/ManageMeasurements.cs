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
    public partial class ManageMeasurements : Form
    {
        string speciename;
        public ManageMeasurements(string sp)
        {
            speciename = sp;
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            addmeasurements add = new addmeasurements(speciename);
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(add);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            updatemeasurements update = new updatemeasurements(speciename);
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(update);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            deletemeasurements delete = new deletemeasurements(speciename);
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(delete);
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            estimateIntake estimate = new estimateIntake(speciename);
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(estimate);
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            averageweight average = new averageweight(speciename);
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(average);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            viewmeasurements view = new viewmeasurements();
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(view);
        }

        private void CmdBack_Click(object sender, EventArgs e)
        {
            Choice choice = new Choice(speciename);
            choice.Show();
            Hide();
        }
    }
}
