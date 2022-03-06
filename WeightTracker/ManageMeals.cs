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
    public partial class ManageMeals : Form
    {
        string specieName;
        public ManageMeals(string species)
        {
            specieName = species;
            InitializeComponent();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Addmeal meal = new Addmeal(specieName);
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(meal);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            updatemeal update = new updatemeal(specieName);
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(update);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            deletemeal delete = new deletemeal(specieName);
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(delete);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            viewMeals view = new viewMeals();
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(view);
        }

        private void CmdBack_Click(object sender, EventArgs e)
        {
            Choice choice = new Choice(specieName);
            choice.Show();
            Hide();
        }
    }
}
