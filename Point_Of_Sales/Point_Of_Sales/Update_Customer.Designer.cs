
namespace Point_Of_Sales
{
    partial class Update_Customer
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtSuburb = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.groupDataset = new Point_Of_Sales.groupDataset();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter = new Point_Of_Sales.groupDatasetTableAdapters.CustomerTableAdapter();
            this.tableAdapterManager = new Point_Of_Sales.groupDatasetTableAdapters.TableAdapterManager();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupDataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtCode);
            this.panel1.Controls.Add(this.txtCity);
            this.panel1.Controls.Add(this.txtSuburb);
            this.panel1.Controls.Add(this.txtStreet);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.txtPhone);
            this.panel1.Controls.Add(this.txtLName);
            this.panel1.Controls.Add(this.txtFName);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(662, 590);
            this.panel1.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(193, 499);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(280, 59);
            this.button3.TabIndex = 3;
            this.button3.Text = "CLEAR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(193, 434);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(280, 59);
            this.button2.TabIndex = 3;
            this.button2.Text = "UPDATE CUSTOMER";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(556, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 41);
            this.button1.TabIndex = 3;
            this.button1.Text = "BACK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(365, 334);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 22);
            this.label8.TabIndex = 1;
            this.label8.Text = "Postal Code";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(365, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 22);
            this.label6.TabIndex = 1;
            this.label6.Text = "Suburb";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(365, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(365, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(54, 334);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 22);
            this.label7.TabIndex = 1;
            this.label7.Text = "City";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 22);
            this.label5.TabIndex = 1;
            this.label5.Text = "Street";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Phone";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Name";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(369, 359);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(264, 29);
            this.txtCode.TabIndex = 0;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(58, 359);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(264, 29);
            this.txtCity.TabIndex = 0;
            // 
            // txtSuburb
            // 
            this.txtSuburb.Location = new System.Drawing.Point(369, 282);
            this.txtSuburb.Name = "txtSuburb";
            this.txtSuburb.Size = new System.Drawing.Size(264, 29);
            this.txtSuburb.TabIndex = 0;
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(58, 282);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(264, 29);
            this.txtStreet.TabIndex = 0;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(369, 207);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(264, 29);
            this.txtEmail.TabIndex = 0;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(58, 207);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(264, 29);
            this.txtPhone.TabIndex = 0;
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(369, 133);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(264, 29);
            this.txtLName.TabIndex = 0;
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(58, 133);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(264, 29);
            this.txtFName.TabIndex = 0;
            // 
            // groupDataset
            // 
            this.groupDataset.DataSetName = "groupDataset";
            this.groupDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.groupDataset;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomerTableAdapter = this.customerTableAdapter;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.PaymentsTableAdapter = null;
            this.tableAdapterManager.Product_SaleTableAdapter = null;
            this.tableAdapterManager.ProductsTableAdapter = null;
            this.tableAdapterManager.SalesTableAdapter = null;
            this.tableAdapterManager.SupplierTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Point_Of_Sales.groupDatasetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Update_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(685, 614);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Update_Customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update_Customer";
            this.Load += new System.EventHandler(this.Update_Customer_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupDataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtSuburb;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtFName;
        private groupDataset groupDataset;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private groupDatasetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private groupDatasetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}