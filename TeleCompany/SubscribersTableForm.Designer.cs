namespace TeleCompany
{
    partial class SubscribersTableForm
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
            this.components = new System.ComponentModel.Container();
            this.SubscribersTableView = new System.Windows.Forms.DataGridView();
            this.backButton = new System.Windows.Forms.Button();
            this.subscribersDataSet = new TeleCompany.SubscribersDataSet();
            this.subscribersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.subscribersTableAdapter = new TeleCompany.SubscribersDataSetTableAdapters.SubscribersTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secondNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.SubscribersTableView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subscribersDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subscribersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // SubscribersTableView
            // 
            this.SubscribersTableView.AllowUserToResizeColumns = false;
            this.SubscribersTableView.AllowUserToResizeRows = false;
            this.SubscribersTableView.AutoGenerateColumns = false;
            this.SubscribersTableView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SubscribersTableView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.secondNameDataGridViewTextBoxColumn,
            this.telNumberDataGridViewTextBoxColumn,
            this.adressDataGridViewTextBoxColumn});
            this.SubscribersTableView.DataSource = this.subscribersBindingSource;
            this.SubscribersTableView.Location = new System.Drawing.Point(12, 12);
            this.SubscribersTableView.Name = "SubscribersTableView";
            this.SubscribersTableView.Size = new System.Drawing.Size(776, 260);
            this.SubscribersTableView.TabIndex = 0;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(638, 383);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "Home";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // subscribersDataSet
            // 
            this.subscribersDataSet.DataSetName = "SubscribersDataSet";
            this.subscribersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // subscribersBindingSource
            // 
            this.subscribersBindingSource.DataMember = "Subscribers";
            this.subscribersBindingSource.DataSource = this.subscribersDataSet;
            // 
            // subscribersTableAdapter
            // 
            this.subscribersTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "First Name";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // secondNameDataGridViewTextBoxColumn
            // 
            this.secondNameDataGridViewTextBoxColumn.DataPropertyName = "Second Name";
            this.secondNameDataGridViewTextBoxColumn.HeaderText = "Second Name";
            this.secondNameDataGridViewTextBoxColumn.Name = "secondNameDataGridViewTextBoxColumn";
            // 
            // telNumberDataGridViewTextBoxColumn
            // 
            this.telNumberDataGridViewTextBoxColumn.DataPropertyName = "Tel Number";
            this.telNumberDataGridViewTextBoxColumn.HeaderText = "Tel Number";
            this.telNumberDataGridViewTextBoxColumn.Name = "telNumberDataGridViewTextBoxColumn";
            // 
            // adressDataGridViewTextBoxColumn
            // 
            this.adressDataGridViewTextBoxColumn.DataPropertyName = "Adress";
            this.adressDataGridViewTextBoxColumn.HeaderText = "Adress";
            this.adressDataGridViewTextBoxColumn.Name = "adressDataGridViewTextBoxColumn";
            // 
            // SubscribersTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.SubscribersTableView);
            this.Name = "SubscribersTableForm";
            this.Text = "SubscribersTable";
            this.Load += new System.EventHandler(this.SubscribersTableForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SubscribersTableView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subscribersDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subscribersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView SubscribersTableView;
        private System.Windows.Forms.Button backButton;
        private SubscribersDataSet subscribersDataSet;
        private System.Windows.Forms.BindingSource subscribersBindingSource;
        private SubscribersDataSetTableAdapters.SubscribersTableAdapter subscribersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn secondNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adressDataGridViewTextBoxColumn;
    }
}