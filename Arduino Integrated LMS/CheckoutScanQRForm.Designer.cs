namespace Arduino_Integrated_LMS
{
    partial class CheckoutScanQRForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckoutScanQRForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtStudentNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnStop = new Guna.UI2.WinForms.Guna2Button();
            this.btnStart = new Guna.UI2.WinForms.Guna2Button();
            this.cbDevice = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(350, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(783, 434);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // txtStudentNumber
            // 
            this.txtStudentNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStudentNumber.DefaultText = "";
            this.txtStudentNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtStudentNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtStudentNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStudentNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStudentNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtStudentNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtStudentNumber.ForeColor = System.Drawing.Color.Black;
            this.txtStudentNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtStudentNumber.Location = new System.Drawing.Point(12, 12);
            this.txtStudentNumber.Name = "txtStudentNumber";
            this.txtStudentNumber.PasswordChar = '\0';
            this.txtStudentNumber.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtStudentNumber.PlaceholderText = "Enter Student Number";
            this.txtStudentNumber.SelectedText = "";
            this.txtStudentNumber.Size = new System.Drawing.Size(332, 36);
            this.txtStudentNumber.TabIndex = 6;
            // 
            // listView1
            // 
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 54);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(332, 434);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // btnStop
            // 
            this.btnStop.AutoRoundedCorners = true;
            this.btnStop.BackColor = System.Drawing.Color.Transparent;
            this.btnStop.BorderRadius = 16;
            this.btnStop.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStop.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStop.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStop.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStop.FillColor = System.Drawing.Color.Tomato;
            this.btnStop.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnStop.ForeColor = System.Drawing.Color.Black;
            this.btnStop.Location = new System.Drawing.Point(181, 494);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(159, 35);
            this.btnStop.TabIndex = 10;
            this.btnStop.Text = "Stop";
            this.btnStop.UseTransparentBackground = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
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
            this.btnStart.Location = new System.Drawing.Point(12, 494);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(163, 35);
            this.btnStart.TabIndex = 11;
            this.btnStart.Text = "Start";
            this.btnStart.UseTransparentBackground = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click_1);
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
            this.cbDevice.Location = new System.Drawing.Point(350, 12);
            this.cbDevice.Name = "cbDevice";
            this.cbDevice.Size = new System.Drawing.Size(783, 36);
            this.cbDevice.TabIndex = 12;
            // 
            // CheckoutScanQRForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1145, 755);
            this.Controls.Add(this.cbDevice);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.txtStudentNumber);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CheckoutScanQRForm";
            this.Text = "CheckoutScanQRForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CheckoutScanQRForm_FormClosing);
            this.Load += new System.EventHandler(this.CheckoutScanQRForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtStudentNumber;
        private ListView listView1;
        private Guna.UI2.WinForms.Guna2Button btnStop;
        private Guna.UI2.WinForms.Guna2Button btnStart;
        private Guna.UI2.WinForms.Guna2ComboBox cbDevice;
    }
}