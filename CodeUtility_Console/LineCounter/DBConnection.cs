using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace BPS.LineCounter
{
    public class DBConnection
    {
        MySqlConnection connection;

        string ip;
        string database;
        string username;
        string password;

        public void Initialise()
        {
            ip = "178.84.28.2";
            database = "auth";
            username = "remote";
            password = "mf8k66DwgDa48GLx2Vdu5FqLN8vNmeHBuuKMBbcCw5VZYmQDr9ZNPcdmnZZNd2v894d2XGQ5RY5qZrZD8nNf4xNDqfmAEXae2np8rDKzBvHdpXrsesG8s3avRVbUs9W42deXmUtaujhVj9Sr64ttjZTH4M8BEJZwnYX4d4TYYMvAJUjTRMLT6WZz7JGGZcY5FpjvHD2fkENSNGEpKkrYNrXNDkXwTR6s2LM9YthTXQwYStSTRaWeXRCgNuVdVSrd";

            MySqlConnectionStringBuilder connectionString = new MySqlConnectionStringBuilder();
            connectionString.Server = ip;
            connectionString.Port = 3350;
            connectionString.Database = database;
            connectionString.UserID = username;
            connectionString.Password = password;

            connection = new MySqlConnection(connectionString.ToString());
        }

        public bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException e)
            {
                switch(e.Number)
                {
                    case 0:
                        Console.WriteLine("0: Can't connect to server. Tell a programmer!");
                        break;
                    case 1045:
                        Console.WriteLine("1045: Username/ Password wrong, Tell a programmer!");
                        break;
                }
                Console.WriteLine(e.Number);
                return false;
            }
        }

        public bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch(MySqlException e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
        
        public void Select()
        {
            string query = "SELECT * FROM devvalues";

            List<String>[] list = new List<string>[4];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();
            list[3] = new List<string>();

            if (OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);

                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    list[0].Add(dataReader["members"] + "");
                    list[1].Add(dataReader["startdate"] + "");
                    list[2].Add(dataReader["projects"] + "");
                    list[3].Add(dataReader["totallines"] + "");
                    Console.WriteLine("Data read: " + dataReader["totallines"]);

                }

                dataReader.Close();

                CloseConnection();
            }
            else
            {
                Console.WriteLine("Wasn't connected, failed");
            }
        }

        public void Update()
        {
            string query = "UPDATE devvalues SET totallines = @totallines";
            //MySqlCommand cmd = new MySqlCommand(query, connection);

            if(OpenConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.Add("@totallines", MySqlDbType.Int32).Value = Counter.absoluteLines;

                    cmd.ExecuteNonQuery();
                }
            }
        }

    }
}