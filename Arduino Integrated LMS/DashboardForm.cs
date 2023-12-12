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
            } else
            {
                accContainer.Height -= 10;
                if (accContainer.Height <= 45)
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

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            DashboardForm dashboardForm = new DashboardForm();
            dashboardForm.Close();
        }

        bool sidebardExpand = true;

        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebardExpand) {
                sidebar.Width -= 5;
                if (sidebar.Width <= 50)
                {
                    sidebardExpand = false;
                    sidebarTransition.Stop();
                }
            } else
            {
                sidebar.Width += 5;
                if (sidebar.Width >= 219)
                {
                    sidebardExpand = true;
                    sidebarTransition.Stop();
                }
            }
        }

        private void btnHam_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }
    }
}
