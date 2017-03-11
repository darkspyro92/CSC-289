namespace Invoice
{
    partial class DatabaseForm
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
            this.databaseTabControl = new System.Windows.Forms.TabControl();
            this.userDatabaseTab = new System.Windows.Forms.TabPage();
            this.invoiceDatabaseTab = new System.Windows.Forms.TabPage();
            this.databaseTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // databaseTabControl
            // 
            this.databaseTabControl.Controls.Add(this.userDatabaseTab);
            this.databaseTabControl.Controls.Add(this.invoiceDatabaseTab);
            this.databaseTabControl.Location = new System.Drawing.Point(0, 0);
            this.databaseTabControl.Name = "databaseTabControl";
            this.databaseTabControl.SelectedIndex = 0;
            this.databaseTabControl.Size = new System.Drawing.Size(410, 424);
            this.databaseTabControl.TabIndex = 0;
            // 
            // userDatabaseTab
            // 
            this.userDatabaseTab.Location = new System.Drawing.Point(4, 22);
            this.userDatabaseTab.Name = "userDatabaseTab";
            this.userDatabaseTab.Padding = new System.Windows.Forms.Padding(3);
            this.userDatabaseTab.Size = new System.Drawing.Size(402, 398);
            this.userDatabaseTab.TabIndex = 0;
            this.userDatabaseTab.Text = "Users";
            this.userDatabaseTab.UseVisualStyleBackColor = true;
            // 
            // invoiceDatabaseTab
            // 
            this.invoiceDatabaseTab.Location = new System.Drawing.Point(4, 22);
            this.invoiceDatabaseTab.Name = "invoiceDatabaseTab";
            this.invoiceDatabaseTab.Padding = new System.Windows.Forms.Padding(3);
            this.invoiceDatabaseTab.Size = new System.Drawing.Size(402, 398);
            this.invoiceDatabaseTab.TabIndex = 1;
            this.invoiceDatabaseTab.Text = "Invoices";
            this.invoiceDatabaseTab.UseVisualStyleBackColor = true;
            // 
            // DatabaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 422);
            this.Controls.Add(this.databaseTabControl);
            this.Name = "DatabaseForm";
            this.Text = "DatabaseForm";
            this.databaseTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl databaseTabControl;
        private System.Windows.Forms.TabPage userDatabaseTab;
        private System.Windows.Forms.TabPage invoiceDatabaseTab;
    }
}