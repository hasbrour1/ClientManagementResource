namespace ClientManagementResource
{
    partial class AddClientScreen
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
            this.label1 = new System.Windows.Forms.Label();
            this.custNameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.custAddrBox = new System.Windows.Forms.TextBox();
            this.custPhone = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Name:";
            // 
            // custNameBox
            // 
            this.custNameBox.Location = new System.Drawing.Point(157, 26);
            this.custNameBox.Name = "custNameBox";
            this.custNameBox.Size = new System.Drawing.Size(156, 20);
            this.custNameBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Client Address:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Phone Number";
            // 
            // custAddrBox
            // 
            this.custAddrBox.Location = new System.Drawing.Point(157, 60);
            this.custAddrBox.Name = "custAddrBox";
            this.custAddrBox.Size = new System.Drawing.Size(222, 20);
            this.custAddrBox.TabIndex = 6;
            // 
            // custPhone
            // 
            this.custPhone.Location = new System.Drawing.Point(157, 94);
            this.custPhone.Name = "custPhone";
            this.custPhone.Size = new System.Drawing.Size(118, 20);
            this.custPhone.TabIndex = 7;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(345, 138);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 8;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(86, 136);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 13);
            this.errorLabel.TabIndex = 9;
            // 
            // AddClientScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 173);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.custPhone);
            this.Controls.Add(this.custAddrBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.custNameBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddClientScreen";
            this.Text = "Add New Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox custNameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox custAddrBox;
        private System.Windows.Forms.TextBox custPhone;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label errorLabel;
    }
}