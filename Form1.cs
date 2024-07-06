using System.Data.SqlClient;

namespace Megaventory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Muhammet Ali Mutlu\\Documents\\Megaventorydb.mdf\";Integrated Security=True;Connect Timeout=30;";


        private void loginbtn_Click(object sender, EventArgs e)
        {
            // Allows admins to enter 
            //  if AdminTable username and password are matching new menuform();

            string username = usernametb.Text;
            string password = passwordtb.Text;

            if (ValidateCredentials(username, password))
            {
                MessageBox.Show("Login successful!");

                UserManagementForm uf = new UserManagementForm();
          
                uf.Show();
                
                this.Hide(); // Hide the login form
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }

        }

        private bool ValidateCredentials(string username, string password)
        {
            string query = "SELECT COUNT(*) FROM AdminTable WHERE Username = @username AND Password = @password";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);

                        int count = (int)command.ExecuteScalar();

                        return count > 0;
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL Error: " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }





            /* private bool ValidateCredentials(string username, string password)
             {
                 string query = " SELECT COUNT(*) FROM AdminTable WHERE Username = @username AND Password = @password";
                 try
                 {
                     using(SqlConnection connection = new SqlConnection(@this.connectionString))
                     {
                         connection.Open();
                         using(SqlCommand command = new SqlCommand(query,connection))
                         {

                             command.Parameters.AddWithValue("@username", username);
                             command.Parameters.AddWithValue("@password", password);

                             int count = (int)command.ExecuteScalar();

                             return count > 0;


                         }



                     }
                 }

                 catch (SqlException ex)
                 {
                     MessageBox.Show("SQL Error: " + ex.Message);
                     return false;
                 }
                 catch (Exception ex)
                 {
                     MessageBox.Show("Error: " + ex.Message);
                     return false;
                 }*/








        }
    }
}
