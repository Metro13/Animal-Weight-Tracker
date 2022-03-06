using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Configuration;

namespace WeightTracker
{
    class Sheep:Specie
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

                    command.Parameters.Add(new SQLiteParameter("@name", Name = "Sheep"));
                    returnGender = command.ExecuteScalar().ToString();
                    return returnGender;

                }
            }
        }
    }
}
