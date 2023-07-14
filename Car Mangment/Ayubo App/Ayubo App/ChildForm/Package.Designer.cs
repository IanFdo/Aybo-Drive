namespace Ayubo_App.ChildForm
{
    partial class Package
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
            this.btnPSearch = new Guna.UI2.WinForms.Guna2Button();
            this.btnPUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.btnPSave = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPackageName = new System.Windows.Forms.TextBox();
            this.comPackageType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBaseCharge = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblPackage = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDailykmLimit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtExtraperkm = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPSearch
            // 
            this.btnPSearch.Animated = true;
            this.btnPSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnPSearch.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPSearch.ForeColor = System.Drawing.Color.White;
            this.btnPSearch.Location = new System.Drawing.Point(663, 101);
            this.btnPSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnPSearch.Name = "btnPSearch";
            this.btnPSearch.Size = new System.Drawing.Size(240, 54);
            this.btnPSearch.TabIndex = 5;
            this.btnPSearch.Text = "Search";
            this.btnPSearch.Click += new System.EventHandler(this.btnPSearch_Click);
            // 
            // btnPUpdate
            // 
            this.btnPUpdate.Animated = true;
            this.btnPUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPUpdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnPUpdate.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPUpdate.ForeColor = System.Drawing.Color.White;
            this.btnPUpdate.Location = new System.Drawing.Point(663, 172);
            this.btnPUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnPUpdate.Name = "btnPUpdate";
            this.btnPUpdate.Size = new System.Drawing.Size(240, 54);
            this.btnPUpdate.TabIndex = 6;
            this.btnPUpdate.Text = "Update";
            this.btnPUpdate.Click += new System.EventHandler(this.btnPUpdate_Click);
            // 
            // btnPSave
            // 
            this.btnPSave.Animated = true;
            this.btnPSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnPSave.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.btnPSave.ForeColor = System.Drawing.Color.White;
            this.btnPSave.Location = new System.Drawing.Point(663, 28);
            this.btnPSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnPSave.Name = "btnPSave";
            this.btnPSave.Size = new System.Drawing.Size(240, 54);
            this.btnPSave.TabIndex = 7;
            this.btnPSave.Text = "Save";
            this.btnPSave.Click += new System.EventHandler(this.btnPSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPackageName);
            this.groupBox1.Controls.Add(this.comPackageType);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtExtraperkm);
            this.groupBox1.Controls.Add(this.txtDailykmLimit);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtBaseCharge);
            this.groupBox1.Controls.Add(this.lblLastName);
            this.groupBox1.Controls.Add(this.lblPackage);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(619, 480);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // txtPackageName
            // 
            this.txtPackageName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            this.txtPackageName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPackageName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPackageName.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPackageName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtPackageName.Location = new System.Drawing.Point(247, 31);
            this.txtPackageName.Margin = new System.Windows.Forms.Padding(4);
            this.txtPackageName.Multiline = true;
            this.txtPackageName.Name = "txtPackageName";
            this.txtPackageName.Size = new System.Drawing.Size(347, 31);
            this.txtPackageName.TabIndex = 20;
            this.txtPackageName.Tag = "";
            // 
            // comPackageType
            // 
            this.comPackageType.BackColor = System.Drawing.Color.Transparent;
            this.comPackageType.BorderThickness = 0;
            this.comPackageType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comPackageType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comPackageType.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            this.comPackageType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comPackageType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comPackageType.Font = new System.Drawing.Font("Nirmala UI", 14.25F);
            this.comPackageType.ForeColor = System.Drawing.Color.Black;
            this.comPackageType.ItemHeight = 30;
            this.comPackageType.Items.AddRange(new object[] {
            "Day Tour",
            "Long tour"});
            this.comPackageType.Location = new System.Drawing.Point(247, 86);
            this.comPackageType.Margin = new System.Windows.Forms.Padding(4);
            this.comPackageType.Name = "comPackageType";
            this.comPackageType.Size = new System.Drawing.Size(347, 36);
            this.comPackageType.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(158)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(15, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Package Type";
            // 
            // txtBaseCharge
            // 
            this.txtBaseCharge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            this.txtBaseCharge.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBaseCharge.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBaseCharge.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBaseCharge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtBaseCharge.Location = new System.Drawing.Point(247, 143);
            this.txtBaseCharge.Margin = new System.Windows.Forms.Padding(4);
            this.txtBaseCharge.Multiline = true;
            this.txtBaseCharge.Name = "txtBaseCharge";
            this.txtBaseCharge.Size = new System.Drawing.Size(347, 31);
            this.txtBaseCharge.TabIndex = 1;
            this.txtBaseCharge.Tag = "";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(158)))), ((int)(((byte)(249)))));
            this.lblLastName.Location = new System.Drawing.Point(15, 140);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(163, 37);
            this.lblLastName.TabIndex = 0;
            this.lblLastName.Text = "Base Charge";
            // 
            // lblPackage
            // 
            this.lblPackage.AutoSize = true;
            this.lblPackage.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPackage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(158)))), ((int)(((byte)(249)))));
            this.lblPackage.Location = new System.Drawing.Point(15, 31);
            this.lblPackage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPackage.Name = "lblPackage";
            this.lblPackage.Size = new System.Drawing.Size(192, 37);
            this.lblPackage.TabIndex = 0;
            this.lblPackage.Text = "Package Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(158)))), ((int)(((byte)(249)))));
            this.label2.Location = new System.Drawing.Point(15, 313);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 37);
            this.label2.TabIndex = 0;
            this.label2.Text = "Daily km Limit";
            // 
            // txtDailykmLimit
            // 
            this.txtDailykmLimit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            this.txtDailykmLimit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDailykmLimit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDailykmLimit.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDailykmLimit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtDailykmLimit.Location = new System.Drawing.Point(247, 319);
            this.txtDailykmLimit.Margin = new System.Windows.Forms.Padding(4);
            this.txtDailykmLimit.Multiline = true;
            this.txtDailykmLimit.Name = "txtDailykmLimit";
            this.txtDailykmLimit.Size = new System.Drawing.Size(92, 31);
            this.txtDailykmLimit.TabIndex = 1;
            this.txtDailykmLimit.Tag = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(158)))), ((int)(((byte)(249)))));
            this.label3.Location = new System.Drawing.Point(15, 257);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 37);
            this.label3.TabIndex = 0;
            this.label3.Text = "Extra per km";
            // 
            // txtExtraperkm
            // 
            this.txtExtraperkm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(74)))), ((int)(((byte)(99)))));
            this.txtExtraperkm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtExtraperkm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtExtraperkm.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExtraperkm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtExtraperkm.Location = new System.Drawing.Point(247, 263);
            this.txtExtraperkm.Margin = new System.Windows.Forms.Padding(4);
            this.txtExtraperkm.Multiline = true;
            this.txtExtraperkm.Name = "txtExtraperkm";
            this.txtExtraperkm.Size = new System.Drawing.Size(92, 31);
            this.txtExtraperkm.TabIndex = 1;
            this.txtExtraperkm.Tag = "";
            // 
            // Package
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(919, 508);
            this.Controls.Add(this.btnPSearch);
            this.Controls.Add(this.btnPUpdate);
            this.Controls.Add(this.btnPSave);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Package";
            this.Text = "Package";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnPSearch;
        private Guna.UI2.WinForms.Guna2Button btnPUpdate;
        private Guna.UI2.WinForms.Guna2Button btnPSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBaseCharge;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblPackage;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox comPackageType;
        private System.Windows.Forms.TextBox txtPackageName;
        private System.Windows.Forms.TextBox txtExtraperkm;
        private System.Windows.Forms.TextBox txtDailykmLimit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}