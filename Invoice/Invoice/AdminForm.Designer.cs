namespace Invoice
{
    partial class AdminForm
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
            this.activateAccountButton = new System.Windows.Forms.Button();
            this.userBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.abcaba5invoiceloginDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.userBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.userBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.selected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usertypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.confirmedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.userBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.abcaba5_invoiceloginDataSet2 = new Invoice.abcaba5_invoiceloginDataSet2();
            this.userTableAdapter1 = new Invoice.abcaba5_invoiceloginDataSet2TableAdapters.UserTableAdapter();
            this.showUnconfirmedAccountsButton = new System.Windows.Forms.Button();
            this.showAllAccountsButton = new System.Windows.Forms.Button();
            this.deleteUserButton = new System.Windows.Forms.Button();
            this.updateInvoiceButton = new System.Windows.Forms.Button();
            this.showAllInvoiceButton = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.projectDBDataSet = new Invoice.ProjectDBDataSet();
            this.invoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invoiceTableAdapter = new Invoice.ProjectDBDataSetTableAdapters.InvoiceTableAdapter();
            this.invoiceIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.officeWorkerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceStatusIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abcaba5invoiceloginDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abcaba5_invoiceloginDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // activateAccountButton
            // 
            this.activateAccountButton.Location = new System.Drawing.Point(225, 201);
            this.activateAccountButton.Name = "activateAccountButton";
            this.activateAccountButton.Size = new System.Drawing.Size(86, 61);
            this.activateAccountButton.TabIndex = 1;
            this.activateAccountButton.Text = "Activate Account";
            this.activateAccountButton.UseVisualStyleBackColor = true;
            this.activateAccountButton.Click += new System.EventHandler(this.confirmAccountButton_Click);
            // 
            // userBindingSource4
            // 
            this.userBindingSource4.DataSource = this.abcaba5invoiceloginDataSetBindingSource;
            // 
            // userBindingSource3
            // 
            this.userBindingSource3.DataSource = this.abcaba5invoiceloginDataSetBindingSource;
            // 
            // userBindingSource2
            // 
            this.userBindingSource2.DataSource = this.abcaba5invoiceloginDataSetBindingSource;
            // 
            // userBindingSource1
            // 
            this.userBindingSource1.DataSource = this.abcaba5invoiceloginDataSetBindingSource;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = this.abcaba5invoiceloginDataSetBindingSource;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.selected,
            this.idDataGridViewTextBoxColumn,
            this.firstnameDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.usertypeDataGridViewTextBoxColumn,
            this.confirmedDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.userBindingSource5;
            this.dataGridView1.Location = new System.Drawing.Point(2, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(843, 192);
            this.dataGridView1.TabIndex = 0;
            // 
            // selected
            // 
            this.selected.HeaderText = "Selected";
            this.selected.Name = "selected";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "firstname";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "firstname";
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "lastname";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "lastname";
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // usertypeDataGridViewTextBoxColumn
            // 
            this.usertypeDataGridViewTextBoxColumn.DataPropertyName = "usertype";
            this.usertypeDataGridViewTextBoxColumn.HeaderText = "usertype";
            this.usertypeDataGridViewTextBoxColumn.Name = "usertypeDataGridViewTextBoxColumn";
            // 
            // confirmedDataGridViewCheckBoxColumn
            // 
            this.confirmedDataGridViewCheckBoxColumn.DataPropertyName = "confirmed";
            this.confirmedDataGridViewCheckBoxColumn.HeaderText = "confirmed";
            this.confirmedDataGridViewCheckBoxColumn.Name = "confirmedDataGridViewCheckBoxColumn";
            // 
            // userBindingSource5
            // 
            this.userBindingSource5.DataMember = "User";
            this.userBindingSource5.DataSource = this.abcaba5_invoiceloginDataSet2;
            // 
            // abcaba5_invoiceloginDataSet2
            // 
            this.abcaba5_invoiceloginDataSet2.DataSetName = "abcaba5_invoiceloginDataSet2";
            this.abcaba5_invoiceloginDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userTableAdapter1
            // 
            this.userTableAdapter1.ClearBeforeFill = true;
            // 
            // showUnconfirmedAccountsButton
            // 
            this.showUnconfirmedAccountsButton.Location = new System.Drawing.Point(341, 201);
            this.showUnconfirmedAccountsButton.Name = "showUnconfirmedAccountsButton";
            this.showUnconfirmedAccountsButton.Size = new System.Drawing.Size(86, 61);
            this.showUnconfirmedAccountsButton.TabIndex = 2;
            this.showUnconfirmedAccountsButton.Text = "Show Accounts That Need Activation";
            this.showUnconfirmedAccountsButton.UseVisualStyleBackColor = true;
            this.showUnconfirmedAccountsButton.Click += new System.EventHandler(this.showUnconfirmedAccountsButton_Click);
            // 
            // showAllAccountsButton
            // 
            this.showAllAccountsButton.Location = new System.Drawing.Point(469, 201);
            this.showAllAccountsButton.Name = "showAllAccountsButton";
            this.showAllAccountsButton.Size = new System.Drawing.Size(86, 61);
            this.showAllAccountsButton.TabIndex = 3;
            this.showAllAccountsButton.Text = "Show All Accounts";
            this.showAllAccountsButton.UseVisualStyleBackColor = true;
            this.showAllAccountsButton.Click += new System.EventHandler(this.showAllAccountsButton_Click);
            // 
            // deleteUserButton
            // 
            this.deleteUserButton.Location = new System.Drawing.Point(600, 201);
            this.deleteUserButton.Name = "deleteUserButton";
            this.deleteUserButton.Size = new System.Drawing.Size(86, 61);
            this.deleteUserButton.TabIndex = 5;
            this.deleteUserButton.Text = "Delete Selected User";
            this.deleteUserButton.UseVisualStyleBackColor = true;
            this.deleteUserButton.Click += new System.EventHandler(this.deleteUserButton_Click);
            // 
            // updateInvoiceButton
            // 
            this.updateInvoiceButton.Location = new System.Drawing.Point(469, 294);
            this.updateInvoiceButton.Name = "updateInvoiceButton";
            this.updateInvoiceButton.Size = new System.Drawing.Size(86, 61);
            this.updateInvoiceButton.TabIndex = 8;
            this.updateInvoiceButton.Text = "Update Invoices";
            this.updateInvoiceButton.UseVisualStyleBackColor = true;
            this.updateInvoiceButton.Click += new System.EventHandler(this.updateInvoiceButton_Click_1);
            // 
            // showAllInvoiceButton
            // 
            this.showAllInvoiceButton.Location = new System.Drawing.Point(341, 294);
            this.showAllInvoiceButton.Name = "showAllInvoiceButton";
            this.showAllInvoiceButton.Size = new System.Drawing.Size(86, 61);
            this.showAllInvoiceButton.TabIndex = 7;
            this.showAllInvoiceButton.Text = "Show All Invoices";
            this.showAllInvoiceButton.UseVisualStyleBackColor = true;
            this.showAllInvoiceButton.Click += new System.EventHandler(this.showAllInvoiceButton_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn1,
            this.invoiceIDDataGridViewTextBoxColumn,
            this.customerIDDataGridViewTextBoxColumn,
            this.officeWorkerIDDataGridViewTextBoxColumn,
            this.invoiceStatusIDDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.invoiceBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(141, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(545, 192);
            this.dataGridView2.TabIndex = 9;
            this.dataGridView2.Visible = false;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.HeaderText = "Selected";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // projectDBDataSet
            // 
            this.projectDBDataSet.DataSetName = "ProjectDBDataSet";
            this.projectDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // invoiceBindingSource
            // 
            this.invoiceBindingSource.DataMember = "Invoice";
            this.invoiceBindingSource.DataSource = this.projectDBDataSet;
            // 
            // invoiceTableAdapter
            // 
            this.invoiceTableAdapter.ClearBeforeFill = true;
            // 
            // invoiceIDDataGridViewTextBoxColumn
            // 
            this.invoiceIDDataGridViewTextBoxColumn.DataPropertyName = "Invoice_ID";
            this.invoiceIDDataGridViewTextBoxColumn.HeaderText = "Invoice_ID";
            this.invoiceIDDataGridViewTextBoxColumn.Name = "invoiceIDDataGridViewTextBoxColumn";
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "Customer_ID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "Customer_ID";
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            // 
            // officeWorkerIDDataGridViewTextBoxColumn
            // 
            this.officeWorkerIDDataGridViewTextBoxColumn.DataPropertyName = "OfficeWorker_ID";
            this.officeWorkerIDDataGridViewTextBoxColumn.HeaderText = "OfficeWorker_ID";
            this.officeWorkerIDDataGridViewTextBoxColumn.Name = "officeWorkerIDDataGridViewTextBoxColumn";
            // 
            // invoiceStatusIDDataGridViewTextBoxColumn
            // 
            this.invoiceStatusIDDataGridViewTextBoxColumn.DataPropertyName = "Invoice_Status_ID";
            this.invoiceStatusIDDataGridViewTextBoxColumn.HeaderText = "Invoice_Status_ID";
            this.invoiceStatusIDDataGridViewTextBoxColumn.Name = "invoiceStatusIDDataGridViewTextBoxColumn";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 367);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.updateInvoiceButton);
            this.Controls.Add(this.showAllInvoiceButton);
            this.Controls.Add(this.deleteUserButton);
            this.Controls.Add(this.showAllAccountsButton);
            this.Controls.Add(this.showUnconfirmedAccountsButton);
            this.Controls.Add(this.activateAccountButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abcaba5invoiceloginDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abcaba5_invoiceloginDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button activateAccountButton;
        private System.Windows.Forms.BindingSource userBindingSource4;
        private System.Windows.Forms.BindingSource abcaba5invoiceloginDataSetBindingSource;
        private System.Windows.Forms.BindingSource userBindingSource3;
        private System.Windows.Forms.BindingSource userBindingSource2;
        private System.Windows.Forms.BindingSource userBindingSource1;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private abcaba5_invoiceloginDataSet2 abcaba5_invoiceloginDataSet2;
        private System.Windows.Forms.BindingSource userBindingSource5;
        private abcaba5_invoiceloginDataSet2TableAdapters.UserTableAdapter userTableAdapter1;
        private System.Windows.Forms.Button showUnconfirmedAccountsButton;
        private System.Windows.Forms.Button showAllAccountsButton;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selected;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usertypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn confirmedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Button deleteUserButton;
        private System.Windows.Forms.Button updateInvoiceButton;
        private System.Windows.Forms.Button showAllInvoiceButton;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private ProjectDBDataSet projectDBDataSet;
        private System.Windows.Forms.BindingSource invoiceBindingSource;
        private ProjectDBDataSetTableAdapters.InvoiceTableAdapter invoiceTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn officeWorkerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceStatusIDDataGridViewTextBoxColumn;
    }
}