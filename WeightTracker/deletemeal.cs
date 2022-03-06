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
    public partial class deletemeal : UserControl
    {
        string specieName;
        Meal meal = new Meal();

        public deletemeal(string Sp)
        {
            specieName = Sp;
            InitializeComponent();
        }

        private void CmdSubmit_Click(object sender, EventArgs e)
        {
            if(TxtDate.Text != null)
            {
                meal.DeleteMeal(TxtDate.Text, specieName);
                MessageBox.Show("Meal deleted Successfully");
            }
            else
            {
                MessageBox.Show("Please enter values in the text box");
            }
        }
    }
}
