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
    public partial class addspecie : UserControl
    {
        string speciename;
        Specie specie = new Specie();
        public addspecie(string sp)
        {
            speciename = sp;
            InitializeComponent();
        }

        private void CmdSubmit_Click(object sender, EventArgs e)
        {
            specie.Name = speciename;
            specie.Age = int.Parse(TxtAddAge.Text);
            specie.Gender = TxtAddGender.Text;
            specie.Habitat = TxtAddHabitat.Text;

            if (specie.Name != null && specie.Gender != null && specie.Habitat != null)
            {
                specie.AddSpecie();
                MessageBox.Show("Specie added");
            }
        }
    }
}
