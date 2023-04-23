using System;
using System.Data.SqlClient;
using System.Reflection.PortableExecutable;
using System.Xml.Linq;

namespace Insurance
{
    class SQLDataCommunication
    {
        public static string getconnetionString()
        {
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
            Console.WriteLine(projectDirectory);
            Console.WriteLine(workingDirectory);
            string filepath = Path.Join(projectDirectory, "ConnectionString.xml");
            string connetionString ="";
            Console.WriteLine(connetionString);
            try
            {
                var xml = XDocument.Load(filepath);

                string DataSource = xml.Root.Element("DataSource").Value;
               
                string AttachDbFilename = xml.Root.Element("AttachDbFilename").Value;
                    
                string IntegratedSecurity = xml.Root.Element("IntegratedSecurity").Value;
                    
                connetionString = $"Data Source={DataSource};AttachDbFilename={AttachDbFilename};Integrated Security={IntegratedSecurity}";
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                Console.WriteLine("Nepodařilo se načíst XML soubor s connectionString");
            }
           return connetionString;
        }
        public static void PripojSeNaDatabazi()
        {
            string connetionString = getconnetionString();
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

