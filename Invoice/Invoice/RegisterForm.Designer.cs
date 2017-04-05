namespace Invoice
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
            this.firstNamePromptLabel = new System.Windows.Forms.Label();
            this.lastNameLabelPrompt = new System.Windows.Forms.Label();
            this.emailLabelPrompt = new System.Windows.Forms.Label();
            this.passwordPromptLabel = new System.Windows.Forms.Label();
            this.confirmPasswordPromptLabel = new System.Windows.Forms.Label();
            this.firstNameEntryTextBox = new System.Windows.Forms.TextBox();
            this.lastNameEntryTextBox = new System.Windows.Forms.TextBox();
            this.emailEntryTextBox = new System.Windows.Forms.TextBox();
            this.passwordEntryTextBox = new System.Windows.Forms.TextBox();
            this.confirmPasswordEntryTextBox = new System.Windows.Forms.TextBox();
            this.registerButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.registerHeaderLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.occupantRadioButton = new System.Windows.Forms.RadioButton();
            this.contractorRadioButton = new System.Windows.Forms.RadioButton();
            this.officeWorkerRadioButton = new System.Windows.Forms.RadioButton();
            this.addressLabelPrompt = new System.Windows.Forms.Label();
            this.addressEntryTextBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // firstNamePromptLabel
            // 
            this.firstNamePromptLabel.AutoSize = true;
            this.firstNamePromptLabel.Location = new System.Drawing.Point(60, 49);
            this.firstNamePromptLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.firstNamePromptLabel.Name = "firstNamePromptLabel";
            this.firstNamePromptLabel.Size = new System.Drawing.Size(80, 17);
            this.firstNamePromptLabel.TabIndex = 0;
            this.firstNamePromptLabel.Text = "First Name:";
            // 
            // lastNameLabelPrompt
            // 
            this.lastNameLabelPrompt.AutoSize = true;
            this.lastNameLabelPrompt.Location = new System.Drawing.Point(60, 81);
            this.lastNameLabelPrompt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lastNameLabelPrompt.Name = "lastNameLabelPrompt";
            this.lastNameLabelPrompt.Size = new System.Drawing.Size(80, 17);
            this.lastNameLabelPrompt.TabIndex = 0;
            this.lastNameLabelPrompt.Text = "Last Name:";
            // 
            // emailLabelPrompt
            // 
            this.emailLabelPrompt.AutoSize = true;
            this.emailLabelPrompt.Location = new System.Drawing.Point(93, 113);
            this.emailLabelPrompt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emailLabelPrompt.Name = "emailLabelPrompt";
            this.emailLabelPrompt.Size = new System.Drawing.Size(46, 17);
            this.emailLabelPrompt.TabIndex = 0;
            this.emailLabelPrompt.Text = "Email:";
            // 
            // passwordPromptLabel
            // 
            this.passwordPromptLabel.AutoSize = true;
            this.passwordPromptLabel.Location = new System.Drawing.Point(67, 177);
            this.passwordPromptLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordPromptLabel.Name = "passwordPromptLabel";
            this.passwordPromptLabel.Size = new System.Drawing.Size(73, 17);
            this.passwordPromptLabel.TabIndex = 0;
            this.passwordPromptLabel.Text = "Password:";
            // 
            // confirmPasswordPromptLabel
            // 
            this.confirmPasswordPromptLabel.AutoSize = true;
            this.confirmPasswordPromptLabel.Location = new System.Drawing.Point(16, 209);
            this.confirmPasswordPromptLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.confirmPasswordPromptLabel.Name = "confirmPasswordPromptLabel";
            this.confirmPasswordPromptLabel.Size = new System.Drawing.Size(125, 17);
            this.confirmPasswordPromptLabel.TabIndex = 0;
            this.confirmPasswordPromptLabel.Text = "Confirm Password:";
            // 
            // firstNameEntryTextBox
            // 
            this.firstNameEntryTextBox.Location = new System.Drawing.Point(148, 46);
            this.firstNameEntryTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.firstNameEntryTextBox.Name = "firstNameEntryTextBox";
            this.firstNameEntryTextBox.Size = new System.Drawing.Size(213, 22);
            this.firstNameEntryTextBox.TabIndex = 0;
            // 
            // lastNameEntryTextBox
            // 
            this.lastNameEntryTextBox.Location = new System.Drawing.Point(148, 78);
            this.lastNameEntryTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lastNameEntryTextBox.Name = "lastNameEntryTextBox";
            this.lastNameEntryTextBox.Size = new System.Drawing.Size(213, 22);
            this.lastNameEntryTextBox.TabIndex = 1;
            // 
            // emailEntryTextBox
            // 
            this.emailEntryTextBox.Location = new System.Drawing.Point(148, 110);
            this.emailEntryTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.emailEntryTextBox.Name = "emailEntryTextBox";
            this.emailEntryTextBox.Size = new System.Drawing.Size(213, 22);
            this.emailEntryTextBox.TabIndex = 2;
            // 
            // passwordEntryTextBox
            // 
            this.passwordEntryTextBox.Location = new System.Drawing.Point(148, 174);
            this.passwordEntryTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.passwordEntryTextBox.Name = "passwordEntryTextBox";
            this.passwordEntryTextBox.PasswordChar = '*';
            this.passwordEntryTextBox.Size = new System.Drawing.Size(213, 22);
            this.passwordEntryTextBox.TabIndex = 3;
            this.passwordEntryTextBox.UseSystemPasswordChar = true;
            // 
            // confirmPasswordEntryTextBox
            // 
            this.confirmPasswordEntryTextBox.Location = new System.Drawing.Point(148, 206);
            this.confirmPasswordEntryTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.confirmPasswordEntryTextBox.Name = "confirmPasswordEntryTextBox";
            this.confirmPasswordEntryTextBox.PasswordChar = '*';
            this.confirmPasswordEntryTextBox.Size = new System.Drawing.Size(213, 22);
            this.confirmPasswordEntryTextBox.TabIndex = 4;
            this.confirmPasswordEntryTextBox.UseSystemPasswordChar = true;
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(20, 297);
            this.registerButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(100, 28);
            this.registerButton.TabIndex = 5;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(141, 297);
            this.backButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(100, 28);
            this.backButton.TabIndex = 6;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(263, 297);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(100, 28);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // registerHeaderLabel
            // 
            this.registerHeaderLabel.AutoSize = true;
            this.registerHeaderLabel.Location = new System.Drawing.Point(45, 11);
            this.registerHeaderLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.registerHeaderLabel.Name = "registerHeaderLabel";
            this.registerHeaderLabel.Size = new System.Drawing.Size(298, 17);
            this.registerHeaderLabel.TabIndex = 3;
            this.registerHeaderLabel.Text = "Please enter the information requested below:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.occupantRadioButton);
            this.panel1.Controls.Add(this.contractorRadioButton);
            this.panel1.Controls.Add(this.officeWorkerRadioButton);
            this.panel1.Location = new System.Drawing.Point(20, 249);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(343, 30);
            this.panel1.TabIndex = 12;
            // 
            // occupantRadioButton
            // 
            this.occupantRadioButton.AutoSize = true;
            this.occupantRadioButton.Location = new System.Drawing.Point(4, 5);
            this.occupantRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.occupantRadioButton.Name = "occupantRadioButton";
            this.occupantRadioButton.Size = new System.Drawing.Size(90, 21);
            this.occupantRadioButton.TabIndex = 8;
            this.occupantRadioButton.TabStop = true;
            this.occupantRadioButton.Text = "Occupant";
            this.occupantRadioButton.UseVisualStyleBackColor = true;
            // 
            // contractorRadioButton
            // 
            this.contractorRadioButton.AutoSize = true;
            this.contractorRadioButton.Location = new System.Drawing.Point(237, 5);
            this.contractorRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.contractorRadioButton.Name = "contractorRadioButton";
            this.contractorRadioButton.Size = new System.Drawing.Size(95, 21);
            this.contractorRadioButton.TabIndex = 10;
            this.contractorRadioButton.TabStop = true;
            this.contractorRadioButton.Text = "Contractor";
            this.contractorRadioButton.UseVisualStyleBackColor = true;
            // 
            // officeWorkerRadioButton
            // 
            this.officeWorkerRadioButton.AutoSize = true;
            this.officeWorkerRadioButton.Location = new System.Drawing.Point(108, 5);
            this.officeWorkerRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.officeWorkerRadioButton.Name = "officeWorkerRadioButton";
            this.officeWorkerRadioButton.Size = new System.Drawing.Size(116, 21);
            this.officeWorkerRadioButton.TabIndex = 9;
            this.officeWorkerRadioButton.TabStop = true;
            this.officeWorkerRadioButton.Text = "Office Worker";
            this.officeWorkerRadioButton.UseVisualStyleBackColor = true;
            // 
            // addressLabelPrompt
            // 
            this.addressLabelPrompt.AutoSize = true;
            this.addressLabelPrompt.Location = new System.Drawing.Point(77, 145);
            this.addressLabelPrompt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addressLabelPrompt.Name = "addressLabelPrompt";
            this.addressLabelPrompt.Size = new System.Drawing.Size(64, 17);
            this.addressLabelPrompt.TabIndex = 0;
            this.addressLabelPrompt.Text = "Address:";
            // 
            // addressEntryTextBox
            // 
            this.addressEntryTextBox.Location = new System.Drawing.Point(148, 142);
            this.addressEntryTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addressEntryTextBox.Name = "addressEntryTextBox";
            this.addressEntryTextBox.Size = new System.Drawing.Size(213, 22);
            this.addressEntryTextBox.TabIndex = 2;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 347);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.registerHeaderLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.confirmPasswordEntryTextBox);
            this.Controls.Add(this.passwordEntryTextBox);
            this.Controls.Add(this.addressEntryTextBox);
            this.Controls.Add(this.emailEntryTextBox);
            this.Controls.Add(this.lastNameEntryTextBox);
            this.Controls.Add(this.firstNameEntryTextBox);
            this.Controls.Add(this.confirmPasswordPromptLabel);
            this.Controls.Add(this.addressLabelPrompt);
            this.Controls.Add(this.passwordPromptLabel);
            this.Controls.Add(this.emailLabelPrompt);
            this.Controls.Add(this.lastNameLabelPrompt);
            this.Controls.Add(this.firstNamePromptLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RegisterForm";
            this.Text = "Register New Account";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstNamePromptLabel;
        private System.Windows.Forms.Label lastNameLabelPrompt;
        private System.Windows.Forms.Label emailLabelPrompt;
        private System.Windows.Forms.Label passwordPromptLabel;
        private System.Windows.Forms.Label confirmPasswordPromptLabel;
        private System.Windows.Forms.TextBox firstNameEntryTextBox;
        private System.Windows.Forms.TextBox lastNameEntryTextBox;
        private System.Windows.Forms.TextBox emailEntryTextBox;
        private System.Windows.Forms.TextBox passwordEntryTextBox;
        private System.Windows.Forms.TextBox confirmPasswordEntryTextBox;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label registerHeaderLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton occupantRadioButton;
        private System.Windows.Forms.RadioButton contractorRadioButton;
        private System.Windows.Forms.RadioButton officeWorkerRadioButton;
        private System.Windows.Forms.Label addressLabelPrompt;
        private System.Windows.Forms.TextBox addressEntryTextBox;
    }
}