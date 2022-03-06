using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Configuration;

namespace WeightTracker
{
    class Activity
    {
        private string name;

        private int duration;

        private string activityLevel;

        private float calorieBurnPerMinute;

        private float totalCaloriesBurned;

        DBConnection con = new DBConnection();
        Specie specie = new Specie();

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
        /// <summary>
        /// @param duration
        /// </summary>
        public int Duration
        {
            set
            {
                duration = value;
            }
            get
            {
                return duration;
            }
        }

        /// <summary>
        /// @param activityLevel
        /// </summary>
        public string ActivityLevel
        {
            set
            {
                activityLevel = value;
            }
            get
            {
                return activityLevel;
            }
        }

        public float CalorieBurnPerMinute
        {
            set
            {
                calorieBurnPerMinute = value;
            }
            get
            {
                return calorieBurnPerMinute;
            }
        }

        public float TotalCaloriesBurned
        {
            set
            {
                totalCaloriesBurned = value;
            }
            get
            {
                return totalCaloriesBurned;
            }
        }

        public void AddExercise(string name, string date)
        {
            // TODO implement here

            const string query = "INSERT INTO Activity (Specie_Name, Activity_Name, Duration, Activity_Level, Calories_Burned, Date) VALUES (@spname,@name,@duration,@level,@total, @date)";

            var args = new Dictionary<string, object>
            {
                {"@name", Name},
                {"@spname", name},
                {"@duration", Duration},
                {"@level", ActivityLevel},
                {"@total", TotalCaloriesBurned},
                {"@date", date},
            };

            con.CommandExecuter(query, args);
        }

        public void DeleteExercise(string date)
        {
            // TODO implement here
            const string query = "delete from Activity where Activity_Name =@name and Date=@date";

            var args = new Dictionary<string, object>
            {
                {"@name", Name},
                {"@date", date},

            };

            con.CommandExecuter(query, args);
        }

        public string getSpecieActivityLevel(string name)
        {
            // TODO implement here

            string returnActivityLevel;

            // TODO implement here
            using (var conn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
            {
                conn.Open();
                using (var command = new SQLiteCommand("Select Activity_Level from Activity where Specie_Name =@name", conn))
                {

                    command.Parameters.Add(new SQLiteParameter("@name", name));
                    returnActivityLevel = command.ExecuteScalar().ToString();
                    return returnActivityLevel;

                }
            }
        }


        public void UpdateExercise(string date)
        {
            // TODO implement here

            const string query = "Update Activity set Activity_Name=@name, Duration=@duration, Activity_Level=@level, Date=@date";

            var args = new Dictionary<string, object>
            {
                {"@name", Name},
                {"@duration", Duration},
                {"@level", ActivityLevel},
                {"@date", date},
            };

            con.CommandExecuter(query, args);
        }

        public void CalculateCaloriesBurned()
        {
            

            // TODO implement here
            if (Name == "Running".ToLower())
            {
                CalorieBurnPerMinute = 50;
            }
           else if (Name == "Walking".ToLower())
           {
                CalorieBurnPerMinute = 15;
           }
            else
            {
                CalorieBurnPerMinute = 8;
            }

            TotalCaloriesBurned = CalorieBurnPerMinute * Duration;

        }

        public DataTable GetActivities()
        {
            using (var conn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
            {
                conn.Open();
                using (var command = new SQLiteCommand("SELECT * FROM Activity", conn))
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
