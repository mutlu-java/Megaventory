using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Megaventory
{
    public partial class UserManagementForm : Form
    {


        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Muhammet Ali Mutlu\Documents\Megaventorydb.mdf"";Integrated Security=True;Connect Timeout=30;";
        public UserManagementForm()
        {
            InitializeComponent();
        }



        private void UserManagementForm_Load(object sender, EventArgs e)
        {

        }

        /*private void addButton_Click(object sender, EventArgs e)
         {
             string uname = usernametextBox.Text;
             string fullname = fullnametextBox.Text;
             string password = passwordtextBox.Text;
             string telephone= telephonetextBox.Text;

             // Validate input
             if (string.IsNullOrWhiteSpace(uname) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(telephone))
             {
                 MessageBox.Show("Please enter values in all text boxes.");
                 return;
             }

             string insertQuery = "INSERT INTO Usertable (Uname,Fullname,Pnumber,Password) VALUES (@uname,@fullname,@telephone,@password)";

             try
             {
                 using (SqlConnection connection = new SqlConnection(connectionString))
                 {
                     connection.Open();

                     using (SqlCommand command = new SqlCommand(insertQuery,connection))
                     {

                         command.Parameters.AddWithValue("@Uname", uname);
                         command.Parameters.AddWithValue("@Fullname", fullname);
                         command.Parameters.AddWithValue("@Pnumber", telephone);
                         command.Parameters.AddWithValue("@Password", password);

                         int rowsAffected = command.ExecuteNonQuery();
                         MessageBox.Show("Rows affected: " + rowsAffected);
                     }



                 }

             }

             catch (SqlException ex)
             {
                 MessageBox.Show("SQL Error: " + ex.Message);
             }

             catch (Exception ex)
             {
                 MessageBox.Show("Error: " + ex.Message);
             }





         }*/

        private void addButton_Click(object sender, EventArgs e)
        {
            string uname = usernametextBox.Text;
            string fullname = fullnametextBox.Text;
            string password = passwordtextBox.Text;
            string telephone = telephonetextBox.Text;

            // Validate input
            if (string.IsNullOrWhiteSpace(uname) || string.IsNullOrWhiteSpace(fullname) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(telephone))
            {
                MessageBox.Show("Please enter values in all text boxes.");
                return;
            }

            string insertQuery = "INSERT INTO Usertable (Uname, Fullname, Pnumber, Password) VALUES (@Uname, @Fullname, @Pnumber, @Password)";
            //In SQL commands, when you use parameters like
            //@Uname, @Fullname, @Pnumber, and @Password in the VALUES part of your query,
            //you are creating placeholders for the actual values.
            //This approach helps
            //to prevent SQL injection attacks and makes your code cleaner and more maintainable.

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        // Corrected parameter names to match the SQL query
                        command.Parameters.AddWithValue("@Uname", uname);
                        command.Parameters.AddWithValue("@Fullname", fullname);
                        command.Parameters.AddWithValue("@Pnumber", telephone);
                        command.Parameters.AddWithValue("@Password", password);

                        int rowsAffected = command.ExecuteNonQuery();
                        MessageBox.Show("Rows affected: " + rowsAffected);

                        usernametextBox.Clear();
                        fullnametextBox.Clear();
                        passwordtextBox.Clear();
                        telephonetextBox.Clear();
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string uname = usernametextBox.Text;
            string fullname = fullnametextBox.Text;
            string password = passwordtextBox.Text;
            string telephone = telephonetextBox.Text;


            if (string.IsNullOrWhiteSpace(uname) || string.IsNullOrWhiteSpace(fullname) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(telephone))
            {
                MessageBox.Show("Please enter values in all text boxes.");
                return;
            }

            string updateQuery = "UPDATE Usertable SET Fullname = @Fullname, Pnumber = @Pnumber, Password = @Password WHERE Uname = @Uname";

            try
            {
                using (SqlConnection connection = new(connectionString)) 
                {
                    connection.Open();


                    using(SqlCommand command= new SqlCommand(updateQuery,connection)) 
                    {
                        command.Parameters.AddWithValue("@Uname",uname);
                        command.Parameters.AddWithValue("@Fullname", fullname);
                        command.Parameters.AddWithValue("@Pnumber", telephone);
                        command.Parameters.AddWithValue("@Password", password);
                       
                        int rowsAffected = command.ExecuteNonQuery();
                       
                        MessageBox.Show("Rows affected: " + rowsAffected);

                        // Clear textboxes after successful update
                        usernametextBox.Clear();
                        fullnametextBox.Clear();
                        passwordtextBox.Clear();
                        telephonetextBox.Clear();


                    }
                
                }

            }

            catch (SqlException ex)
            {
                MessageBox.Show("SQL Error: " + ex.Message);
            }


            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            
            }
            
            


        }
    }
}
