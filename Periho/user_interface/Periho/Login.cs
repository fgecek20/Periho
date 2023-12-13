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
using System.Diagnostics;
using System.Threading;

namespace Periho
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            FetchUsers();
            tbNewUser.Hide();
            btnEnroll.Hide();
        }

        private void FetchUsers()
        {
            string connectionString = "INSERT CONNECTION STRING";
            string query = "select username from profile";
            List<string> users = new List<string>();

            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                using(SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    using(SqlDataReader reader = command.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            string username = reader["username"].ToString();
                            users.Add(username);
                        }
                    }

                    connection.Close();
                }
            }

            lbUsers.DataSource = users;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            string username = lbUsers.SelectedItem.ToString();
            string pythonScriptPath = "PATH\\user_authentication.py " + username;
            string authenticationResult;

            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "python.exe",
                Arguments = pythonScriptPath,
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using(Process process = new Process { StartInfo = psi})
            {
                process.Start();
                authenticationResult = process.StandardOutput.ReadToEnd().Trim();
                process.WaitForExit();
                Console.WriteLine(authenticationResult);
            }

            if(string.Equals(authenticationResult, "Authentication successful", StringComparison.OrdinalIgnoreCase))
            {
                lblTestResult.Text = "SUCCESSFUL";
                Home home = new Home(username);
                home.Show();
                this.Hide();
            }
            else
            {
                lblTestResult.Text = "UNSUCCESSFUL";
            }
        }

        private void btnEnrollNewUser_Click(object sender, EventArgs e)
        {
            tbNewUser.Show();
            btnEnroll.Show();
        }

        private void btnEnroll_Click(object sender, EventArgs e)
        {
            string username = tbNewUser.Text;
            string pythonScriptPath = "PATH\\enroll_new_user.py " + username;

            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "python.exe",
                Arguments = pythonScriptPath,
                RedirectStandardOutput = false,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using (Process process = new Process { StartInfo = psi })
            {
                process.Start();
                process.WaitForExit();
            }

            Login newLogin = new Login();
            newLogin.Show();
            this.Hide();
        }
    }
}
