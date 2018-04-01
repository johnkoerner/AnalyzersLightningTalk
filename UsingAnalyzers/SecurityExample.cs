// Please don't use this code as an example. It is meant to show how C# analyzers 
// can catch bad code, such as concatenating SQL strings.
using System.Data.SqlClient;

namespace UsingAnalyzers
{
    class SecurityExample
    {
        public int GetUserId(string connection, string name, string password)
        {
            SqlConnection conn = new SqlConnection(connection);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            cmd.CommandText = "SELECT UserId FROM Users " +
               "WHERE Username='" + name +
               "' AND Password='" + password + "'"; 

            conn.Open();
            int userId = (int)cmd.ExecuteScalar();
            conn.Close();
            return userId;
        }
    }
}
