
namespace Point_Of_Sales
{
    partial class Update_Staff
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtContract = new System.Windows.Forms.ComboBox();
            this.txtRole = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtSuburb = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.employeeTableAdapter1 = new Point_Of_Sales.groupDatasetTableAdapters.EmployeeTableAdapter();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.txtContract);
            this.panel1.Controls.Add(this.txtRole);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.txtPostalCode);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.txtSuburb);
            this.panel1.Controls.Add(this.txtCity);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txtStreet);
            this.panel1.Controls.Add(this.txtPhone);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.txtLName);
            this.panel1.Controls.Add(this.txtFName);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(747, 615);
            this.panel1.TabIndex = 1;
            // 
            // txtContract
            // 
            this.txtContract.FormattingEnabled = true;
            this.txtContract.Items.AddRange(new object[] {
            "Permanent",
            "Part-Time",
            "Week-end",
            "Vacation"});
            this.txtContract.Location = new System.Drawing.Point(380, 383);
            this.txtContract.Name = "txtContract";
            this.txtContract.Size = new System.Drawing.Size(273, 30);
            this.txtContract.TabIndex = 3;
            // 
            // txtRole
            // 
            this.txtRole.FormattingEnabled = true;
            this.txtRole.Items.AddRange(new object[] {
            "Administrator",
            "Sales",
            "Sales Clerk",
            "Bookkeeper"});
            this.txtRole.Location = new System.Drawing.Point(59, 383);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(273, 30);
            this.txtRole.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(376, 358);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 22);
            this.label10.TabIndex = 2;
            this.label10.Text = "Contract";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(55, 358);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 22);
            this.label9.TabIndex = 2;
            this.label9.Text = "Role";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(55, 286);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 22);
            this.label8.TabIndex = 2;
            this.label8.Text = "City";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 22);
            this.label6.TabIndex = 2;
            this.label6.Text = "Street";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "First Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(376, 286);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 22);
            this.label7.TabIndex = 2;
            this.label7.Text = "Postal Code";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(376, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 22);
            this.label5.TabIndex = 2;
            this.label5.Text = "Suburb";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(376, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phone";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(376, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Last Name";
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(224, 539);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(265, 54);
            this.button3.TabIndex = 1;
            this.button3.Text = "CANCEL";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.Location = new System.Drawing.Point(380, 311);
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(273, 29);
            this.txtPostalCode.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(224, 479);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(265, 54);
            this.button2.TabIndex = 1;
            this.button2.Text = "REGISTER STAFF";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtSuburb
            // 
            this.txtSuburb.Location = new System.Drawing.Point(380, 238);
            this.txtSuburb.Name = "txtSuburb";
            this.txtSuburb.Size = new System.Drawing.Size(273, 29);
            this.txtSuburb.TabIndex = 0;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(59, 311);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(273, 29);
            this.txtCity.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(665, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "BACK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(59, 238);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(273, 29);
            this.txtStreet.TabIndex = 0;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(380, 165);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(273, 29);
            this.txtPhone.TabIndex = 0;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(59, 165);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(273, 29);
            this.txtEmail.TabIndex = 0;
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(380, 96);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(273, 29);
            this.txtLName.TabIndex = 0;
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(59, 96);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(273, 29);
            this.txtFName.TabIndex = 0;
            // 
            // employeeTableAdapter1
            // 
            this.employeeTableAdapter1.ClearBeforeFill = true;
            // 
            // Update_Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(771, 639);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Update_Staff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update_Staff";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox txtContract;
        private System.Windows.Forms.ComboBox txtRole;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtPostalCode;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtSuburb;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtFName;
        private groupDatasetTableAdapters.EmployeeTableAdapter employeeTableAdapter1;
    }
}