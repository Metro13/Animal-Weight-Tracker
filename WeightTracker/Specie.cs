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
    class Specie
    {
        private string name;

        private int age;

        private string gender;

        private string habitat;

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

        public int Age
        {
            set
            {
                age = value;
            }
            get
            {
                return age;
            }
        }

        public string Gender
        {
            set
            {
                gender = value;
            }
            get
            {
                return gender;
            }
        }
        public string Habitat
        {
            set
            {
                habitat = value;
            }
            get
            {
                return habitat;
            }
        }

        public void AddSpecie()
        {
            const string query = "INSERT INTO Specie (Specie_Name, Age, Gender, Habitat ) VALUES (@name, @age, @gender, @habitat)";

            var args = new Dictionary<string, object>
            {
                {"@name", Name},
                {"@gender", Gender},
                {"@age", Age},
                {"@habitat", Habitat},

            };

            con.CommandExecuter(query, args);
        }

        public void DeleteSpecie()
        {
            const string query = "delete from Specie where Specie_Name =@name";

            var args = new Dictionary<string, object>
            {
                {"@name", Name},
       

            };

            con.CommandExecuter(query, args);
        }

        public void UpdateSpecie()
        {
            const string query = "Update Specie set Age= @age, Gender=@gender, Habitat=@habitat where Specie_Name =@name";

            var args = new Dictionary<string, object>
            {
                {"@name", Name},
                {"@gender", Gender},
                {"@age", Age},
                {"@habitat", Habitat},

            };

            con.CommandExecuter(query, args);
        }
        public DataTable GetSpecieDetails()
        {
            using (var conn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
            {
                conn.Open();
                using (var command = new SQLiteCommand("SELECT * FROM Specie ", conn))
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
