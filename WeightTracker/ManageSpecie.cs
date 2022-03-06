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
    public partial class ManageSpecie : Form
    {
        string speciename;
        public ManageSpecie(string Sp)
        {
            speciename = Sp;
            InitializeComponent();
        }

        private void ManageSpecie_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            addspecie add = new addspecie(speciename);
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(add);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            updatespecie update = new updatespecie(speciename);
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(update);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            deletespecie delete = new deletespecie(speciename);
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(delete);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            viewspecie view = new viewspecie();
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
