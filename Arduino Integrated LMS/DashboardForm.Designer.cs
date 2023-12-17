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
            this.pnDashboard = new System.Windows.Forms.Panel();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.qrContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnScanQR = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnReturn = new System.Windows.Forms.Button();
            this.pnUserManagement = new System.Windows.Forms.Panel();
            this.btnUser = new System.Windows.Forms.Button();
            this.pnShelfManagement = new System.Windows.Forms.Panel();
            this.btnShelf = new System.Windows.Forms.Button();
            this.accContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnAccount = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnChangeUsername = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnChangePass = new System.Windows.Forms.Button();
            this.pnLogout = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.accTransition = new System.Windows.Forms.Timer(this.components);
            this.pnMain = new System.Windows.Forms.Panel();
            this.qrTransition = new System.Windows.Forms.Timer(this.components);
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.pnDashboard.SuspendLayout();
            this.qrContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnUserManagement.SuspendLayout();
            this.pnShelfManagement.SuspendLayout();
            this.accContainer.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel8.SuspendLayout();
            this.pnLogout.SuspendLayout();
            this.sidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnDashboard
            // 
            this.pnDashboard.Controls.Add(this.btnDashboard);
            this.pnDashboard.Location = new System.Drawing.Point(3, 3);
            this.pnDashboard.Name = "pnDashboard";
            this.pnDashboard.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.pnDashboard.Size = new System.Drawing.Size(433, 34);
            this.pnDashboard.TabIndex = 3;
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(-7, -17);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(21, 0, 0, 0);
            this.btnDashboard.Size = new System.Drawing.Size(443, 68);
            this.btnDashboard.TabIndex = 2;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // qrContainer
            // 
            this.qrContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.qrContainer.Controls.Add(this.panel1);
            this.qrContainer.Controls.Add(this.panel2);
            this.qrContainer.Controls.Add(this.panel3);
            this.qrContainer.Location = new System.Drawing.Point(0, 40);
            this.qrContainer.Margin = new System.Windows.Forms.Padding(0);
            this.qrContainer.Name = "qrContainer";
            this.qrContainer.Size = new System.Drawing.Size(436, 34);
            this.qrContainer.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnScanQR);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.panel1.Size = new System.Drawing.Size(433, 34);
            this.panel1.TabIndex = 7;
            // 
            // btnScanQR
            // 
            this.btnScanQR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnScanQR.ForeColor = System.Drawing.Color.White;
            this.btnScanQR.Image = ((System.Drawing.Image)(resources.GetObject("btnScanQR.Image")));
            this.btnScanQR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnScanQR.Location = new System.Drawing.Point(-7, -17);
            this.btnScanQR.Name = "btnScanQR";
            this.btnScanQR.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.btnScanQR.Size = new System.Drawing.Size(444, 68);
            this.btnScanQR.TabIndex = 2;
            this.btnScanQR.Text = "Scan QR";
            this.btnScanQR.UseVisualStyleBackColor = false;
            this.btnScanQR.Click += new System.EventHandler(this.btnScanQR_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCheckout);
            this.panel2.Location = new System.Drawing.Point(0, 34);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.panel2.Size = new System.Drawing.Size(433, 34);
            this.panel2.TabIndex = 7;
            // 
            // btnCheckout
            // 
            this.btnCheckout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnCheckout.ForeColor = System.Drawing.Color.White;
            this.btnCheckout.Image = ((System.Drawing.Image)(resources.GetObject("btnCheckout.Image")));
            this.btnCheckout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCheckout.Location = new System.Drawing.Point(-7, -17);
            this.btnCheckout.Margin = new System.Windows.Forms.Padding(0);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.btnCheckout.Size = new System.Drawing.Size(446, 68);
            this.btnCheckout.TabIndex = 2;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.UseVisualStyleBackColor = false;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnReturn);
            this.panel3.Location = new System.Drawing.Point(0, 68);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.panel3.Size = new System.Drawing.Size(433, 34);
            this.panel3.TabIndex = 8;
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnReturn.ForeColor = System.Drawing.Color.White;
            this.btnReturn.Image = ((System.Drawing.Image)(resources.GetObject("btnReturn.Image")));
            this.btnReturn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReturn.Location = new System.Drawing.Point(-7, -17);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(30);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.btnReturn.Size = new System.Drawing.Size(446, 68);
            this.btnReturn.TabIndex = 2;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // pnUserManagement
            // 
            this.pnUserManagement.Controls.Add(this.btnUser);
            this.pnUserManagement.Location = new System.Drawing.Point(3, 77);
            this.pnUserManagement.Name = "pnUserManagement";
            this.pnUserManagement.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.pnUserManagement.Size = new System.Drawing.Size(433, 34);
            this.pnUserManagement.TabIndex = 4;
            // 
            // btnUser
            // 
            this.btnUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnUser.ForeColor = System.Drawing.Color.White;
            this.btnUser.Image = ((System.Drawing.Image)(resources.GetObject("btnUser.Image")));
            this.btnUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUser.Location = new System.Drawing.Point(-7, -17);
            this.btnUser.Name = "btnUser";
            this.btnUser.Padding = new System.Windows.Forms.Padding(21, 0, 0, 0);
            this.btnUser.Size = new System.Drawing.Size(443, 68);
            this.btnUser.TabIndex = 2;
            this.btnUser.Text = "User Management";
            this.btnUser.UseVisualStyleBackColor = false;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // pnShelfManagement
            // 
            this.pnShelfManagement.Controls.Add(this.btnShelf);
            this.pnShelfManagement.Location = new System.Drawing.Point(3, 117);
            this.pnShelfManagement.Name = "pnShelfManagement";
            this.pnShelfManagement.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.pnShelfManagement.Size = new System.Drawing.Size(433, 34);
            this.pnShelfManagement.TabIndex = 4;
            // 
            // btnShelf
            // 
            this.btnShelf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnShelf.ForeColor = System.Drawing.Color.White;
            this.btnShelf.Image = ((System.Drawing.Image)(resources.GetObject("btnShelf.Image")));
            this.btnShelf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShelf.Location = new System.Drawing.Point(-7, -17);
            this.btnShelf.Name = "btnShelf";
            this.btnShelf.Padding = new System.Windows.Forms.Padding(21, 0, 0, 0);
            this.btnShelf.Size = new System.Drawing.Size(443, 68);
            this.btnShelf.TabIndex = 2;
            this.btnShelf.Text = "Shelf Management";
            this.btnShelf.UseVisualStyleBackColor = false;
            this.btnShelf.Click += new System.EventHandler(this.btnShelf_Click);
            // 
            // accContainer
            // 
            this.accContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.accContainer.Controls.Add(this.panel7);
            this.accContainer.Controls.Add(this.panel6);
            this.accContainer.Controls.Add(this.panel8);
            this.accContainer.Location = new System.Drawing.Point(0, 154);
            this.accContainer.Margin = new System.Windows.Forms.Padding(0);
            this.accContainer.Name = "accContainer";
            this.accContainer.Size = new System.Drawing.Size(436, 34);
            this.accContainer.TabIndex = 7;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnAccount);
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(0);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.panel7.Size = new System.Drawing.Size(436, 34);
            this.panel7.TabIndex = 7;
            // 
            // btnAccount
            // 
            this.btnAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnAccount.ForeColor = System.Drawing.Color.White;
            this.btnAccount.Image = ((System.Drawing.Image)(resources.GetObject("btnAccount.Image")));
            this.btnAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccount.Location = new System.Drawing.Point(-7, -17);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnAccount.Size = new System.Drawing.Size(446, 68);
            this.btnAccount.TabIndex = 2;
            this.btnAccount.Text = "Account";
            this.btnAccount.UseVisualStyleBackColor = false;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnChangeUsername);
            this.panel6.Location = new System.Drawing.Point(0, 34);
            this.panel6.Margin = new System.Windows.Forms.Padding(0);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.panel6.Size = new System.Drawing.Size(436, 34);
            this.panel6.TabIndex = 8;
            // 
            // btnChangeUsername
            // 
            this.btnChangeUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnChangeUsername.ForeColor = System.Drawing.Color.White;
            this.btnChangeUsername.Image = ((System.Drawing.Image)(resources.GetObject("btnChangeUsername.Image")));
            this.btnChangeUsername.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangeUsername.Location = new System.Drawing.Point(-7, -17);
            this.btnChangeUsername.Name = "btnChangeUsername";
            this.btnChangeUsername.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnChangeUsername.Size = new System.Drawing.Size(446, 68);
            this.btnChangeUsername.TabIndex = 2;
            this.btnChangeUsername.Text = "Change Username";
            this.btnChangeUsername.UseVisualStyleBackColor = false;
            this.btnChangeUsername.Click += new System.EventHandler(this.btnChangeUsername_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btnChangePass);
            this.panel8.Location = new System.Drawing.Point(0, 68);
            this.panel8.Margin = new System.Windows.Forms.Padding(0);
            this.panel8.Name = "panel8";
            this.panel8.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.panel8.Size = new System.Drawing.Size(436, 34);
            this.panel8.TabIndex = 9;
            // 
            // btnChangePass
            // 
            this.btnChangePass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnChangePass.ForeColor = System.Drawing.Color.White;
            this.btnChangePass.Image = ((System.Drawing.Image)(resources.GetObject("btnChangePass.Image")));
            this.btnChangePass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangePass.Location = new System.Drawing.Point(-7, -17);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnChangePass.Size = new System.Drawing.Size(446, 68);
            this.btnChangePass.TabIndex = 2;
            this.btnChangePass.Text = "Change Password";
            this.btnChangePass.UseVisualStyleBackColor = false;
            this.btnChangePass.Click += new System.EventHandler(this.btnChangePass_Click);
            // 
            // pnLogout
            // 
            this.pnLogout.Controls.Add(this.btnLogout);
            this.pnLogout.Location = new System.Drawing.Point(3, 191);
            this.pnLogout.Name = "pnLogout";
            this.pnLogout.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.pnLogout.Size = new System.Drawing.Size(433, 34);
            this.pnLogout.TabIndex = 6;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(-7, -17);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(24, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(443, 68);
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
            this.pnMain.Location = new System.Drawing.Point(436, 0);
            this.pnMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(1148, 761);
            this.pnMain.TabIndex = 3;
            // 
            // qrTransition
            // 
            this.qrTransition.Interval = 5;
            this.qrTransition.Tick += new System.EventHandler(this.qrTransition_Tick);
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.sidebar.Controls.Add(this.pnDashboard);
            this.sidebar.Controls.Add(this.qrContainer);
            this.sidebar.Controls.Add(this.pnUserManagement);
            this.sidebar.Controls.Add(this.pnShelfManagement);
            this.sidebar.Controls.Add(this.accContainer);
            this.sidebar.Controls.Add(this.pnLogout);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(436, 761);
            this.sidebar.TabIndex = 1;
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1584, 761);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.sidebar);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashboardForm";
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            this.pnDashboard.ResumeLayout(false);
            this.qrContainer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.pnUserManagement.ResumeLayout(false);
            this.pnShelfManagement.ResumeLayout(false);
            this.accContainer.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.pnLogout.ResumeLayout(false);
            this.sidebar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Button btnDashboard;
        private Panel pnDashboard;
        private Panel pnUserManagement;
        private Button btnUser;
        private Panel pnShelfManagement;
        private Button btnShelf;
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
        private Panel panel3;
        private Button btnReturn;
        private Panel panel2;
        private Button btnCheckout;
        private Panel panel1;
        private Button btnScanQR;
        private FlowLayoutPanel qrContainer;
        private System.Windows.Forms.Timer qrTransition;
        private FlowLayoutPanel sidebar;
    }
}