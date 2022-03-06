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
    public partial class updatemeal : UserControl
    {
        string specieName;
        Meal newMeal = new Meal();
        public updatemeal(string SP)
        {
            specieName = SP;
            InitializeComponent();
        }

        private void CmdSubmit_Click(object sender, EventArgs e)
        {
            if (Txtupdatename.Text != null && TxtUpdateQuantity.Text != null && TxtUpdateCvalue.Text != null && TxtDate.Text != null)
            {
                newMeal.Name = Txtupdatename.Text;
                newMeal.Quantity = float.Parse(TxtUpdateQuantity.Text);
                newMeal.CalorieInformation = float.Parse(TxtUpdateCvalue.Text);

                float totalCals = newMeal.CalculateCalorieInformation();

                newMeal.UpdateMeal(totalCals, specieName, TxtDate.Text);

                MessageBox.Show("Updated successfully");
            }
        }

        private void Updatemeal_Load(object sender, EventArgs e)
        {

           

        }
    }
}
