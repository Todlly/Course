namespace TeleCompany
{
    partial class AddRateForm
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
            this.cityCodeBox = new System.Windows.Forms.TextBox();
            this.cityNameBox = new System.Windows.Forms.TextBox();
            this.longRateBox = new System.Windows.Forms.TextBox();
            this.localRateBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cityCodeBox
            // 
            this.cityCodeBox.Location = new System.Drawing.Point(13, 31);
            this.cityCodeBox.Name = "cityCodeBox";
            this.cityCodeBox.Size = new System.Drawing.Size(100, 20);
            this.cityCodeBox.TabIndex = 0;
            // 
            // cityNameBox
            // 
            this.cityNameBox.Location = new System.Drawing.Point(119, 31);
            this.cityNameBox.Name = "cityNameBox";
            this.cityNameBox.Size = new System.Drawing.Size(100, 20);
            this.cityNameBox.TabIndex = 1;
            // 
            // longRateBox
            // 
            this.longRateBox.Location = new System.Drawing.Point(331, 31);
            this.longRateBox.Name = "longRateBox";
            this.longRateBox.Size = new System.Drawing.Size(100, 20);
            this.longRateBox.TabIndex = 3;
            // 
            // localRateBox
            // 
            this.localRateBox.Location = new System.Drawing.Point(225, 31);
            this.localRateBox.Name = "localRateBox";
            this.localRateBox.Size = new System.Drawing.Size(100, 20);
            this.localRateBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "City code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "City name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Local rate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(328, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Long distance rate";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(463, 28);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 8;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // AddRateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 76);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.longRateBox);
            this.Controls.Add(this.localRateBox);
            this.Controls.Add(this.cityNameBox);
            this.Controls.Add(this.cityCodeBox);
            this.Name = "AddRateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddRateForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cityCodeBox;
        private System.Windows.Forms.TextBox cityNameBox;
        private System.Windows.Forms.TextBox longRateBox;
        private System.Windows.Forms.TextBox localRateBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addButton;
    }
}