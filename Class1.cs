using System.CodeDom;
using System.Data.SqlClient;
using System.DirectoryServices;
using System.Security.Cryptography.X509Certificates;

namespace midterms
{
    public static class SQLhelper
    {
        //declaring variables for the savings amount and checking amount, used in the select function
        private static int s;
        private static int c;

        //creating the purchase or withdraw SQL function to remove money from the savings acount
        public static void purchasesavings(int withdrawamount, int sbudget, string Password)
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\levis\source\repos\midterms\MyDatabase.mdf;Integrated Security=True";
            cnn = new SqlConnection(connetionString);
            cnn.Open();

            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string sql = String.Empty;

            int finalsavings = sbudget - withdrawamount;

            sql = "Update logins set Sbudget = '" + finalsavings + "' Where Password = '" + Password +"'";

            command = new SqlCommand(sql, cnn);

            adapter.InsertCommand = new SqlCommand(sql, cnn);
            adapter.InsertCommand.ExecuteNonQuery();

            command.Dispose();
            cnn.Close();
        }

        //the sql function to remove money from the checking acount
        public static void purchasechecking(decimal withdrawamount, decimal cbudget, string Password)
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\levis\source\repos\midterms\MyDatabase.mdf;Integrated Security=True";
            cnn = new SqlConnection(connetionString);
            cnn.Open();

            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string sql = String.Empty;

            decimal finalchecking = cbudget - withdrawamount;

            sql = "Update logins set Cbudget = '" + finalchecking + "' Where Password = '" + Password + "'";

            command = new SqlCommand(sql, cnn);

            adapter.InsertCommand = new SqlCommand(sql, cnn);
            adapter.InsertCommand.ExecuteNonQuery();

            command.Dispose();
            cnn.Close();
        }

        //creating a comand to ruturn two data peices from the data base, used to get the savings
        //and checking amounts
        public static Tuple<int, int> SelectFromloadDB(string Passwordfrm)
        {
            int savingsamount;
            int checkingamount;
            int userid;
            string userName;
            string password;
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\levis\source\repos\midterms\MyDatabase.mdf;Integrated Security=True";
            cnn = new SqlConnection(connetionString);
            cnn.Open();

            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string sqlselect = String.Empty;

            sqlselect = "select * from Logins where Password = '" + Passwordfrm + "';";

            command = new SqlCommand(sqlselect, cnn);

            adapter.InsertCommand = new SqlCommand(sqlselect, cnn);

            SqlDataReader reader = command.ExecuteReader();

            

            while (reader.Read())
            {
                userid = (int)reader["Id"];
                userName = (string)reader["UserName"];
                password = (string)reader["Password"];
                s = Convert.ToInt32(reader["Sbudget"]);
                c = Convert.ToInt32(reader["Cbudget"]);

                //userid = (int)reader.GetInt32(0);
                //userName = (string)reader.GetString(1);
                //password = (string)reader.GetString(2);
                //int s = (int)reader.GetInt32(3);
                //int c = (int)reader.GetInt32(4);
            }

            
            reader.Close();
            command.Dispose();
            cnn.Close();

            savingsamount = s;
            checkingamount = c;

            return Tuple.Create(savingsamount, checkingamount);
        }
        
       //the transfer to checking function, should move money from the savings acount to the checking
       //acount
        public static void transfertochecking(int transferawamount, int budget1, int budget2, string Password)
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\levis\source\repos\midterms\MyDatabase.mdf;Integrated Security=True";
            cnn = new SqlConnection(connetionString);
            cnn.Open();

            SqlCommand command;
            SqlCommand command2;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string sql = String.Empty;

            int finalbudget1 = budget1 - transferawamount;
            int finalbudget2 = budget2 + transferawamount;

            sql = "UPDATE Logins SET Sbudget='" + finalbudget1 + "', Cbudget='" + finalbudget2 + "' WHERE Password='" + Password+"'";

           
            command = new SqlCommand(sql, cnn);           
            adapter.InsertCommand = new SqlCommand(sql, cnn);           
            adapter.InsertCommand.ExecuteNonQuery();

            command.Dispose();
            cnn.Close();
        }
        //the transfer to checking function, should move money from the checking acount to the savings
        //acount
        public static void transfertosavings(int transferawamount, int budget1, int budget2, string Password)
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\levis\source\repos\midterms\MyDatabase.mdf;Integrated Security=True";
            cnn = new SqlConnection(connetionString);
            cnn.Open();

            SqlCommand command;
            SqlCommand command2;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string sql = String.Empty;

            int finalbudget1 = budget1 + transferawamount;
            int finalbudget2 = budget2 - transferawamount;

            sql = "Update logins set sbudget = '" + finalbudget1 + "', cbudget = '" + finalbudget2 + "', Where Password = " + Password;

            command = new SqlCommand(sql, cnn);
            adapter.InsertCommand = new SqlCommand(sql, cnn);
            adapter.InsertCommand.ExecuteNonQuery();

            command.Dispose();
            cnn.Close();
        }      
    }
}