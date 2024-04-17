using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendence_Student
{

    public partial class Student : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Attendence_System;Integrated Security=True;Connect Timeout=30;Encrypt=False;");
        public Student()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            string query = "SELECT * FROM student WHERE Username = @Username";

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@Username", username);

                try
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string storedPassword = reader["Password"].ToString();

                        

                        if (password.Trim() == storedPassword.Trim())
                        {
                            MessageBox.Show("Login successful!");
                            // Perform actions after successful login, such as navigating to another form
                        }
                        else 
                        {
                            MessageBox.Show("Invalid password. Please try again.");
                        }
                       
                    }
                    else
                    {
                        MessageBox.Show("Username not found. Please try again or register.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login page0 = new Login();
            page0.Show();
        }
    }
    }

