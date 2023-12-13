using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arduino_Integrated_LMS
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void loadFormInPanel(Form formName) 
        {
            formName.TopLevel = false;
            formName.FormBorderStyle = FormBorderStyle.None;
            formName.Dock = DockStyle.Fill;
            pnMain.Controls.Add(formName);
            pnMain.Tag = formName;
            formName.BringToFront();
            formName.Show();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            MainDashboardForm mainDashboardForm = new MainDashboardForm();
            loadFormInPanel(mainDashboardForm);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            MainDashboardForm mainDashboardForm = new MainDashboardForm();
            loadFormInPanel(mainDashboardForm);
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            UserManagementForm userManagementForm = new UserManagementForm();
            loadFormInPanel(userManagementForm);
        }

        private void btnShelf_Click(object sender, EventArgs e)
        {
            ShelfManagementForm shelfManagementForm = new ShelfManagementForm();
            loadFormInPanel(shelfManagementForm);
        }

        private void btnReturns_Click(object sender, EventArgs e)
        {
            ReturnsForm returnsForm = new ReturnsForm();
            loadFormInPanel(returnsForm);
        }

        bool accExpand = false;
        private void accTransition_Tick(object sender, EventArgs e)
        {
            if (accExpand == false)
            {
                accContainer.Height += 10;
                if (accContainer.Height > 110)
                {
                    accTransition.Stop();
                    accExpand = true;
                }
            }
            else
            {
                accContainer.Height -= 10;
                if (accContainer.Height <= 36)
                {
                    accTransition.Stop();
                    accExpand = false;
                }
            }
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            accTransition.Start();
        }

        private void btnChangeUsername_Click(object sender, EventArgs e)
        {

        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.Show();
        }
    }
}
