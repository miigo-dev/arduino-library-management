namespace Arduino_Integrated_LMS
{
    partial class ReturnScanQRForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnScanQRForm));
            this.txtStudentNumberR = new Guna.UI2.WinForms.Guna2TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbDevice = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnStart = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtStudentNumberR
            // 
            this.txtStudentNumberR.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStudentNumberR.DefaultText = "";
            this.txtStudentNumberR.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtStudentNumberR.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtStudentNumberR.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStudentNumberR.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStudentNumberR.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtStudentNumberR.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtStudentNumberR.ForeColor = System.Drawing.Color.Black;
            this.txtStudentNumberR.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtStudentNumberR.Location = new System.Drawing.Point(12, 12);
            this.txtStudentNumberR.Name = "txtStudentNumberR";
            this.txtStudentNumberR.PasswordChar = '\0';
            this.txtStudentNumberR.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtStudentNumberR.PlaceholderText = "Enter Student Number";
            this.txtStudentNumberR.SelectedText = "";
            this.txtStudentNumberR.Size = new System.Drawing.Size(332, 36);
            this.txtStudentNumberR.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(504, 434);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // cbDevice
            // 
            this.cbDevice.AutoRoundedCorners = true;
            this.cbDevice.BackColor = System.Drawing.Color.Transparent;
            this.cbDevice.BorderRadius = 17;
            this.cbDevice.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDevice.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbDevice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbDevice.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbDevice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbDevice.ItemHeight = 30;
            this.cbDevice.Location = new System.Drawing.Point(12, 494);
            this.cbDevice.Name = "cbDevice";
            this.cbDevice.Size = new System.Drawing.Size(504, 36);
            this.cbDevice.TabIndex = 13;
            // 
            // btnStart
            // 
            this.btnStart.AutoRoundedCorners = true;
            this.btnStart.BackColor = System.Drawing.Color.Transparent;
            this.btnStart.BorderRadius = 16;
            this.btnStart.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStart.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStart.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStart.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStart.FillColor = System.Drawing.Color.SpringGreen;
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnStart.ForeColor = System.Drawing.Color.Black;
            this.btnStart.Location = new System.Drawing.Point(350, 13);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(163, 35);
            this.btnStart.TabIndex = 14;
            this.btnStart.Text = "Start";
            this.btnStart.UseTransparentBackground = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click_1);
            // 
            // ReturnScanQRForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1145, 755);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.cbDevice);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtStudentNumberR);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReturnScanQRForm";
            this.Text = "ReturnScanQRForm";
            this.Load += new System.EventHandler(this.ReturnScanQRForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtStudentNumberR;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2ComboBox cbDevice;
        private Guna.UI2.WinForms.Guna2Button btnStart;
    }
}