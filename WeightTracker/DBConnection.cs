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
    class DBConnection
    {
        public string loadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        //custom Command Executor for Queries
        public int CommandExecuter(string query, Dictionary<string, object> args)
        {
            int numsrows;

            // setting up database connection 
            using (var connection = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
            {
                connection.Open();
                using (var command = new SQLiteCommand(query, connection))
                {
                    foreach (var pair in args)
                    {
                        command.Parameters.AddWithValue(pair.Key, pair.Value);
                    }
                    // execute the Query and return the numbner of rows
                    numsrows = command.ExecuteNonQuery();

                }
                return numsrows;
            }


        }
    }
}
