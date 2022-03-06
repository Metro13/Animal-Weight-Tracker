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
    public partial class ManageActivities : Form
    {
        Specie getName = new Specie();
        public ManageActivities(string sp)
        {
            getName.Name = sp;
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            addactivity add = new addactivity(getName.Name);
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(add);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            updateactivity update = new updateactivity(getName.Name);
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(update);

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            deleteactivity delete = new deleteactivity();
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(delete);
        }

        
        private void Button4_Click(object sender, EventArgs e)
        {
            viewActivityInfo view = new viewActivityInfo();
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(view);
        }

        private void CmdBack_Click(object sender, EventArgs e)
        {
            Choice cs = new Choice(getName.Name);
            cs.Show();
            Hide();
        }
    }
}
