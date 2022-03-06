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
    public partial class viewMeals : UserControl
    {
        Meal meal = new Meal();

        public viewMeals()
        {
            InitializeComponent();
        }

        private void ViewMeals_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = meal.GetMeals();
        }
    }
}
