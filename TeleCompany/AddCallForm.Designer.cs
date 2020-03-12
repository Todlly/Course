namespace TeleCompany
{
    partial class AddCallForm
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
            this.subIDBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cityCodeBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.phoneNumberBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.durationBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.dateBox = new System.Windows.Forms.TextBox();
            this.callTypeBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // subIDBox
            // 
            this.subIDBox.Location = new System.Drawing.Point(12, 23);
            this.subIDBox.Name = "subIDBox";
            this.subIDBox.Size = new System.Drawing.Size(100, 20);
            this.subIDBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Subscriber ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Call date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(224, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "City code";
            // 
            // cityCodeBox
            // 
            this.cityCodeBox.Location = new System.Drawing.Point(224, 23);
            this.cityCodeBox.Name = "cityCodeBox";
            this.cityCodeBox.Size = new System.Drawing.Size(100, 20);
            this.cityCodeBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(224, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Phone number";
            // 
            // phoneNumberBox
            // 
            this.phoneNumberBox.Location = new System.Drawing.Point(224, 68);
            this.phoneNumberBox.Name = "phoneNumberBox";
            this.phoneNumberBox.Size = new System.Drawing.Size(100, 20);
            this.phoneNumberBox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(118, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Call duration";
            // 
            // durationBox
            // 
            this.durationBox.Location = new System.Drawing.Point(118, 68);
            this.durationBox.Name = "durationBox";
            this.durationBox.Size = new System.Drawing.Size(100, 20);
            this.durationBox.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Call type";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(381, 41);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 12;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // dateBox
            // 
            this.dateBox.Location = new System.Drawing.Point(118, 23);
            this.dateBox.Name = "dateBox";
            this.dateBox.Size = new System.Drawing.Size(100, 20);
            this.dateBox.TabIndex = 2;
            // 
            // callTypeBox
            // 
            this.callTypeBox.FormattingEnabled = true;
            this.callTypeBox.Items.AddRange(new object[] {
            "Local",
            "Long distance"});
            this.callTypeBox.Location = new System.Drawing.Point(12, 67);
            this.callTypeBox.Name = "callTypeBox";
            this.callTypeBox.Size = new System.Drawing.Size(100, 21);
            this.callTypeBox.TabIndex = 13;
            // 
            // AddCallForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 104);
            this.Controls.Add(this.callTypeBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.phoneNumberBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.durationBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cityCodeBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.subIDBox);
            this.Name = "AddCallForm";
            this.Text = "AddCallForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox subIDBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cityCodeBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox phoneNumberBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox durationBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox dateBox;
        private System.Windows.Forms.ComboBox callTypeBox;
    }
}