namespace P6
{
    partial class FormIssueModify
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiscoveryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discoverer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InitialDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Component = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonSelectIssue = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Title,
            this.DiscoveryDate,
            this.Discoverer,
            this.InitialDescription,
            this.Component,
            this.Status});
            this.dataGridView1.Location = new System.Drawing.Point(56, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1235, 489);
            this.dataGridView1.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.FillWeight = 10F;
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 8;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 60;
            // 
            // Title
            // 
            this.Title.HeaderText = "Title";
            this.Title.MinimumWidth = 8;
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Width = 280;
            // 
            // DiscoveryDate
            // 
            this.DiscoveryDate.HeaderText = "DiscoveryDate";
            this.DiscoveryDate.MinimumWidth = 8;
            this.DiscoveryDate.Name = "DiscoveryDate";
            this.DiscoveryDate.ReadOnly = true;
            this.DiscoveryDate.Width = 220;
            // 
            // Discoverer
            // 
            this.Discoverer.HeaderText = "Discoverer";
            this.Discoverer.MinimumWidth = 8;
            this.Discoverer.Name = "Discoverer";
            this.Discoverer.ReadOnly = true;
            this.Discoverer.Width = 150;
            // 
            // InitialDescription
            // 
            this.InitialDescription.HeaderText = "InitialDescription";
            this.InitialDescription.MinimumWidth = 8;
            this.InitialDescription.Name = "InitialDescription";
            this.InitialDescription.ReadOnly = true;
            this.InitialDescription.Width = 150;
            // 
            // Component
            // 
            this.Component.HeaderText = "Component";
            this.Component.MinimumWidth = 8;
            this.Component.Name = "Component";
            this.Component.ReadOnly = true;
            this.Component.Width = 150;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 8;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 150;
            // 
            // buttonSelectIssue
            // 
            this.buttonSelectIssue.Location = new System.Drawing.Point(1133, 631);
            this.buttonSelectIssue.Name = "buttonSelectIssue";
            this.buttonSelectIssue.Size = new System.Drawing.Size(158, 29);
            this.buttonSelectIssue.TabIndex = 1;
            this.buttonSelectIssue.Text = "Select Issue";
            this.buttonSelectIssue.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(893, 631);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(158, 29);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // FormIssueModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1337, 751);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSelectIssue);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormIssueModify";
            this.Text = "FormIssueModify";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiscoveryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discoverer;
        private System.Windows.Forms.DataGridViewTextBoxColumn InitialDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn Component;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Button buttonSelectIssue;
        private System.Windows.Forms.Button buttonCancel;
    }
}