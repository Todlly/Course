namespace TeleCompany
{
    partial class AddUserForm
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
            this.userLoginBox = new System.Windows.Forms.TextBox();
            this.userPswdBox = new System.Windows.Forms.TextBox();
            this.userTypeBox = new System.Windows.Forms.ComboBox();
            this.Login = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userLoginBox
            // 
            this.userLoginBox.Location = new System.Drawing.Point(17, 27);
            this.userLoginBox.Name = "userLoginBox";
            this.userLoginBox.Size = new System.Drawing.Size(100, 20);
            this.userLoginBox.TabIndex = 0;
            // 
            // userPswdBox
            // 
            this.userPswdBox.Location = new System.Drawing.Point(136, 27);
            this.userPswdBox.Name = "userPswdBox";
            this.userPswdBox.Size = new System.Drawing.Size(100, 20);
            this.userPswdBox.TabIndex = 1;
            // 
            // userTypeBox
            // 
            this.userTypeBox.FormattingEnabled = true;
            this.userTypeBox.Items.AddRange(new object[] {
            "admin",
            "owner"});
            this.userTypeBox.Location = new System.Drawing.Point(252, 27);
            this.userTypeBox.Name = "userTypeBox";
            this.userTypeBox.Size = new System.Drawing.Size(121, 21);
            this.userTypeBox.TabIndex = 2;
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.Location = new System.Drawing.Point(39, 11);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(33, 13);
            this.Login.TabIndex = 3;
            this.Login.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(275, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "User type";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(396, 24);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 6;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // AddUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 69);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.userTypeBox);
            this.Controls.Add(this.userPswdBox);
            this.Controls.Add(this.userLoginBox);
            this.Name = "AddUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddUserForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userLoginBox;
        private System.Windows.Forms.TextBox userPswdBox;
        private System.Windows.Forms.ComboBox userTypeBox;
        private System.Windows.Forms.Label Login;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addButton;
    }
}