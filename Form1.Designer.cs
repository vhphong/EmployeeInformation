namespace EmployeeInformation
{
	partial class frmUI
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
			this.pnlEntry = new System.Windows.Forms.Panel();
			this.datePickerDOB = new System.Windows.Forms.DateTimePicker();
			this.cboDept = new System.Windows.Forms.ComboBox();
			this.txtAddress = new System.Windows.Forms.TextBox();
			this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dataSetEmployee = new EmployeeInformation.DataSetEmployee();
			this.label8 = new System.Windows.Forms.Label();
			this.txtPhone = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.txtDOB = new System.Windows.Forms.TextBox();
			this.txtSSN = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtLastName = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.txtDept = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtFirstName = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtEID = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.btnSearch = new System.Windows.Forms.Button();
			this.label10 = new System.Windows.Forms.Label();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.btnNew = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.employeeTableAdapter = new EmployeeInformation.DataSetEmployeeTableAdapters.employeeTableAdapter();
			this.eidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ssnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.departmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.pnlEntry.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSetEmployee)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// pnlEntry
			// 
			this.pnlEntry.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.pnlEntry.Controls.Add(this.datePickerDOB);
			this.pnlEntry.Controls.Add(this.cboDept);
			this.pnlEntry.Controls.Add(this.txtAddress);
			this.pnlEntry.Controls.Add(this.label8);
			this.pnlEntry.Controls.Add(this.txtPhone);
			this.pnlEntry.Controls.Add(this.label6);
			this.pnlEntry.Controls.Add(this.txtEmail);
			this.pnlEntry.Controls.Add(this.txtDOB);
			this.pnlEntry.Controls.Add(this.txtSSN);
			this.pnlEntry.Controls.Add(this.label4);
			this.pnlEntry.Controls.Add(this.txtLastName);
			this.pnlEntry.Controls.Add(this.label9);
			this.pnlEntry.Controls.Add(this.txtDept);
			this.pnlEntry.Controls.Add(this.label7);
			this.pnlEntry.Controls.Add(this.txtFirstName);
			this.pnlEntry.Controls.Add(this.label5);
			this.pnlEntry.Controls.Add(this.label2);
			this.pnlEntry.Controls.Add(this.label3);
			this.pnlEntry.Controls.Add(this.txtEID);
			this.pnlEntry.Controls.Add(this.label1);
			this.pnlEntry.ForeColor = System.Drawing.Color.Black;
			this.pnlEntry.Location = new System.Drawing.Point(12, 12);
			this.pnlEntry.Name = "pnlEntry";
			this.pnlEntry.Size = new System.Drawing.Size(1126, 218);
			this.pnlEntry.TabIndex = 0;
			// 
			// datePickerDOB
			// 
			this.datePickerDOB.Location = new System.Drawing.Point(156, 145);
			this.datePickerDOB.Name = "datePickerDOB";
			this.datePickerDOB.Size = new System.Drawing.Size(300, 25);
			this.datePickerDOB.TabIndex = 10;
			this.datePickerDOB.ValueChanged += new System.EventHandler(this.datePickerDOB_ValueChanged);
			// 
			// cboDept
			// 
			this.cboDept.FormattingEnabled = true;
			this.cboDept.Items.AddRange(new object[] {
            "",
            "R&D",
            "IT",
            "Networking",
            "Customer Relation",
            "Information Relation",
            "HR",
            "Reception"});
			this.cboDept.Location = new System.Drawing.Point(740, 19);
			this.cboDept.Name = "cboDept";
			this.cboDept.Size = new System.Drawing.Size(300, 26);
			this.cboDept.TabIndex = 9;
			this.cboDept.SelectedValueChanged += new System.EventHandler(this.cboDept_SelectedValueChanged);
			// 
			// txtAddress
			// 
			this.txtAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "address", true));
			this.txtAddress.Location = new System.Drawing.Point(740, 117);
			this.txtAddress.Multiline = true;
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.Size = new System.Drawing.Size(300, 79);
			this.txtAddress.TabIndex = 8;
			// 
			// employeeBindingSource
			// 
			this.employeeBindingSource.DataMember = "employee";
			this.employeeBindingSource.DataSource = this.dataSetEmployee;
			// 
			// dataSetEmployee
			// 
			this.dataSetEmployee.DataSetName = "DataSetEmployee";
			this.dataSetEmployee.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.ForeColor = System.Drawing.Color.Black;
			this.label8.Location = new System.Drawing.Point(661, 120);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(68, 20);
			this.label8.TabIndex = 1;
			this.label8.Text = "Address";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtPhone
			// 
			this.txtPhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "phone", true));
			this.txtPhone.Location = new System.Drawing.Point(740, 86);
			this.txtPhone.Name = "txtPhone";
			this.txtPhone.Size = new System.Drawing.Size(300, 25);
			this.txtPhone.TabIndex = 7;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.ForeColor = System.Drawing.Color.Black;
			this.label6.Location = new System.Drawing.Point(674, 89);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(55, 20);
			this.label6.TabIndex = 1;
			this.label6.Text = "Phone";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtEmail
			// 
			this.txtEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "email", true));
			this.txtEmail.Location = new System.Drawing.Point(740, 52);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(300, 25);
			this.txtEmail.TabIndex = 6;
			// 
			// txtDOB
			// 
			this.txtDOB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "dob", true));
			this.txtDOB.Location = new System.Drawing.Point(351, 145);
			this.txtDOB.Name = "txtDOB";
			this.txtDOB.Size = new System.Drawing.Size(105, 25);
			this.txtDOB.TabIndex = 4;
			// 
			// txtSSN
			// 
			this.txtSSN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "ssn", true));
			this.txtSSN.Location = new System.Drawing.Point(156, 114);
			this.txtSSN.Name = "txtSSN";
			this.txtSSN.Size = new System.Drawing.Size(300, 25);
			this.txtSSN.TabIndex = 3;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.label4.Location = new System.Drawing.Point(681, 55);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(48, 20);
			this.label4.TabIndex = 1;
			this.label4.Text = "Email";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtLastName
			// 
			this.txtLastName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "lastname", true));
			this.txtLastName.Location = new System.Drawing.Point(156, 83);
			this.txtLastName.Name = "txtLastName";
			this.txtLastName.Size = new System.Drawing.Size(300, 25);
			this.txtLastName.TabIndex = 2;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.ForeColor = System.Drawing.Color.Black;
			this.label9.Location = new System.Drawing.Point(96, 148);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(44, 20);
			this.label9.TabIndex = 1;
			this.label9.Text = "DOB";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtDept
			// 
			this.txtDept.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "department", true));
			this.txtDept.Location = new System.Drawing.Point(740, 19);
			this.txtDept.Name = "txtDept";
			this.txtDept.Size = new System.Drawing.Size(67, 25);
			this.txtDept.TabIndex = 5;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.ForeColor = System.Drawing.Color.Black;
			this.label7.Location = new System.Drawing.Point(98, 117);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(42, 20);
			this.label7.TabIndex = 1;
			this.label7.Text = "SSN";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtFirstName
			// 
			this.txtFirstName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "firstname", true));
			this.txtFirstName.Location = new System.Drawing.Point(156, 52);
			this.txtFirstName.Name = "txtFirstName";
			this.txtFirstName.Size = new System.Drawing.Size(300, 25);
			this.txtFirstName.TabIndex = 1;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.ForeColor = System.Drawing.Color.Black;
			this.label5.Location = new System.Drawing.Point(54, 86);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(86, 20);
			this.label5.TabIndex = 1;
			this.label5.Text = "Last Name";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(635, 22);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(94, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "Department";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(54, 55);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(86, 20);
			this.label3.TabIndex = 1;
			this.label3.Text = "First Name";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtEID
			// 
			this.txtEID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "eid", true));
			this.txtEID.Location = new System.Drawing.Point(156, 21);
			this.txtEID.Name = "txtEID";
			this.txtEID.ReadOnly = true;
			this.txtEID.Size = new System.Drawing.Size(300, 25);
			this.txtEID.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(40, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "Employee ID";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dataGridView
			// 
			this.dataGridView.AutoGenerateColumns = false;
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eidDataGridViewTextBoxColumn,
            this.firstnameDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
            this.dobDataGridViewTextBoxColumn,
            this.ssnDataGridViewTextBoxColumn,
            this.departmentDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn});
			this.dataGridView.DataSource = this.employeeBindingSource;
			this.dataGridView.Location = new System.Drawing.Point(12, 311);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.RowHeadersWidth = 47;
			this.dataGridView.Size = new System.Drawing.Size(1126, 244);
			this.dataGridView.TabIndex = 0;
			this.dataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView_KeyDown);
			// 
			// btnSearch
			// 
			this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSearch.ForeColor = System.Drawing.SystemColors.Highlight;
			this.btnSearch.Location = new System.Drawing.Point(510, 248);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(80, 40);
			this.btnSearch.TabIndex = 0;
			this.btnSearch.Text = "Search";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.ForeColor = System.Drawing.Color.Black;
			this.label10.Location = new System.Drawing.Point(92, 258);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(60, 20);
			this.label10.TabIndex = 1;
			this.label10.Text = "Search";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtSearch
			// 
			this.txtSearch.Location = new System.Drawing.Point(168, 256);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(300, 25);
			this.txtSearch.TabIndex = 2;
			this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
			// 
			// btnNew
			// 
			this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNew.ForeColor = System.Drawing.SystemColors.Highlight;
			this.btnNew.Location = new System.Drawing.Point(619, 248);
			this.btnNew.Name = "btnNew";
			this.btnNew.Size = new System.Drawing.Size(80, 40);
			this.btnNew.TabIndex = 0;
			this.btnNew.Text = "New";
			this.btnNew.UseVisualStyleBackColor = true;
			this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
			// 
			// btnEdit
			// 
			this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEdit.ForeColor = System.Drawing.SystemColors.Highlight;
			this.btnEdit.Location = new System.Drawing.Point(728, 248);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(80, 40);
			this.btnEdit.TabIndex = 1;
			this.btnEdit.Text = "Edit";
			this.btnEdit.UseVisualStyleBackColor = true;
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// btnSave
			// 
			this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSave.ForeColor = System.Drawing.SystemColors.Highlight;
			this.btnSave.Location = new System.Drawing.Point(837, 248);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(80, 40);
			this.btnSave.TabIndex = 2;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancel.ForeColor = System.Drawing.SystemColors.Highlight;
			this.btnCancel.Location = new System.Drawing.Point(946, 248);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(80, 40);
			this.btnCancel.TabIndex = 3;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnExit
			// 
			this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExit.ForeColor = System.Drawing.Color.Red;
			this.btnExit.Location = new System.Drawing.Point(1055, 248);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(80, 40);
			this.btnExit.TabIndex = 4;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// employeeTableAdapter
			// 
			this.employeeTableAdapter.ClearBeforeFill = true;
			// 
			// eidDataGridViewTextBoxColumn
			// 
			this.eidDataGridViewTextBoxColumn.DataPropertyName = "eid";
			this.eidDataGridViewTextBoxColumn.HeaderText = "EID";
			this.eidDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.eidDataGridViewTextBoxColumn.Name = "eidDataGridViewTextBoxColumn";
			this.eidDataGridViewTextBoxColumn.ReadOnly = true;
			this.eidDataGridViewTextBoxColumn.Width = 50;
			// 
			// firstnameDataGridViewTextBoxColumn
			// 
			this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "firstname";
			this.firstnameDataGridViewTextBoxColumn.HeaderText = "First Name";
			this.firstnameDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
			this.firstnameDataGridViewTextBoxColumn.Width = 115;
			// 
			// lastnameDataGridViewTextBoxColumn
			// 
			this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "lastname";
			this.lastnameDataGridViewTextBoxColumn.HeaderText = "Last Name";
			this.lastnameDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
			this.lastnameDataGridViewTextBoxColumn.Width = 115;
			// 
			// dobDataGridViewTextBoxColumn
			// 
			this.dobDataGridViewTextBoxColumn.DataPropertyName = "dob";
			this.dobDataGridViewTextBoxColumn.HeaderText = "DOB";
			this.dobDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.dobDataGridViewTextBoxColumn.Name = "dobDataGridViewTextBoxColumn";
			// 
			// ssnDataGridViewTextBoxColumn
			// 
			this.ssnDataGridViewTextBoxColumn.DataPropertyName = "ssn";
			this.ssnDataGridViewTextBoxColumn.HeaderText = "SSN";
			this.ssnDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.ssnDataGridViewTextBoxColumn.Name = "ssnDataGridViewTextBoxColumn";
			this.ssnDataGridViewTextBoxColumn.Width = 70;
			// 
			// departmentDataGridViewTextBoxColumn
			// 
			this.departmentDataGridViewTextBoxColumn.DataPropertyName = "department";
			this.departmentDataGridViewTextBoxColumn.HeaderText = "Dept.";
			this.departmentDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.departmentDataGridViewTextBoxColumn.Name = "departmentDataGridViewTextBoxColumn";
			this.departmentDataGridViewTextBoxColumn.Width = 115;
			// 
			// emailDataGridViewTextBoxColumn
			// 
			this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
			this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
			this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
			this.emailDataGridViewTextBoxColumn.Width = 150;
			// 
			// phoneDataGridViewTextBoxColumn
			// 
			this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
			this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
			this.phoneDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
			this.phoneDataGridViewTextBoxColumn.Width = 150;
			// 
			// addressDataGridViewTextBoxColumn
			// 
			this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
			this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
			this.addressDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
			this.addressDataGridViewTextBoxColumn.Width = 180;
			// 
			// frmUI
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1150, 567);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnEdit);
			this.Controls.Add(this.btnNew);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.dataGridView);
			this.Controls.Add(this.pnlEntry);
			this.Controls.Add(this.txtSearch);
			this.Controls.Add(this.label10);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.Color.Blue;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmUI";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Employee Information";
			this.Load += new System.EventHandler(this.frmUI_Load);
			this.pnlEntry.ResumeLayout(false);
			this.pnlEntry.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSetEmployee)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel pnlEntry;
		private System.Windows.Forms.DataGridView dataGridView;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.TextBox txtEID;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtAddress;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtPhone;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.TextBox txtSSN;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtLastName;
		private System.Windows.Forms.TextBox txtDept;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtFirstName;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtDOB;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtSearch;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Button btnNew;
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnExit;
		private DataSetEmployee dataSetEmployee;
		private System.Windows.Forms.BindingSource employeeBindingSource;
		private DataSetEmployeeTableAdapters.employeeTableAdapter employeeTableAdapter;
		private System.Windows.Forms.ComboBox cboDept;
		private System.Windows.Forms.DateTimePicker datePickerDOB;
		private System.Windows.Forms.DataGridViewTextBoxColumn eidDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dobDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn ssnDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn departmentDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
	}
}

