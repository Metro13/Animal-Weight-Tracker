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
    public partial class Form1 : Form
    {
        public Form1(string specie)
        {
            InitializeComponent();
        }

        private void CmdProceed_Click(object sender, EventArgs e)
        {
            Choice newform;
            newform = new Choice(cmbSpecie.SelectedItem.ToString());
            newform.Show();
            this.Hide();

        }
    }
}
