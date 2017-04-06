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
            this.rolePanel = new System.Windows.Forms.Panel();
            this.occupantRadioButton = new System.Windows.Forms.RadioButton();
            this.contractorRadioButton = new System.Windows.Forms.RadioButton();
            this.officeWorkerRadioButton = new System.Windows.Forms.RadioButton();
            this.registerHeaderLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.registerButton = new System.Windows.Forms.Button();
            this.confirmPasswordEntryTextBox = new System.Windows.Forms.TextBox();
            this.passwordEntryTextBox = new System.Windows.Forms.TextBox();
            this.emailEntryTextBox = new System.Windows.Forms.TextBox();
            this.confirmPasswordPromptLabel = new System.Windows.Forms.Label();
            this.passwordPromptLabel = new System.Windows.Forms.Label();
            this.emailLabelPrompt = new System.Windows.Forms.Label();
            this.companyPanel = new System.Windows.Forms.Panel();
            this.companyNameLabelPrompt = new System.Windows.Forms.Label();
            this.companyEmailLabelPrompt = new System.Windows.Forms.Label();
            this.companyAddressLabelPrompt = new System.Windows.Forms.Label();
            this.companyPhoneLabelPrompt = new System.Windows.Forms.Label();
            this.companyNameEntryTextBox = new System.Windows.Forms.TextBox();
            this.companyEmailEntryTextBox = new System.Windows.Forms.TextBox();
            this.companyAddressEntryTextBox = new System.Windows.Forms.TextBox();
            this.companyPhoneEntryTextBox = new System.Windows.Forms.TextBox();
            this.rolePanel.SuspendLayout();
            this.companyPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // rolePanel
            // 
            this.rolePanel.Controls.Add(this.occupantRadioButton);
            this.rolePanel.Controls.Add(this.contractorRadioButton);
            this.rolePanel.Controls.Add(this.officeWorkerRadioButton);
            this.rolePanel.Location = new System.Drawing.Point(12, 137);
            this.rolePanel.Name = "rolePanel";
            this.rolePanel.Size = new System.Drawing.Size(257, 24);
            this.rolePanel.TabIndex = 23;
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
            this.contractorRadioButton.CheckedChanged += new System.EventHandler(this.contractorRadioButton_CheckedChanged);
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
            // registerHeaderLabel
            // 
            this.registerHeaderLabel.AutoSize = true;
            this.registerHeaderLabel.Location = new System.Drawing.Point(34, 9);
            this.registerHeaderLabel.Name = "registerHeaderLabel";
            this.registerHeaderLabel.Size = new System.Drawing.Size(222, 13);
            this.registerHeaderLabel.TabIndex = 17;
            this.registerHeaderLabel.Text = "Please enter the information requested below:";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(197, 173);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 22;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click_1);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(106, 173);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 21;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click_1);
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(12, 173);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(75, 23);
            this.registerButton.TabIndex = 20;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click_1);
            // 
            // confirmPasswordEntryTextBox
            // 
            this.confirmPasswordEntryTextBox.Location = new System.Drawing.Point(111, 89);
            this.confirmPasswordEntryTextBox.Name = "confirmPasswordEntryTextBox";
            this.confirmPasswordEntryTextBox.PasswordChar = '*';
            this.confirmPasswordEntryTextBox.Size = new System.Drawing.Size(161, 20);
            this.confirmPasswordEntryTextBox.TabIndex = 19;
            this.confirmPasswordEntryTextBox.UseSystemPasswordChar = true;
            // 
            // passwordEntryTextBox
            // 
            this.passwordEntryTextBox.Location = new System.Drawing.Point(111, 63);
            this.passwordEntryTextBox.Name = "passwordEntryTextBox";
            this.passwordEntryTextBox.PasswordChar = '*';
            this.passwordEntryTextBox.Size = new System.Drawing.Size(161, 20);
            this.passwordEntryTextBox.TabIndex = 18;
            this.passwordEntryTextBox.UseSystemPasswordChar = true;
            // 
            // emailEntryTextBox
            // 
            this.emailEntryTextBox.Location = new System.Drawing.Point(113, 37);
            this.emailEntryTextBox.Name = "emailEntryTextBox";
            this.emailEntryTextBox.Size = new System.Drawing.Size(161, 20);
            this.emailEntryTextBox.TabIndex = 16;
            // 
            // confirmPasswordPromptLabel
            // 
            this.confirmPasswordPromptLabel.AutoSize = true;
            this.confirmPasswordPromptLabel.Location = new System.Drawing.Point(9, 96);
            this.confirmPasswordPromptLabel.Name = "confirmPasswordPromptLabel";
            this.confirmPasswordPromptLabel.Size = new System.Drawing.Size(94, 13);
            this.confirmPasswordPromptLabel.TabIndex = 13;
            this.confirmPasswordPromptLabel.Text = "Confirm Password:";
            // 
            // passwordPromptLabel
            // 
            this.passwordPromptLabel.AutoSize = true;
            this.passwordPromptLabel.Location = new System.Drawing.Point(50, 66);
            this.passwordPromptLabel.Name = "passwordPromptLabel";
            this.passwordPromptLabel.Size = new System.Drawing.Size(56, 13);
            this.passwordPromptLabel.TabIndex = 14;
            this.passwordPromptLabel.Text = "Password:";
            // 
            // emailLabelPrompt
            // 
            this.emailLabelPrompt.AutoSize = true;
            this.emailLabelPrompt.Location = new System.Drawing.Point(70, 40);
            this.emailLabelPrompt.Name = "emailLabelPrompt";
            this.emailLabelPrompt.Size = new System.Drawing.Size(35, 13);
            this.emailLabelPrompt.TabIndex = 15;
            this.emailLabelPrompt.Text = "Email:";
            // 
            // companyPanel
            // 
            this.companyPanel.Controls.Add(this.companyNameLabelPrompt);
            this.companyPanel.Controls.Add(this.companyEmailLabelPrompt);
            this.companyPanel.Controls.Add(this.companyAddressLabelPrompt);
            this.companyPanel.Controls.Add(this.companyPhoneLabelPrompt);
            this.companyPanel.Controls.Add(this.companyNameEntryTextBox);
            this.companyPanel.Controls.Add(this.companyEmailEntryTextBox);
            this.companyPanel.Controls.Add(this.companyAddressEntryTextBox);
            this.companyPanel.Controls.Add(this.companyPhoneEntryTextBox);
            this.companyPanel.Location = new System.Drawing.Point(2, 115);
            this.companyPanel.Name = "companyPanel";
            this.companyPanel.Size = new System.Drawing.Size(1, 1);
            this.companyPanel.TabIndex = 24;
            this.companyPanel.Visible = false;
            // 
            // companyNameLabelPrompt
            // 
            this.companyNameLabelPrompt.AutoSize = true;
            this.companyNameLabelPrompt.Location = new System.Drawing.Point(18, 3);
            this.companyNameLabelPrompt.Name = "companyNameLabelPrompt";
            this.companyNameLabelPrompt.Size = new System.Drawing.Size(85, 13);
            this.companyNameLabelPrompt.TabIndex = 0;
            this.companyNameLabelPrompt.Text = "Company Name:";
            // 
            // companyEmailLabelPrompt
            // 
            this.companyEmailLabelPrompt.AutoSize = true;
            this.companyEmailLabelPrompt.Location = new System.Drawing.Point(21, 29);
            this.companyEmailLabelPrompt.Name = "companyEmailLabelPrompt";
            this.companyEmailLabelPrompt.Size = new System.Drawing.Size(82, 13);
            this.companyEmailLabelPrompt.TabIndex = 0;
            this.companyEmailLabelPrompt.Text = "Company Email:";
            // 
            // companyAddressLabelPrompt
            // 
            this.companyAddressLabelPrompt.AutoSize = true;
            this.companyAddressLabelPrompt.Location = new System.Drawing.Point(8, 55);
            this.companyAddressLabelPrompt.Name = "companyAddressLabelPrompt";
            this.companyAddressLabelPrompt.Size = new System.Drawing.Size(95, 13);
            this.companyAddressLabelPrompt.TabIndex = 0;
            this.companyAddressLabelPrompt.Text = "Company Address:";
            // 
            // companyPhoneLabelPrompt
            // 
            this.companyPhoneLabelPrompt.AutoSize = true;
            this.companyPhoneLabelPrompt.Location = new System.Drawing.Point(15, 81);
            this.companyPhoneLabelPrompt.Name = "companyPhoneLabelPrompt";
            this.companyPhoneLabelPrompt.Size = new System.Drawing.Size(88, 13);
            this.companyPhoneLabelPrompt.TabIndex = 0;
            this.companyPhoneLabelPrompt.Text = "Company Phone:";
            // 
            // companyNameEntryTextBox
            // 
            this.companyNameEntryTextBox.Location = new System.Drawing.Point(109, 0);
            this.companyNameEntryTextBox.Name = "companyNameEntryTextBox";
            this.companyNameEntryTextBox.Size = new System.Drawing.Size(161, 20);
            this.companyNameEntryTextBox.TabIndex = 2;
            // 
            // companyEmailEntryTextBox
            // 
            this.companyEmailEntryTextBox.Location = new System.Drawing.Point(109, 26);
            this.companyEmailEntryTextBox.Name = "companyEmailEntryTextBox";
            this.companyEmailEntryTextBox.Size = new System.Drawing.Size(161, 20);
            this.companyEmailEntryTextBox.TabIndex = 2;
            // 
            // companyAddressEntryTextBox
            // 
            this.companyAddressEntryTextBox.Location = new System.Drawing.Point(109, 52);
            this.companyAddressEntryTextBox.Name = "companyAddressEntryTextBox";
            this.companyAddressEntryTextBox.Size = new System.Drawing.Size(161, 20);
            this.companyAddressEntryTextBox.TabIndex = 2;
            // 
            // companyPhoneEntryTextBox
            // 
            this.companyPhoneEntryTextBox.Location = new System.Drawing.Point(109, 78);
            this.companyPhoneEntryTextBox.Name = "companyPhoneEntryTextBox";
            this.companyPhoneEntryTextBox.Size = new System.Drawing.Size(161, 20);
            this.companyPhoneEntryTextBox.TabIndex = 2;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 212);
            this.Controls.Add(this.companyPanel);
            this.Controls.Add(this.rolePanel);
            this.Controls.Add(this.registerHeaderLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.confirmPasswordEntryTextBox);
            this.Controls.Add(this.passwordEntryTextBox);
            this.Controls.Add(this.emailEntryTextBox);
            this.Controls.Add(this.confirmPasswordPromptLabel);
            this.Controls.Add(this.passwordPromptLabel);
            this.Controls.Add(this.emailLabelPrompt);
            this.Name = "RegisterForm";
            this.Text = "Register New Account";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.rolePanel.ResumeLayout(false);
            this.rolePanel.PerformLayout();
            this.companyPanel.ResumeLayout(false);
            this.companyPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel rolePanel;
        private System.Windows.Forms.RadioButton occupantRadioButton;
        private System.Windows.Forms.RadioButton contractorRadioButton;
        private System.Windows.Forms.RadioButton officeWorkerRadioButton;
        private System.Windows.Forms.Label registerHeaderLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.TextBox confirmPasswordEntryTextBox;
        private System.Windows.Forms.TextBox passwordEntryTextBox;
        private System.Windows.Forms.TextBox emailEntryTextBox;
        private System.Windows.Forms.Label confirmPasswordPromptLabel;
        private System.Windows.Forms.Label passwordPromptLabel;
        private System.Windows.Forms.Label emailLabelPrompt;
        private System.Windows.Forms.Panel companyPanel;
        private System.Windows.Forms.Label companyNameLabelPrompt;
        private System.Windows.Forms.Label companyEmailLabelPrompt;
        private System.Windows.Forms.Label companyAddressLabelPrompt;
        private System.Windows.Forms.Label companyPhoneLabelPrompt;
        private System.Windows.Forms.TextBox companyNameEntryTextBox;
        private System.Windows.Forms.TextBox companyEmailEntryTextBox;
        private System.Windows.Forms.TextBox companyAddressEntryTextBox;
        private System.Windows.Forms.TextBox companyPhoneEntryTextBox;
    }
}