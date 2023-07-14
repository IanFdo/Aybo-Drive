namespace Ayubo_App
{
    partial class RentHire
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
            this.Modeltimer = new System.Windows.Forms.Timer(this.components);
            this.btnRent = new Guna.UI2.WinForms.Guna2Button();
            this.btnHire = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMClose = new System.Windows.Forms.Button();
            this.btnLong = new Guna.UI2.WinForms.Guna2Button();
            this.btnDay = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Modeltimer
            // 
            this.Modeltimer.Enabled = true;
            this.Modeltimer.Interval = 1;
            this.Modeltimer.Tick += new System.EventHandler(this.Modeltimer_Tick);
            // 
            // btnRent
            // 
            this.btnRent.Animated = true;
            this.btnRent.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRent.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRent.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRent.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnRent.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRent.ForeColor = System.Drawing.Color.White;
            this.btnRent.Location = new System.Drawing.Point(37, 61);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(154, 124);
            this.btnRent.TabIndex = 0;
            this.btnRent.Text = "Rent";
            this.btnRent.Click += new System.EventHandler(this.btnRent_Click);
            // 
            // btnHire
            // 
            this.btnHire.Animated = true;
            this.btnHire.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHire.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHire.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHire.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHire.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnHire.Font = new System.Drawing.Font("Yu Gothic UI", 18F);
            this.btnHire.ForeColor = System.Drawing.Color.White;
            this.btnHire.Location = new System.Drawing.Point(233, 61);
            this.btnHire.Name = "btnHire";
            this.btnHire.Size = new System.Drawing.Size(154, 124);
            this.btnHire.TabIndex = 0;
            this.btnHire.Text = "Hire";
            this.btnHire.Click += new System.EventHandler(this.btnHire_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(13)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.btnMClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 25);
            this.panel1.TabIndex = 1;
            // 
            // btnMClose
            // 
            this.btnMClose.FlatAppearance.BorderSize = 0;
            this.btnMClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMClose.ForeColor = System.Drawing.Color.White;
            this.btnMClose.Location = new System.Drawing.Point(399, 0);
            this.btnMClose.Name = "btnMClose";
            this.btnMClose.Size = new System.Drawing.Size(25, 25);
            this.btnMClose.TabIndex = 2;
            this.btnMClose.Text = "X";
            this.btnMClose.UseVisualStyleBackColor = true;
            this.btnMClose.Click += new System.EventHandler(this.btnMClose_Click);
            this.btnMClose.MouseLeave += new System.EventHandler(this.btnMClose_MouseLeave);
            this.btnMClose.MouseHover += new System.EventHandler(this.btnMClose_MouseHover);
            // 
            // btnLong
            // 
            this.btnLong.Animated = true;
            this.btnLong.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLong.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLong.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnLong.Font = new System.Drawing.Font("Yu Gothic UI", 18F);
            this.btnLong.ForeColor = System.Drawing.Color.White;
            this.btnLong.Location = new System.Drawing.Point(233, 61);
            this.btnLong.Name = "btnLong";
            this.btnLong.Size = new System.Drawing.Size(154, 124);
            this.btnLong.TabIndex = 5;
            this.btnLong.Text = "Long Tour";
            this.btnLong.Visible = false;
            this.btnLong.Click += new System.EventHandler(this.btnLong_Click);
            // 
            // btnDay
            // 
            this.btnDay.Animated = true;
            this.btnDay.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDay.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDay.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnDay.Font = new System.Drawing.Font("Yu Gothic UI", 18F);
            this.btnDay.ForeColor = System.Drawing.Color.White;
            this.btnDay.Location = new System.Drawing.Point(37, 61);
            this.btnDay.Name = "btnDay";
            this.btnDay.Size = new System.Drawing.Size(154, 124);
            this.btnDay.TabIndex = 6;
            this.btnDay.Text = "Day Tour";
            this.btnDay.Visible = false;
            this.btnDay.Click += new System.EventHandler(this.btnDay_Click);
            // 
            // RentHire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(424, 230);
            this.Controls.Add(this.btnLong);
            this.Controls.Add(this.btnDay);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnHire);
            this.Controls.Add(this.btnRent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RentHire";
            this.Opacity = 0D;
            this.Text = "RentHire";
            this.Load += new System.EventHandler(this.RentHire_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer Modeltimer;
        private Guna.UI2.WinForms.Guna2Button btnRent;
        private Guna.UI2.WinForms.Guna2Button btnHire;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMClose;
        private Guna.UI2.WinForms.Guna2Button btnLong;
        private Guna.UI2.WinForms.Guna2Button btnDay;
    }
}