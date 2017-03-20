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
            this.firstNamePromptLabel.Location = new System.Drawing.Point(45, 40);
            this.firstNamePromptLabel.Name = "firstNamePromptLabel";
            this.firstNamePromptLabel.Size = new System.Drawing.Size(60, 13);
            this.firstNamePromptLabel.TabIndex = 0;
            this.firstNamePromptLabel.Text = "First Name:";
            // 
            // lastNameLabelPrompt
            // 
            this.lastNameLabelPrompt.AutoSize = true;
            this.lastNameLabelPrompt.Location = new System.Drawing.Point(45, 66);
            this.lastNameLabelPrompt.Name = "lastNameLabelPrompt";
            this.lastNameLabelPrompt.Size = new System.Drawing.Size(61, 13);
            this.lastNameLabelPrompt.TabIndex = 0;
            this.lastNameLabelPrompt.Text = "Last Name:";
            // 
            // emailLabelPrompt
            // 
            this.emailLabelPrompt.AutoSize = true;
            this.emailLabelPrompt.Location = new System.Drawing.Point(70, 92);
            this.emailLabelPrompt.Name = "emailLabelPrompt";
            this.emailLabelPrompt.Size = new System.Drawing.Size(35, 13);
            this.emailLabelPrompt.TabIndex = 0;
            this.emailLabelPrompt.Text = "Email:";
            // 
            // passwordPromptLabel
            // 
            this.passwordPromptLabel.AutoSize = true;
            this.passwordPromptLabel.Location = new System.Drawing.Point(50, 144);
            this.passwordPromptLabel.Name = "passwordPromptLabel";
            this.passwordPromptLabel.Size = new System.Drawing.Size(56, 13);
            this.passwordPromptLabel.TabIndex = 0;
            this.passwordPromptLabel.Text = "Password:";
            // 
            // confirmPasswordPromptLabel
            // 
            this.confirmPasswordPromptLabel.AutoSize = true;
            this.confirmPasswordPromptLabel.Location = new System.Drawing.Point(12, 170);
            this.confirmPasswordPromptLabel.Name = "confirmPasswordPromptLabel";
            this.confirmPasswordPromptLabel.Size = new System.Drawing.Size(94, 13);
            this.confirmPasswordPromptLabel.TabIndex = 0;
            this.confirmPasswordPromptLabel.Text = "Confirm Password:";
            // 
            // firstNameEntryTextBox
            // 
            this.firstNameEntryTextBox.Location = new System.Drawing.Point(111, 37);
            this.firstNameEntryTextBox.Name = "firstNameEntryTextBox";
            this.firstNameEntryTextBox.Size = new System.Drawing.Size(161, 20);
            this.firstNameEntryTextBox.TabIndex = 0;
            // 
            // lastNameEntryTextBox
            // 
            this.lastNameEntryTextBox.Location = new System.Drawing.Point(111, 63);
            this.lastNameEntryTextBox.Name = "lastNameEntryTextBox";
            this.lastNameEntryTextBox.Size = new System.Drawing.Size(161, 20);
            this.lastNameEntryTextBox.TabIndex = 1;
            // 
            // emailEntryTextBox
            // 
            this.emailEntryTextBox.Location = new System.Drawing.Point(111, 89);
            this.emailEntryTextBox.Name = "emailEntryTextBox";
            this.emailEntryTextBox.Size = new System.Drawing.Size(161, 20);
            this.emailEntryTextBox.TabIndex = 2;
            // 
            // passwordEntryTextBox
            // 
            this.passwordEntryTextBox.Location = new System.Drawing.Point(111, 141);
            this.passwordEntryTextBox.Name = "passwordEntryTextBox";
            this.passwordEntryTextBox.PasswordChar = '*';
            this.passwordEntryTextBox.Size = new System.Drawing.Size(161, 20);
            this.passwordEntryTextBox.TabIndex = 3;
            this.passwordEntryTextBox.UseSystemPasswordChar = true;
            // 
            // confirmPasswordEntryTextBox
            // 
            this.confirmPasswordEntryTextBox.Location = new System.Drawing.Point(111, 167);
            this.confirmPasswordEntryTextBox.Name = "confirmPasswordEntryTextBox";
            this.confirmPasswordEntryTextBox.PasswordChar = '*';
            this.confirmPasswordEntryTextBox.Size = new System.Drawing.Size(161, 20);
            this.confirmPasswordEntryTextBox.TabIndex = 4;
            this.confirmPasswordEntryTextBox.UseSystemPasswordChar = true;
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(15, 241);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(75, 23);
            this.registerButton.TabIndex = 5;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(106, 241);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 6;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(197, 241);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // registerHeaderLabel
            // 
            this.registerHeaderLabel.AutoSize = true;
            this.registerHeaderLabel.Location = new System.Drawing.Point(34, 9);
            this.registerHeaderLabel.Name = "registerHeaderLabel";
            this.registerHeaderLabel.Size = new System.Drawing.Size(222, 13);
            this.registerHeaderLabel.TabIndex = 3;
            this.registerHeaderLabel.Text = "Please enter the information requested below:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.occupantRadioButton);
            this.panel1.Controls.Add(this.contractorRadioButton);
            this.panel1.Controls.Add(this.officeWorkerRadioButton);
            this.panel1.Location = new System.Drawing.Point(15, 202);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 24);
            this.panel1.TabIndex = 12;
            // 
            // occupantRadioButton
            // 
            this.occupantRadioButton.AutoSize = true;
            this.occupantRadioButton.Location = new System.Drawing.Point(3, 4);
            this.occupantRadioButton.Name = "occupantRadioButton";
            this.occupantRadioButton.Size = new System.Drawing.Size(72, 17);
            this.occupantRadioButton.TabIndex = 8;
            this.occupantRadioButton.TabStop = true;
            this.occupantRadioButton.Text = "Occupant";
            this.occupantRadioButton.UseVisualStyleBackColor = true;
            // 
            // contractorRadioButton
            // 
            this.contractorRadioButton.AutoSize = true;
            this.contractorRadioButton.Location = new System.Drawing.Point(178, 4);
            this.contractorRadioButton.Name = "contractorRadioButton";
            this.contractorRadioButton.Size = new System.Drawing.Size(74, 17);
            this.contractorRadioButton.TabIndex = 10;
            this.contractorRadioButton.TabStop = true;
            this.contractorRadioButton.Text = "Contractor";
            this.contractorRadioButton.UseVisualStyleBackColor = true;
            // 
            // officeWorkerRadioButton
            // 
            this.officeWorkerRadioButton.AutoSize = true;
            this.officeWorkerRadioButton.Location = new System.Drawing.Point(81, 4);
            this.officeWorkerRadioButton.Name = "officeWorkerRadioButton";
            this.officeWorkerRadioButton.Size = new System.Drawing.Size(91, 17);
            this.officeWorkerRadioButton.TabIndex = 9;
            this.officeWorkerRadioButton.TabStop = true;
            this.officeWorkerRadioButton.Text = "Office Worker";
            this.officeWorkerRadioButton.UseVisualStyleBackColor = true;
            // 
            // addressLabelPrompt
            // 
            this.addressLabelPrompt.AutoSize = true;
            this.addressLabelPrompt.Location = new System.Drawing.Point(58, 118);
            this.addressLabelPrompt.Name = "addressLabelPrompt";
            this.addressLabelPrompt.Size = new System.Drawing.Size(48, 13);
            this.addressLabelPrompt.TabIndex = 0;
            this.addressLabelPrompt.Text = "Address:";
            // 
            // addressEntryTextBox
            // 
            this.addressEntryTextBox.Location = new System.Drawing.Point(111, 115);
            this.addressEntryTextBox.Name = "addressEntryTextBox";
            this.addressEntryTextBox.Size = new System.Drawing.Size(161, 20);
            this.addressEntryTextBox.TabIndex = 2;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 282);
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
            this.Name = "RegisterForm";
            this.Text = "Register";
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