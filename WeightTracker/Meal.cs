using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Configuration;
using System.Data;

namespace WeightTracker
{
    class Meal
    {
        private string name;

        private float quantity;

        private float calorieInformation;
       

        DBConnection con = new DBConnection();

        /// <summary>
        /// @param name
        /// </summary>
        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }

        public float Quantity
        {
            set
            {
                quantity = value;
            }
            get
            {
                return quantity;
            }
        }

        public float CalorieInformation
        {
            set
            {
                calorieInformation = value;
            }
            get
            {
                return calorieInformation;
            }
        }

        /// <summary>
        /// @param calorieInformation
        /// </summary>
       
        public void AddMeal(float totalCalories, string specie)
        {
            const string query = "INSERT INTO Meal (Name, Quantity, Calorific_Value, Total_Calories, Specie_Name, Date) VALUES (@name, @quantity, @calorieValue, @totalCaloris, @specie, @date)";

            var args = new Dictionary<string, object>
            {
                {"@name", Name},
                {"@quantity", Quantity},
                {"@calorieValue", CalorieInformation},
                {"@totalCaloris", totalCalories },
                {"@specie", specie},
                {"@date", DateTime.Today.Date.ToString()},
            };

            con.CommandExecuter(query, args);
        }

        
        public void DeleteMeal(string date, string name)
        {
            const string query = "Delete from Meal where Date=@date and Specie_Name=@name";

            var args = new Dictionary<string, object>
            {
              
                {"@date", date},
                {"@name", name},
            };

            con.CommandExecuter(query, args);
        }

        public void UpdateMeal(float totalCalories, string specie, string date)
        {
            const string query = "Update Meal set Name = @name, Quantity =@quantity, Calorific_Value =@calorieValue, Total_Calories =@totalCaloris, Specie_Name=@specie where Date=@date";

            var args = new Dictionary<string, object>
            {
                {"@name", Name},
                {"@quantity", Quantity},
                {"@calorieValue", CalorieInformation},
                {"@totalCaloris", totalCalories },
                {"@specie", specie},
                {"@date", date},
            };

            con.CommandExecuter(query, args);
        }

        public float CalculateCalorieInformation()
        {
            float caloriePerGram = Quantity * 4 / CalorieInformation;
            return caloriePerGram;
        }
        public DataTable GetMeals()
        {
            using (var conn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
            {
                conn.Open();
                using (var command = new SQLiteCommand("SELECT * FROM Meal ", conn))
                {
                    command.ExecuteNonQuery();
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter();
                    adapter.SelectCommand = command;
                    DataTable data = new DataTable();
                    adapter.Fill(data);
                    return data;
                }

            }

        }
    }
}
