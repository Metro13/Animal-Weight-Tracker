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
    class Bear:Specie
    {
        DBConnection con = new DBConnection();
        public string getSpecie()
        {

            string returnGender;

            // TODO implement here
            using (var conn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
            {
                conn.Open();
                using (var command = new SQLiteCommand("Select Gender from Specie where Specie_Name = @name", conn))
                {

                    command.Parameters.Add(new SQLiteParameter("@name", Name = "Bear"));
                    returnGender = command.ExecuteScalar().ToString();
                    return returnGender;

                }
            }
        }
    }
}
