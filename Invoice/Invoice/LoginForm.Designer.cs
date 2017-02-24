namespace Invoice
{
    partial class LoginForm
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
            this.emailEntryTextBox = new System.Windows.Forms.TextBox();
            this.emailPromptLabel = new System.Windows.Forms.Label();
            this.passwordEntryTextBox = new System.Windows.Forms.TextBox();
            this.passwordPromptLabel = new System.Windows.Forms.Label();
            this.userPromptLabel = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.registerButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // emailEntryTextBox
            // 
            this.emailEntryTextBox.Location = new System.Drawing.Point(76, 46);
            this.emailEntryTextBox.Name = "emailEntryTextBox";
            this.emailEntryTextBox.Size = new System.Drawing.Size(188, 20);
            this.emailEntryTextBox.TabIndex = 0;
            // 
            // emailPromptLabel
            // 
            this.emailPromptLabel.AutoSize = true;
            this.emailPromptLabel.Location = new System.Drawing.Point(35, 49);
            this.emailPromptLabel.Name = "emailPromptLabel";
            this.emailPromptLabel.Size = new System.Drawing.Size(35, 13);
            this.emailPromptLabel.TabIndex = 1;
            this.emailPromptLabel.Text = "Email:";
            // 
            // passwordEntryTextBox
            // 
            this.passwordEntryTextBox.Location = new System.Drawing.Point(76, 76);
            this.passwordEntryTextBox.Name = "passwordEntryTextBox";
            this.passwordEntryTextBox.PasswordChar = '*';
            this.passwordEntryTextBox.Size = new System.Drawing.Size(188, 20);
            this.passwordEntryTextBox.TabIndex = 1;
            this.passwordEntryTextBox.UseSystemPasswordChar = true;
            // 
            // passwordPromptLabel
            // 
            this.passwordPromptLabel.AutoSize = true;
            this.passwordPromptLabel.Location = new System.Drawing.Point(14, 79);
            this.passwordPromptLabel.Name = "passwordPromptLabel";
            this.passwordPromptLabel.Size = new System.Drawing.Size(56, 13);
            this.passwordPromptLabel.TabIndex = 1;
            this.passwordPromptLabel.Text = "Password:";
            // 
            // userPromptLabel
            // 
            this.userPromptLabel.AutoSize = true;
            this.userPromptLabel.Location = new System.Drawing.Point(48, 9);
            this.userPromptLabel.Name = "userPromptLabel";
            this.userPromptLabel.Size = new System.Drawing.Size(188, 13);
            this.userPromptLabel.TabIndex = 2;
            this.userPromptLabel.Text = "Please enter your email and password.";
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(17, 125);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 2;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(103, 125);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(75, 23);
            this.registerButton.TabIndex = 3;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(189, 125);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 160);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.userPromptLabel);
            this.Controls.Add(this.passwordPromptLabel);
            this.Controls.Add(this.passwordEntryTextBox);
            this.Controls.Add(this.emailPromptLabel);
            this.Controls.Add(this.emailEntryTextBox);
            this.Name = "LoginForm";
            this.Text = "Invoice Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox emailEntryTextBox;
        private System.Windows.Forms.Label emailPromptLabel;
        private System.Windows.Forms.TextBox passwordEntryTextBox;
        private System.Windows.Forms.Label passwordPromptLabel;
        private System.Windows.Forms.Label userPromptLabel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Button cancelButton;
    }
}

