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
    public partial class deletespecie : UserControl
    {
        string speciename;
        Specie specie = new Specie();

        public deletespecie(string sp)
        {
            speciename = sp;
            InitializeComponent();
        }

        private void CmdSubmit_Click(object sender, EventArgs e)
        {
            specie.Name = speciename;

            if(Txtspeciename.Text != null)
            {
                specie.DeleteSpecie();
            }
            else
            {
                MessageBox.Show("Specie Deleted");
            }
        }
    }
}
