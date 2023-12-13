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
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.pnDashboard = new System.Windows.Forms.Panel();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.pnUserManagement = new System.Windows.Forms.Panel();
            this.btnUser = new System.Windows.Forms.Button();
            this.pnShelfManagement = new System.Windows.Forms.Panel();
            this.btnShelf = new System.Windows.Forms.Button();
            this.pnReturns = new System.Windows.Forms.Panel();
            this.btnReturns = new System.Windows.Forms.Button();
            this.accContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnAccount = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnChangePass = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnChangeUsername = new System.Windows.Forms.Button();
            this.pnLogout = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.accTransition = new System.Windows.Forms.Timer(this.components);
            this.pnMain = new System.Windows.Forms.Panel();
            this.sidebar.SuspendLayout();
            this.pnDashboard.SuspendLayout();
            this.pnUserManagement.SuspendLayout();
            this.pnShelfManagement.SuspendLayout();
            this.pnReturns.SuspendLayout();
            this.accContainer.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel6.SuspendLayout();
            this.pnLogout.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sidebar.Controls.Add(this.pnDashboard);
            this.sidebar.Controls.Add(this.pnUserManagement);
            this.sidebar.Controls.Add(this.pnShelfManagement);
            this.sidebar.Controls.Add(this.pnReturns);
            this.sidebar.Controls.Add(this.accContainer);
            this.sidebar.Controls.Add(this.pnLogout);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(264, 1041);
            this.sidebar.TabIndex = 1;
            // 
            // pnDashboard
            // 
            this.pnDashboard.Controls.Add(this.btnDashboard);
            this.pnDashboard.Location = new System.Drawing.Point(3, 3);
            this.pnDashboard.Name = "pnDashboard";
            this.pnDashboard.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.pnDashboard.Size = new System.Drawing.Size(261, 34);
            this.pnDashboard.TabIndex = 3;
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(-7, -17);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(21, 0, 0, 0);
            this.btnDashboard.Size = new System.Drawing.Size(275, 68);
            this.btnDashboard.TabIndex = 2;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // pnUserManagement
            // 
            this.pnUserManagement.Controls.Add(this.btnUser);
            this.pnUserManagement.Location = new System.Drawing.Point(3, 43);
            this.pnUserManagement.Name = "pnUserManagement";
            this.pnUserManagement.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.pnUserManagement.Size = new System.Drawing.Size(261, 34);
            this.pnUserManagement.TabIndex = 4;
            // 
            // btnUser
            // 
            this.btnUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUser.ForeColor = System.Drawing.Color.White;
            this.btnUser.Image = ((System.Drawing.Image)(resources.GetObject("btnUser.Image")));
            this.btnUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUser.Location = new System.Drawing.Point(-7, -17);
            this.btnUser.Name = "btnUser";
            this.btnUser.Padding = new System.Windows.Forms.Padding(21, 0, 0, 0);
            this.btnUser.Size = new System.Drawing.Size(275, 68);
            this.btnUser.TabIndex = 2;
            this.btnUser.Text = "User Management";
            this.btnUser.UseVisualStyleBackColor = false;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // pnShelfManagement
            // 
            this.pnShelfManagement.Controls.Add(this.btnShelf);
            this.pnShelfManagement.Location = new System.Drawing.Point(3, 83);
            this.pnShelfManagement.Name = "pnShelfManagement";
            this.pnShelfManagement.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.pnShelfManagement.Size = new System.Drawing.Size(261, 34);
            this.pnShelfManagement.TabIndex = 4;
            // 
            // btnShelf
            // 
            this.btnShelf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnShelf.ForeColor = System.Drawing.Color.White;
            this.btnShelf.Image = ((System.Drawing.Image)(resources.GetObject("btnShelf.Image")));
            this.btnShelf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShelf.Location = new System.Drawing.Point(-7, -17);
            this.btnShelf.Name = "btnShelf";
            this.btnShelf.Padding = new System.Windows.Forms.Padding(21, 0, 0, 0);
            this.btnShelf.Size = new System.Drawing.Size(275, 68);
            this.btnShelf.TabIndex = 2;
            this.btnShelf.Text = "Shelf Management";
            this.btnShelf.UseVisualStyleBackColor = false;
            this.btnShelf.Click += new System.EventHandler(this.btnShelf_Click);
            // 
            // pnReturns
            // 
            this.pnReturns.Controls.Add(this.btnReturns);
            this.pnReturns.Location = new System.Drawing.Point(3, 123);
            this.pnReturns.Name = "pnReturns";
            this.pnReturns.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.pnReturns.Size = new System.Drawing.Size(261, 34);
            this.pnReturns.TabIndex = 5;
            // 
            // btnReturns
            // 
            this.btnReturns.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnReturns.ForeColor = System.Drawing.Color.White;
            this.btnReturns.Image = ((System.Drawing.Image)(resources.GetObject("btnReturns.Image")));
            this.btnReturns.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReturns.Location = new System.Drawing.Point(-7, -17);
            this.btnReturns.Name = "btnReturns";
            this.btnReturns.Padding = new System.Windows.Forms.Padding(21, 0, 0, 0);
            this.btnReturns.Size = new System.Drawing.Size(275, 68);
            this.btnReturns.TabIndex = 2;
            this.btnReturns.Text = "Returns";
            this.btnReturns.UseVisualStyleBackColor = false;
            this.btnReturns.Click += new System.EventHandler(this.btnReturns_Click);
            // 
            // accContainer
            // 
            this.accContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.accContainer.Controls.Add(this.panel7);
            this.accContainer.Controls.Add(this.panel8);
            this.accContainer.Controls.Add(this.panel6);
            this.accContainer.Location = new System.Drawing.Point(3, 163);
            this.accContainer.Name = "accContainer";
            this.accContainer.Size = new System.Drawing.Size(261, 34);
            this.accContainer.TabIndex = 7;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnAccount);
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(0);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.panel7.Size = new System.Drawing.Size(261, 34);
            this.panel7.TabIndex = 7;
            // 
            // btnAccount
            // 
            this.btnAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAccount.ForeColor = System.Drawing.Color.White;
            this.btnAccount.Image = ((System.Drawing.Image)(resources.GetObject("btnAccount.Image")));
            this.btnAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccount.Location = new System.Drawing.Point(-7, -17);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Padding = new System.Windows.Forms.Padding(21, 0, 0, 0);
            this.btnAccount.Size = new System.Drawing.Size(275, 68);
            this.btnAccount.TabIndex = 2;
            this.btnAccount.Text = "Account";
            this.btnAccount.UseVisualStyleBackColor = false;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btnChangePass);
            this.panel8.Location = new System.Drawing.Point(0, 34);
            this.panel8.Margin = new System.Windows.Forms.Padding(0);
            this.panel8.Name = "panel8";
            this.panel8.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.panel8.Size = new System.Drawing.Size(261, 34);
            this.panel8.TabIndex = 9;
            // 
            // btnChangePass
            // 
            this.btnChangePass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnChangePass.ForeColor = System.Drawing.Color.White;
            this.btnChangePass.Image = ((System.Drawing.Image)(resources.GetObject("btnChangePass.Image")));
            this.btnChangePass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangePass.Location = new System.Drawing.Point(-7, -17);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Padding = new System.Windows.Forms.Padding(21, 0, 0, 0);
            this.btnChangePass.Size = new System.Drawing.Size(275, 68);
            this.btnChangePass.TabIndex = 2;
            this.btnChangePass.Text = "Change Password";
            this.btnChangePass.UseVisualStyleBackColor = false;
            this.btnChangePass.Click += new System.EventHandler(this.btnChangePass_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnChangeUsername);
            this.panel6.Location = new System.Drawing.Point(0, 68);
            this.panel6.Margin = new System.Windows.Forms.Padding(0);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.panel6.Size = new System.Drawing.Size(261, 34);
            this.panel6.TabIndex = 8;
            // 
            // btnChangeUsername
            // 
            this.btnChangeUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnChangeUsername.ForeColor = System.Drawing.Color.White;
            this.btnChangeUsername.Image = ((System.Drawing.Image)(resources.GetObject("btnChangeUsername.Image")));
            this.btnChangeUsername.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangeUsername.Location = new System.Drawing.Point(-7, -17);
            this.btnChangeUsername.Name = "btnChangeUsername";
            this.btnChangeUsername.Padding = new System.Windows.Forms.Padding(21, 0, 0, 0);
            this.btnChangeUsername.Size = new System.Drawing.Size(275, 68);
            this.btnChangeUsername.TabIndex = 2;
            this.btnChangeUsername.Text = "Change Username";
            this.btnChangeUsername.UseVisualStyleBackColor = false;
            this.btnChangeUsername.Click += new System.EventHandler(this.btnChangeUsername_Click);
            // 
            // pnLogout
            // 
            this.pnLogout.Controls.Add(this.btnLogout);
            this.pnLogout.Location = new System.Drawing.Point(3, 203);
            this.pnLogout.Name = "pnLogout";
            this.pnLogout.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.pnLogout.Size = new System.Drawing.Size(261, 34);
            this.pnLogout.TabIndex = 6;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(-7, -17);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(275, 68);
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
            // pnMain
            // 
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(264, 0);
            this.pnMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(1640, 1041);
            this.pnMain.TabIndex = 3;
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.sidebar);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashboardForm";
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            this.sidebar.ResumeLayout(false);
            this.pnDashboard.ResumeLayout(false);
            this.pnUserManagement.ResumeLayout(false);
            this.pnShelfManagement.ResumeLayout(false);
            this.pnReturns.ResumeLayout(false);
            this.accContainer.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.pnLogout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private FlowLayoutPanel sidebar;
        private Button btnDashboard;
        private Panel pnDashboard;
        private Panel pnUserManagement;
        private Button btnUser;
        private Panel pnShelfManagement;
        private Button btnShelf;
        private Panel pnReturns;
        private Button btnReturns;
        private System.Windows.Forms.Timer accTransition;
        private FlowLayoutPanel accContainer;
        private Panel panel7;
        private Button btnAccount;
        private Panel panel8;
        private Button btnChangePass;
        private Panel panel6;
        private Button btnChangeUsername;
        private Panel pnLogout;
        private Button btnLogout;
        private Panel pnMain;
    }
}