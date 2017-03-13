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
            this.s = new System.Windows.Forms.Label();
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
            this.streetAddressLabelPrompt = new System.Windows.Forms.Label();
            this.streetAddressTextBox = new System.Windows.Forms.TextBox();
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
            this.lastNameLabelPrompt.Location = new System.Drawing.Point(45, 67);
            this.lastNameLabelPrompt.Name = "lastNameLabelPrompt";
            this.lastNameLabelPrompt.Size = new System.Drawing.Size(61, 13);
            this.lastNameLabelPrompt.TabIndex = 0;
            this.lastNameLabelPrompt.Text = "Last Name:";
            // 
            // s
            // 
            this.s.AutoSize = true;
            this.s.Location = new System.Drawing.Point(70, 94);
            this.s.Name = "s";
            this.s.Size = new System.Drawing.Size(35, 13);
            this.s.TabIndex = 0;
            this.s.Text = "Email:";
            // 
            // passwordPromptLabel
            // 
            this.passwordPromptLabel.AutoSize = true;
            this.passwordPromptLabel.Location = new System.Drawing.Point(50, 148);
            this.passwordPromptLabel.Name = "passwordPromptLabel";
            this.passwordPromptLabel.Size = new System.Drawing.Size(56, 13);
            this.passwordPromptLabel.TabIndex = 0;
            this.passwordPromptLabel.Text = "Password:";
            // 
            // confirmPasswordPromptLabel
            // 
            this.confirmPasswordPromptLabel.AutoSize = true;
            this.confirmPasswordPromptLabel.Location = new System.Drawing.Point(12, 175);
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
            this.lastNameEntryTextBox.Location = new System.Drawing.Point(111, 64);
            this.lastNameEntryTextBox.Name = "lastNameEntryTextBox";
            this.lastNameEntryTextBox.Size = new System.Drawing.Size(161, 20);
            this.lastNameEntryTextBox.TabIndex = 1;
            // 
            // emailEntryTextBox
            // 
            this.emailEntryTextBox.Location = new System.Drawing.Point(111, 91);
            this.emailEntryTextBox.Name = "emailEntryTextBox";
            this.emailEntryTextBox.Size = new System.Drawing.Size(161, 20);
            this.emailEntryTextBox.TabIndex = 2;
            // 
            // passwordEntryTextBox
            // 
            this.passwordEntryTextBox.Location = new System.Drawing.Point(111, 145);
            this.passwordEntryTextBox.Name = "passwordEntryTextBox";
            this.passwordEntryTextBox.PasswordChar = '*';
            this.passwordEntryTextBox.Size = new System.Drawing.Size(161, 20);
            this.passwordEntryTextBox.TabIndex = 3;
            this.passwordEntryTextBox.UseSystemPasswordChar = true;
            // 
            // confirmPasswordEntryTextBox
            // 
            this.confirmPasswordEntryTextBox.Location = new System.Drawing.Point(111, 172);
            this.confirmPasswordEntryTextBox.Name = "confirmPasswordEntryTextBox";
            this.confirmPasswordEntryTextBox.PasswordChar = '*';
            this.confirmPasswordEntryTextBox.Size = new System.Drawing.Size(161, 20);
            this.confirmPasswordEntryTextBox.TabIndex = 4;
            this.confirmPasswordEntryTextBox.UseSystemPasswordChar = true;
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(15, 207);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(75, 23);
            this.registerButton.TabIndex = 5;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(106, 207);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 6;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(197, 207);
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
            // streetAddressLabelPrompt
            // 
            this.streetAddressLabelPrompt.AutoSize = true;
            this.streetAddressLabelPrompt.Location = new System.Drawing.Point(26, 121);
            this.streetAddressLabelPrompt.Name = "streetAddressLabelPrompt";
            this.streetAddressLabelPrompt.Size = new System.Drawing.Size(79, 13);
            this.streetAddressLabelPrompt.TabIndex = 0;
            this.streetAddressLabelPrompt.Text = "Street Address:";
            // 
            // streetAddressTextBox
            // 
            this.streetAddressTextBox.Location = new System.Drawing.Point(111, 118);
            this.streetAddressTextBox.Name = "streetAddressTextBox";
            this.streetAddressTextBox.Size = new System.Drawing.Size(161, 20);
            this.streetAddressTextBox.TabIndex = 2;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 240);
            this.Controls.Add(this.registerHeaderLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.confirmPasswordEntryTextBox);
            this.Controls.Add(this.passwordEntryTextBox);
            this.Controls.Add(this.streetAddressTextBox);
            this.Controls.Add(this.emailEntryTextBox);
            this.Controls.Add(this.lastNameEntryTextBox);
            this.Controls.Add(this.firstNameEntryTextBox);
            this.Controls.Add(this.confirmPasswordPromptLabel);
            this.Controls.Add(this.passwordPromptLabel);
            this.Controls.Add(this.streetAddressLabelPrompt);
            this.Controls.Add(this.s);
            this.Controls.Add(this.lastNameLabelPrompt);
            this.Controls.Add(this.firstNamePromptLabel);
            this.Name = "RegisterForm";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstNamePromptLabel;
        private System.Windows.Forms.Label lastNameLabelPrompt;
        private System.Windows.Forms.Label s;
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
        private System.Windows.Forms.Label streetAddressLabelPrompt;
        private System.Windows.Forms.TextBox streetAddressTextBox;
    }
}