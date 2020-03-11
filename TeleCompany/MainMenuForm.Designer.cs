namespace TeleCompany
{
    partial class MainMenuForm
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
            this.openSubsTableButton = new System.Windows.Forms.Button();
            this.openRatesTableButton = new System.Windows.Forms.Button();
            this.openCallsTableButton = new System.Windows.Forms.Button();
            this.openUsersTableButton = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openSubsTableButton
            // 
            this.openSubsTableButton.Location = new System.Drawing.Point(148, 73);
            this.openSubsTableButton.Name = "openSubsTableButton";
            this.openSubsTableButton.Size = new System.Drawing.Size(75, 34);
            this.openSubsTableButton.TabIndex = 0;
            this.openSubsTableButton.Text = "Subscribers table";
            this.openSubsTableButton.UseVisualStyleBackColor = true;
            this.openSubsTableButton.Click += new System.EventHandler(this.openSubscribersTableButton_Click);
            // 
            // openRatesTableButton
            // 
            this.openRatesTableButton.Location = new System.Drawing.Point(148, 127);
            this.openRatesTableButton.Name = "openRatesTableButton";
            this.openRatesTableButton.Size = new System.Drawing.Size(75, 23);
            this.openRatesTableButton.TabIndex = 1;
            this.openRatesTableButton.Text = "Rates";
            this.openRatesTableButton.UseVisualStyleBackColor = true;
            this.openRatesTableButton.Click += new System.EventHandler(this.openRatesTableButton_Click);
            // 
            // openCallsTableButton
            // 
            this.openCallsTableButton.Location = new System.Drawing.Point(148, 172);
            this.openCallsTableButton.Name = "openCallsTableButton";
            this.openCallsTableButton.Size = new System.Drawing.Size(75, 23);
            this.openCallsTableButton.TabIndex = 2;
            this.openCallsTableButton.Text = "Calls";
            this.openCallsTableButton.UseVisualStyleBackColor = true;
            this.openCallsTableButton.Click += new System.EventHandler(this.openCallsTableButton_Click);
            // 
            // openUsersTableButton
            // 
            this.openUsersTableButton.Location = new System.Drawing.Point(148, 213);
            this.openUsersTableButton.Name = "openUsersTableButton";
            this.openUsersTableButton.Size = new System.Drawing.Size(75, 23);
            this.openUsersTableButton.TabIndex = 3;
            this.openUsersTableButton.Text = "Users";
            this.openUsersTableButton.UseVisualStyleBackColor = true;
            this.openUsersTableButton.Click += new System.EventHandler(this.openUsersTableButton_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(417, 249);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.openUsersTableButton);
            this.Controls.Add(this.openCallsTableButton);
            this.Controls.Add(this.openRatesTableButton);
            this.Controls.Add(this.openSubsTableButton);
            this.Name = "MainMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button openSubsTableButton;
        private System.Windows.Forms.Button openRatesTableButton;
        private System.Windows.Forms.Button openCallsTableButton;
        private System.Windows.Forms.Button openUsersTableButton;
        private System.Windows.Forms.Button button5;
    }
}