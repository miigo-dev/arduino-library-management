namespace Arduino_Integrated_LMS
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRegLogin = new Guna.UI2.WinForms.Guna2Button();
            this.btnRegSignUp = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label1 = new System.Windows.Forms.Label();
            this.showPass = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.txtRegConfirmPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtRegUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtRegPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnRegLogin);
            this.panel1.Controls.Add(this.btnRegSignUp);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.showPass);
            this.panel1.Controls.Add(this.txtRegConfirmPass);
            this.panel1.Controls.Add(this.txtRegUsername);
            this.panel1.Controls.Add(this.txtRegPassword);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(436, 1041);
            this.panel1.TabIndex = 0;
            // 
            // btnRegLogin
            // 
            this.btnRegLogin.AutoRoundedCorners = true;
            this.btnRegLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnRegLogin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.btnRegLogin.BorderRadius = 15;
            this.btnRegLogin.BorderThickness = 1;
            this.btnRegLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRegLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRegLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRegLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRegLogin.FillColor = System.Drawing.Color.White;
            this.btnRegLogin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRegLogin.ForeColor = System.Drawing.Color.Black;
            this.btnRegLogin.Location = new System.Drawing.Point(221, 668);
            this.btnRegLogin.Name = "btnRegLogin";
            this.btnRegLogin.Size = new System.Drawing.Size(140, 33);
            this.btnRegLogin.TabIndex = 19;
            this.btnRegLogin.Text = "Log in";
            this.btnRegLogin.Click += new System.EventHandler(this.btnRegLogin_Click);
            // 
            // btnRegSignUp
            // 
            this.btnRegSignUp.AutoRoundedCorners = true;
            this.btnRegSignUp.BackColor = System.Drawing.Color.Transparent;
            this.btnRegSignUp.BorderRadius = 15;
            this.btnRegSignUp.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRegSignUp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRegSignUp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRegSignUp.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRegSignUp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRegSignUp.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(255)))), ((int)(((byte)(202)))));
            this.btnRegSignUp.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.btnRegSignUp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRegSignUp.ForeColor = System.Drawing.Color.Black;
            this.btnRegSignUp.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.btnRegSignUp.Location = new System.Drawing.Point(75, 668);
            this.btnRegSignUp.Name = "btnRegSignUp";
            this.btnRegSignUp.Size = new System.Drawing.Size(140, 33);
            this.btnRegSignUp.TabIndex = 18;
            this.btnRegSignUp.Text = "Sign up";
            this.btnRegSignUp.Click += new System.EventHandler(this.btnRegSignUp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(117, 628);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "Show Password";
            // 
            // showPass
            // 
            this.showPass.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.showPass.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.showPass.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.showPass.CheckedState.InnerColor = System.Drawing.Color.White;
            this.showPass.Location = new System.Drawing.Point(80, 626);
            this.showPass.Name = "showPass";
            this.showPass.Size = new System.Drawing.Size(35, 20);
            this.showPass.TabIndex = 16;
            this.showPass.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.showPass.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.showPass.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.showPass.UncheckedState.InnerColor = System.Drawing.Color.White;
            // 
            // txtRegConfirmPass
            // 
            this.txtRegConfirmPass.AutoRoundedCorners = true;
            this.txtRegConfirmPass.BorderColor = System.Drawing.Color.Green;
            this.txtRegConfirmPass.BorderRadius = 17;
            this.txtRegConfirmPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRegConfirmPass.DefaultText = "";
            this.txtRegConfirmPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRegConfirmPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRegConfirmPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRegConfirmPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRegConfirmPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRegConfirmPass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtRegConfirmPass.ForeColor = System.Drawing.Color.Black;
            this.txtRegConfirmPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRegConfirmPass.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtRegConfirmPass.IconLeft")));
            this.txtRegConfirmPass.Location = new System.Drawing.Point(75, 584);
            this.txtRegConfirmPass.Name = "txtRegConfirmPass";
            this.txtRegConfirmPass.PasswordChar = '●';
            this.txtRegConfirmPass.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtRegConfirmPass.PlaceholderText = "Confirm Password";
            this.txtRegConfirmPass.SelectedText = "";
            this.txtRegConfirmPass.Size = new System.Drawing.Size(286, 36);
            this.txtRegConfirmPass.TabIndex = 14;
            // 
            // txtRegUsername
            // 
            this.txtRegUsername.AutoRoundedCorners = true;
            this.txtRegUsername.BorderColor = System.Drawing.Color.Green;
            this.txtRegUsername.BorderRadius = 17;
            this.txtRegUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRegUsername.DefaultText = "";
            this.txtRegUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRegUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRegUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRegUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRegUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRegUsername.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtRegUsername.ForeColor = System.Drawing.Color.Black;
            this.txtRegUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRegUsername.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtRegUsername.IconLeft")));
            this.txtRegUsername.Location = new System.Drawing.Point(75, 500);
            this.txtRegUsername.Name = "txtRegUsername";
            this.txtRegUsername.PasswordChar = '\0';
            this.txtRegUsername.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtRegUsername.PlaceholderText = "Username";
            this.txtRegUsername.SelectedText = "";
            this.txtRegUsername.Size = new System.Drawing.Size(286, 36);
            this.txtRegUsername.TabIndex = 12;
            // 
            // txtRegPassword
            // 
            this.txtRegPassword.AutoRoundedCorners = true;
            this.txtRegPassword.BorderColor = System.Drawing.Color.Green;
            this.txtRegPassword.BorderRadius = 17;
            this.txtRegPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRegPassword.DefaultText = "";
            this.txtRegPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRegPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRegPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRegPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRegPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRegPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtRegPassword.ForeColor = System.Drawing.Color.Black;
            this.txtRegPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRegPassword.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtRegPassword.IconLeft")));
            this.txtRegPassword.Location = new System.Drawing.Point(75, 542);
            this.txtRegPassword.Name = "txtRegPassword";
            this.txtRegPassword.PasswordChar = '●';
            this.txtRegPassword.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtRegPassword.PlaceholderText = "Password";
            this.txtRegPassword.SelectedText = "";
            this.txtRegPassword.Size = new System.Drawing.Size(286, 36);
            this.txtRegPassword.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label3.Location = new System.Drawing.Point(192, 456);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hi there!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(150, 432);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Create an Account";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(168, 339);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 80);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtRegConfirmPass;
        private Guna.UI2.WinForms.Guna2TextBox txtRegUsername;
        private Guna.UI2.WinForms.Guna2TextBox txtRegPassword;
        private Label label1;
        private Guna.UI2.WinForms.Guna2ToggleSwitch showPass;
        private Guna.UI2.WinForms.Guna2Button btnRegLogin;
        private Guna.UI2.WinForms.Guna2GradientButton btnRegSignUp;
    }
}