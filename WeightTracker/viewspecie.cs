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
    public partial class viewspecie : UserControl
    {
        Specie specie = new Specie();
        public viewspecie()
        {
            InitializeComponent();
        }

        private void Viewspecie_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = specie.GetSpecieDetails();

        }
    }
}
