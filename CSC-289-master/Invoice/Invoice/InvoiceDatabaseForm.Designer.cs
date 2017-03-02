﻿namespace Invoice
{
    partial class InvoiceDatabaseForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.addressPrompt = new System.Windows.Forms.Label();
            this.selectionPrompt = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.userInformationEntryTab = new System.Windows.Forms.TabPage();
            this.invoiceInformationTab = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.invoiceSelectionTab = new System.Windows.Forms.TabPage();
            this.invoicesListBox = new System.Windows.Forms.ListBox();
            this.label15 = new System.Windows.Forms.Label();
            this.newInvoiceButton = new System.Windows.Forms.Button();
            this.newInvoiceButtonPrompt = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.userInformationEntryTab.SuspendLayout();
            this.invoiceInformationTab.SuspendLayout();
            this.invoiceSelectionTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(145, 216);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(282, 216);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "label1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "label1";
            // 
            // addressPrompt
            // 
            this.addressPrompt.AutoSize = true;
            this.addressPrompt.Location = new System.Drawing.Point(6, 29);
            this.addressPrompt.Name = "addressPrompt";
            this.addressPrompt.Size = new System.Drawing.Size(48, 13);
            this.addressPrompt.TabIndex = 4;
            this.addressPrompt.Text = "Address:";
            // 
            // selectionPrompt
            // 
            this.selectionPrompt.AutoSize = true;
            this.selectionPrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectionPrompt.Location = new System.Drawing.Point(30, 3);
            this.selectionPrompt.Name = "selectionPrompt";
            this.selectionPrompt.Size = new System.Drawing.Size(302, 13);
            this.selectionPrompt.TabIndex = 4;
            this.selectionPrompt.Text = "Please enter your information to view and create your invoices:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "label1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "label1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.userInformationEntryTab);
            this.tabControl1.Controls.Add(this.invoiceSelectionTab);
            this.tabControl1.Controls.Add(this.invoiceInformationTab);
            this.tabControl1.Location = new System.Drawing.Point(2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(374, 274);
            this.tabControl1.TabIndex = 5;
            // 
            // userInformationEntryTab
            // 
            this.userInformationEntryTab.Controls.Add(this.textBox5);
            this.userInformationEntryTab.Controls.Add(this.textBox4);
            this.userInformationEntryTab.Controls.Add(this.textBox3);
            this.userInformationEntryTab.Controls.Add(this.textBox2);
            this.userInformationEntryTab.Controls.Add(this.textBox1);
            this.userInformationEntryTab.Controls.Add(this.cancelButton);
            this.userInformationEntryTab.Controls.Add(this.label8);
            this.userInformationEntryTab.Controls.Add(this.button2);
            this.userInformationEntryTab.Controls.Add(this.button1);
            this.userInformationEntryTab.Controls.Add(this.label4);
            this.userInformationEntryTab.Controls.Add(this.label7);
            this.userInformationEntryTab.Controls.Add(this.addressPrompt);
            this.userInformationEntryTab.Controls.Add(this.selectionPrompt);
            this.userInformationEntryTab.Controls.Add(this.label3);
            this.userInformationEntryTab.Location = new System.Drawing.Point(4, 22);
            this.userInformationEntryTab.Name = "userInformationEntryTab";
            this.userInformationEntryTab.Padding = new System.Windows.Forms.Padding(3);
            this.userInformationEntryTab.Size = new System.Drawing.Size(366, 248);
            this.userInformationEntryTab.TabIndex = 0;
            this.userInformationEntryTab.Text = "Enter Information";
            this.userInformationEntryTab.UseVisualStyleBackColor = true;
            // 
            // invoiceInformationTab
            // 
            this.invoiceInformationTab.Controls.Add(this.label14);
            this.invoiceInformationTab.Controls.Add(this.label9);
            this.invoiceInformationTab.Controls.Add(this.label13);
            this.invoiceInformationTab.Controls.Add(this.label6);
            this.invoiceInformationTab.Controls.Add(this.label12);
            this.invoiceInformationTab.Controls.Add(this.label5);
            this.invoiceInformationTab.Controls.Add(this.label11);
            this.invoiceInformationTab.Controls.Add(this.label2);
            this.invoiceInformationTab.Controls.Add(this.label10);
            this.invoiceInformationTab.Controls.Add(this.label1);
            this.invoiceInformationTab.Location = new System.Drawing.Point(4, 22);
            this.invoiceInformationTab.Name = "invoiceInformationTab";
            this.invoiceInformationTab.Padding = new System.Windows.Forms.Padding(3);
            this.invoiceInformationTab.Size = new System.Drawing.Size(366, 248);
            this.invoiceInformationTab.TabIndex = 1;
            this.invoiceInformationTab.Text = "Invoice Information";
            this.invoiceInformationTab.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(60, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(272, 20);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(60, 50);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(272, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(60, 74);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(272, 20);
            this.textBox3.TabIndex = 5;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(60, 98);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(272, 20);
            this.textBox4.TabIndex = 5;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(60, 122);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(272, 20);
            this.textBox5.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "label1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "label1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "label1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "label1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(44, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "label1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(44, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "label1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(44, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "label1";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(44, 42);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "label1";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(44, 55);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "label1";
            // 
            // invoiceSelectionTab
            // 
            this.invoiceSelectionTab.Controls.Add(this.newInvoiceButtonPrompt);
            this.invoiceSelectionTab.Controls.Add(this.newInvoiceButton);
            this.invoiceSelectionTab.Controls.Add(this.label15);
            this.invoiceSelectionTab.Controls.Add(this.invoicesListBox);
            this.invoiceSelectionTab.Location = new System.Drawing.Point(4, 22);
            this.invoiceSelectionTab.Name = "invoiceSelectionTab";
            this.invoiceSelectionTab.Size = new System.Drawing.Size(366, 248);
            this.invoiceSelectionTab.TabIndex = 2;
            this.invoiceSelectionTab.Text = "Invoice Selection";
            this.invoiceSelectionTab.UseVisualStyleBackColor = true;
            // 
            // invoicesListBox
            // 
            this.invoicesListBox.FormattingEnabled = true;
            this.invoicesListBox.Location = new System.Drawing.Point(8, 43);
            this.invoicesListBox.Name = "invoicesListBox";
            this.invoicesListBox.Size = new System.Drawing.Size(340, 147);
            this.invoicesListBox.TabIndex = 0;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(8, 17);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(212, 13);
            this.label15.TabIndex = 1;
            this.label15.Text = "Please select the invoice you wish to view. \r\n";
            // 
            // newInvoiceButton
            // 
            this.newInvoiceButton.Location = new System.Drawing.Point(8, 217);
            this.newInvoiceButton.Name = "newInvoiceButton";
            this.newInvoiceButton.Size = new System.Drawing.Size(75, 23);
            this.newInvoiceButton.TabIndex = 2;
            this.newInvoiceButton.Text = "New";
            this.newInvoiceButton.UseVisualStyleBackColor = true;
            // 
            // newInvoiceButtonPrompt
            // 
            this.newInvoiceButtonPrompt.AutoSize = true;
            this.newInvoiceButtonPrompt.Location = new System.Drawing.Point(8, 201);
            this.newInvoiceButtonPrompt.Name = "newInvoiceButtonPrompt";
            this.newInvoiceButtonPrompt.Size = new System.Drawing.Size(245, 13);
            this.newInvoiceButtonPrompt.TabIndex = 3;
            this.newInvoiceButtonPrompt.Text = "Or create a new one by pressing the button below.";
            // 
            // InvoiceDatabaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 275);
            this.Controls.Add(this.tabControl1);
            this.Name = "InvoiceDatabaseForm";
            this.Text = "InvoiceDatabaseForm";
            this.tabControl1.ResumeLayout(false);
            this.userInformationEntryTab.ResumeLayout(false);
            this.userInformationEntryTab.PerformLayout();
            this.invoiceInformationTab.ResumeLayout(false);
            this.invoiceInformationTab.PerformLayout();
            this.invoiceSelectionTab.ResumeLayout(false);
            this.invoiceSelectionTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label addressPrompt;
        private System.Windows.Forms.Label selectionPrompt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage userInformationEntryTab;
        private System.Windows.Forms.TabPage invoiceInformationTab;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage invoiceSelectionTab;
        private System.Windows.Forms.Label newInvoiceButtonPrompt;
        private System.Windows.Forms.Button newInvoiceButton;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ListBox invoicesListBox;
    }
}