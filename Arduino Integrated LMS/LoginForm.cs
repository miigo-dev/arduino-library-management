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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Arduino_Integrated_LMS
{
    public partial class LoginForm : Form
    {
        private SqlConnection conn;

        public LoginForm()
        {
            InitializeComponent();
            conn = DatabaseConnection.Instance.Connection;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                string query = $"SELECT * FROM users WHERE username = '{txtUsername.Text}' AND password = '{txtPassword.Text}'";

                using (SqlDataAdapter sda = new SqlDataAdapter(query, conn))
                {
                    DataTable dataTable = new DataTable();
                    sda.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        DashboardForm dashboardForm = new DashboardForm();
                        dashboardForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtUsername.Clear();
                        txtPassword.Clear();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Incorrect username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide();
        }

        private void showPass_CheckedChanged(object sender, EventArgs e)
        {
            if (showPass.Checked)
            {
                
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
