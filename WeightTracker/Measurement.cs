using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SQLite;

namespace WeightTracker
{
    class Measurement
    {
        private float morningReading;
        private float eveningReading;
        private float morningWaist;
        private float eveningWaist;
        private float weightReading;
        private float waistMeasurement;
        private float dayWeight;
        private float dayMeasurement;
        public float Estimate;


        DBConnection con = new DBConnection();

        /// <summary>
        /// @param weightReading
        /// </summary>
        /// 
        public float MorningReading
        {
            set
            {
                morningReading = value;
            }
            get
            {
                return morningReading;
            }
        }

        public float EveningReading
        {
            set
            {
                eveningReading = value;
            }
            get
            {
                return eveningReading;
            }
        }

        public float MorningWaist
        {
            set
            {
                morningWaist = value;
            }
            get
            {
                return morningWaist;
            }
        }
        public float EveningWaist
        {
            set
            {
                eveningWaist = value;
            }
            get
            {
                return eveningWaist;
            }
        }
        public float WeightReading
        {
            set
            {
                weightReading = value;
            }
            get
            {
                return weightReading;
            }
        }

        public float WaistMeasurement
        {
            set
            {
                waistMeasurement = value;
            }
            get
            {
                return waistMeasurement;
            }
        }
        public float DayWeight
        {
            set
            {
                dayWeight = value;
            }
            get
            {
                return dayWeight;
            }
        }

        public float DayMeasurement
        {
            set
            {
                dayMeasurement = value;
            }
            get
            {
                return dayMeasurement;
            }
        }

        public void AddMeasurements(string name, string date )
        {
            // TODO implement here
           

            const string query = "INSERT INTO Measurements (Specie_Name, Morning_Weight, Evening_Weight, Morning_Measurement, Evening_Measurement, Day_Weight, Day_Measurement, Date) VALUES (@spname,@Mw,@Ew,@MM,@EM,@DayW,@Daymeas,@date)";

            var args = new Dictionary<string, object>
            {
                {"@spname", name},
                {"@Mw", MorningReading},
                {"@Ew", EveningReading},
                {"@MM", MorningWaist},
                {"@EM", EveningWaist},
                {"@dayW", DayWeight},
                {"@daymeas", DayMeasurement},
                {"@date", date},

            };

            con.CommandExecuter(query, args);
        }

        public void DeleteMeasurements(string date)
        {
            // TODO implement here

            const string query = "delete from Activity where and Date=@date";

            var args = new Dictionary<string, object>
            {
                {"@date", date},

            };

            con.CommandExecuter(query, args);
        }

        public void UpdateMeasurements(string name, string date)
        {
            // TODO implement here
            const string query = "Update Measurements set Morning_Weight =@Mw, Evening_Weight=@Ew, Morning_Measurement=@MM, Evening_Measurement=@EM where Date= @date and Specie_Name=@name";

            var args = new Dictionary<string, object>
            {
                {"@name", name},
                {"@Mw", MorningReading},
                {"@Ew", EveningReading},
                {"@MM", MorningWaist},
                {"@EM", EveningWaist},
                {"@date", date},

            };

            con.CommandExecuter(query, args);
        }

       

        public float AverageWeightChange(string name)
        {
            float AvgReturn;

            // TODO implement here
            using (var conn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
            {
                conn.Open();
                using (var command = new SQLiteCommand("SELECT AVG(Day_Weight) WeightAverage FROM Measurements WHERE Specie_Name = @name", conn))
                {

                    command.Parameters.Add(new SQLiteParameter("@name", name));
                    AvgReturn = float.Parse(command.ExecuteScalar().ToString());
                    return AvgReturn;

                }
               
            }

        }

        public float EstimateCalorieIntake(float weight, string gender, string activityLevel)
        {
            
            // TODO implement here

            if (activityLevel == "Active" && gender == "Female")
            {
                Estimate = weightReading * 10;
            }
            if (activityLevel == "Moderate" && gender == "Female")
            {
                Estimate = weightReading * 8;
            }
            if (activityLevel == "Inactive" && gender == "Female")
            {
                Estimate = weightReading * 6;
            }
            if (activityLevel == "Active" && gender == "Male")
            {
                Estimate = weightReading * 12;
            }

            if (activityLevel == "Moderate" && gender == "Male")
            {
                Estimate = weightReading * 10;
            }
            if (activityLevel == "Inactive" && gender == "Male")
            {
                Estimate = weightReading * 10;
            }

            return Estimate;
        }
        public DataTable GetMeasurements()
        {
            using (var conn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
            {
                conn.Open();
                using (var command = new SQLiteCommand("SELECT * FROM Measurements ", conn))
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
