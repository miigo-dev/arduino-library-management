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

namespace Arduino_Integrated_LMS
{
    public partial class RegisterForm : Form
    {
        private SqlConnection conn;

        public RegisterForm()
        {
            InitializeComponent();
            conn = DatabaseConnection.Instance.Connection;
        }

        private void btnRegSignUp_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                string regUsername = txtRegUsername.Text;
                if (!System.Text.RegularExpressions.Regex.IsMatch(regUsername, "^[a-zA-Z0-9_.-]+$"))
                {
                    MessageBox.Show("Username can only contain alphanumeric characters, underscores, periods, and hyphens.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtRegUsername.Clear();
                    return;
                }

                string regPassword = txtRegPassword.Text;
                string regConfirmPassword = txtRegConfirmPass.Text;

                if (!System.Text.RegularExpressions.Regex.IsMatch(regPassword, "^[a-zA-Z0-9_.-]+$"))
                {
                    MessageBox.Show("Password can only contain alphanumeric characters, underscores, periods, and hyphens.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtRegPassword.Clear();
                    txtRegConfirmPass.Clear();
                    return;
                }

                // Check if the password and confirm password match
                if (regPassword != regConfirmPassword)
                {
                    MessageBox.Show("Password and Confirm Password do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtRegPassword.Clear();
                    txtRegConfirmPass.Clear();
                    return;
                }

                string checkUserQuery = $"SELECT COUNT(*) FROM users WHERE username = '{regUsername}'";
                using (SqlCommand checkUserCommand = new SqlCommand(checkUserQuery, conn))
                {
                    int userCount = (int)checkUserCommand.ExecuteScalar();

                    if (userCount > 0)
                    {
                        MessageBox.Show("Username already exists. Please choose a different one.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtRegUsername.Clear();
                        return;
                    }
                }

                string insertQuery = $"INSERT INTO users (username, password) VALUES ('{regUsername}', '{regPassword}')";

                using (SqlCommand insertCommand = new SqlCommand(insertQuery, conn))
                {
                    insertCommand.ExecuteNonQuery();
                }

                MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DashboardForm dashboardForm = new DashboardForm();
                dashboardForm.Show();
                this.Hide();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Ensure the connection is properly closed, whether an exception occurs or not
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }


        private void btnRegLogin_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }
    }
}
