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
    public partial class updatespecie : UserControl
    {
        string speciename;
        Specie specie = new Specie();
        public updatespecie(string Sp)
        {
            speciename = Sp;
            InitializeComponent();
        }

        private void CmdSubmit_Click(object sender, EventArgs e)
        {
            specie.Name = speciename;
            specie.Age = int.Parse(TxtUpdateAge.Text);
            specie.Gender = TxtUpdateGender.Text;
            specie.Habitat = TxtUpdateHabitat.Text;

            if (specie.Name != null && specie.Gender != null && specie.Habitat != null)
            {
                specie.UpdateSpecie();
                MessageBox.Show("Specie details updated");
            }
        }
    }
}
