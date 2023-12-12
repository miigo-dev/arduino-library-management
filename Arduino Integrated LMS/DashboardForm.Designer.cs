namespace Arduino_Integrated_LMS
{
    partial class DashboardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHam = new System.Windows.Forms.PictureBox();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnUser = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnShelf = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnReturns = new System.Windows.Forms.Button();
            this.accContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnAccount = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnChangeUsername = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnChangePass = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.accTransition = new System.Windows.Forms.Timer(this.components);
            this.sidebarTransition = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHam)).BeginInit();
            this.sidebar.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.accContainer.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnHam);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(816, 30);
            this.panel1.TabIndex = 0;
            // 
            // btnHam
            // 
            this.btnHam.BackColor = System.Drawing.Color.White;
            this.btnHam.Image = ((System.Drawing.Image)(resources.GetObject("btnHam.Image")));
            this.btnHam.Location = new System.Drawing.Point(3, 3);
            this.btnHam.Name = "btnHam";
            this.btnHam.Size = new System.Drawing.Size(37, 24);
            this.btnHam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnHam.TabIndex = 1;
            this.btnHam.TabStop = false;
            this.btnHam.Click += new System.EventHandler(this.btnHam_Click);
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sidebar.Controls.Add(this.panel2);
            this.sidebar.Controls.Add(this.panel3);
            this.sidebar.Controls.Add(this.panel4);
            this.sidebar.Controls.Add(this.panel5);
            this.sidebar.Controls.Add(this.accContainer);
            this.sidebar.Controls.Add(this.panel9);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 30);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(219, 459);
            this.sidebar.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnDashboard);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.panel2.Size = new System.Drawing.Size(216, 39);
            this.panel2.TabIndex = 3;
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(-22, -20);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnDashboard.Size = new System.Drawing.Size(245, 79);
            this.btnDashboard.TabIndex = 2;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnUser);
            this.panel3.Location = new System.Drawing.Point(3, 48);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.panel3.Size = new System.Drawing.Size(216, 39);
            this.panel3.TabIndex = 4;
            // 
            // btnUser
            // 
            this.btnUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUser.ForeColor = System.Drawing.Color.White;
            this.btnUser.Image = ((System.Drawing.Image)(resources.GetObject("btnUser.Image")));
            this.btnUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUser.Location = new System.Drawing.Point(-22, -20);
            this.btnUser.Name = "btnUser";
            this.btnUser.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnUser.Size = new System.Drawing.Size(245, 79);
            this.btnUser.TabIndex = 2;
            this.btnUser.Text = "User Management";
            this.btnUser.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnShelf);
            this.panel4.Location = new System.Drawing.Point(3, 93);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.panel4.Size = new System.Drawing.Size(216, 39);
            this.panel4.TabIndex = 4;
            // 
            // btnShelf
            // 
            this.btnShelf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnShelf.ForeColor = System.Drawing.Color.White;
            this.btnShelf.Image = ((System.Drawing.Image)(resources.GetObject("btnShelf.Image")));
            this.btnShelf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShelf.Location = new System.Drawing.Point(-22, -20);
            this.btnShelf.Name = "btnShelf";
            this.btnShelf.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnShelf.Size = new System.Drawing.Size(245, 79);
            this.btnShelf.TabIndex = 2;
            this.btnShelf.Text = "Shelf Management";
            this.btnShelf.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnReturns);
            this.panel5.Location = new System.Drawing.Point(3, 138);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.panel5.Size = new System.Drawing.Size(216, 39);
            this.panel5.TabIndex = 5;
            // 
            // btnReturns
            // 
            this.btnReturns.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnReturns.ForeColor = System.Drawing.Color.White;
            this.btnReturns.Image = ((System.Drawing.Image)(resources.GetObject("btnReturns.Image")));
            this.btnReturns.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReturns.Location = new System.Drawing.Point(-22, -20);
            this.btnReturns.Name = "btnReturns";
            this.btnReturns.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnReturns.Size = new System.Drawing.Size(245, 79);
            this.btnReturns.TabIndex = 2;
            this.btnReturns.Text = "Returns";
            this.btnReturns.UseVisualStyleBackColor = false;
            // 
            // accContainer
            // 
            this.accContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.accContainer.Controls.Add(this.panel7);
            this.accContainer.Controls.Add(this.panel6);
            this.accContainer.Controls.Add(this.panel8);
            this.accContainer.Location = new System.Drawing.Point(3, 183);
            this.accContainer.Name = "accContainer";
            this.accContainer.Size = new System.Drawing.Size(219, 39);
            this.accContainer.TabIndex = 7;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnAccount);
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(0);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.panel7.Size = new System.Drawing.Size(219, 39);
            this.panel7.TabIndex = 7;
            // 
            // btnAccount
            // 
            this.btnAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAccount.ForeColor = System.Drawing.Color.White;
            this.btnAccount.Image = ((System.Drawing.Image)(resources.GetObject("btnAccount.Image")));
            this.btnAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccount.Location = new System.Drawing.Point(-22, -20);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnAccount.Size = new System.Drawing.Size(245, 79);
            this.btnAccount.TabIndex = 2;
            this.btnAccount.Text = "Account";
            this.btnAccount.UseVisualStyleBackColor = false;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnChangeUsername);
            this.panel6.Location = new System.Drawing.Point(0, 39);
            this.panel6.Margin = new System.Windows.Forms.Padding(0);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.panel6.Size = new System.Drawing.Size(219, 39);
            this.panel6.TabIndex = 8;
            // 
            // btnChangeUsername
            // 
            this.btnChangeUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnChangeUsername.ForeColor = System.Drawing.Color.White;
            this.btnChangeUsername.Image = ((System.Drawing.Image)(resources.GetObject("btnChangeUsername.Image")));
            this.btnChangeUsername.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangeUsername.Location = new System.Drawing.Point(-22, -20);
            this.btnChangeUsername.Name = "btnChangeUsername";
            this.btnChangeUsername.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnChangeUsername.Size = new System.Drawing.Size(245, 79);
            this.btnChangeUsername.TabIndex = 2;
            this.btnChangeUsername.Text = "Change Username";
            this.btnChangeUsername.UseVisualStyleBackColor = false;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btnChangePass);
            this.panel8.Location = new System.Drawing.Point(0, 78);
            this.panel8.Margin = new System.Windows.Forms.Padding(0);
            this.panel8.Name = "panel8";
            this.panel8.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.panel8.Size = new System.Drawing.Size(219, 39);
            this.panel8.TabIndex = 9;
            // 
            // btnChangePass
            // 
            this.btnChangePass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnChangePass.ForeColor = System.Drawing.Color.White;
            this.btnChangePass.Image = ((System.Drawing.Image)(resources.GetObject("btnChangePass.Image")));
            this.btnChangePass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangePass.Location = new System.Drawing.Point(-22, -20);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnChangePass.Size = new System.Drawing.Size(245, 79);
            this.btnChangePass.TabIndex = 2;
            this.btnChangePass.Text = "Change Password";
            this.btnChangePass.UseVisualStyleBackColor = false;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.btnLogout);
            this.panel9.Location = new System.Drawing.Point(3, 228);
            this.panel9.Name = "panel9";
            this.panel9.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.panel9.Size = new System.Drawing.Size(216, 39);
            this.panel9.TabIndex = 6;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(-22, -20);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(245, 79);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // accTransition
            // 
            this.accTransition.Interval = 5;
            this.accTransition.Tick += new System.EventHandler(this.accTransition_Tick);
            // 
            // sidebarTransition
            // 
            this.sidebarTransition.Interval = 3;
            this.sidebarTransition.Tick += new System.EventHandler(this.sidebarTransition_Tick);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(816, 489);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashboardForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHam)).EndInit();
            this.sidebar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.accContainer.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private PictureBox btnHam;
        private FlowLayoutPanel sidebar;
        private Button btnDashboard;
        private Panel panel2;
        private Panel panel3;
        private Button btnUser;
        private Panel panel4;
        private Button btnShelf;
        private Panel panel5;
        private Button btnReturns;
        private System.Windows.Forms.Timer accTransition;
        private FlowLayoutPanel accContainer;
        private Panel panel7;
        private Button btnAccount;
        private Panel panel8;
        private Button btnChangePass;
        private Panel panel6;
        private Button btnChangeUsername;
        private Panel panel9;
        private Button btnLogout;
        private System.Windows.Forms.Timer sidebarTransition;
    }
}