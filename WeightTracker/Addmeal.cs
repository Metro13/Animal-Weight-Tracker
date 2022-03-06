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
    public partial class Addmeal : UserControl
    {
        Meal meals = new Meal();
        string speciename;
        DBConnection con = new DBConnection();

        public Addmeal(string spname)
        {
            speciename = spname;
            InitializeComponent();
        }

        private void CmdSubmit_Click(object sender, EventArgs e)
        {
            if(TxtAddname.Text != null && TxtAddQuantity.Text != null && TxtAddCvalue.Text != null)
            {
                meals.Name = TxtAddname.Text;
                meals.Quantity = float.Parse(TxtAddQuantity.Text);
                meals.CalorieInformation = float.Parse(TxtAddCvalue.Text);

               

                float totalCals = meals.CalculateCalorieInformation();
                    meals.AddMeal(totalCals, speciename);
                    MessageBox.Show("Operation successfull");
                
            }
        }
    }
}
