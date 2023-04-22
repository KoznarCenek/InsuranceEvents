using System;
using System.Data.SqlClient;
using System.Reflection.PortableExecutable;

namespace Insurance
{
    class SQLDataCommunication
    {
        public static void PripojSeNaDatabazi()
        {
            string connetionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Cenek\\Dropbox\\Csharp\\Insurance\\Insurance\\Pojistenci.mdf;Integrated Security=True";
            string sql = "SELECT * FROM Pojistenci";
            try
            {
                using (SqlConnection connection = new SqlConnection(connetionString))
                {
                    SqlCommand command = new SqlCommand(sql, connection);
                    connection.Open();
                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Object[] values = new Object[dataReader.FieldCount];
                        int fieldCount = dataReader.GetValues(values);
                        foreach (var value in values)
                        {
                            Console.Write(value + " ");
                        }
                        Console.WriteLine();
                    }
                    dataReader.Close();
                    command.Dispose();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Can not open connection: " + ex.Message);
            }
        }
    }
}

