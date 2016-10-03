namespace ClientManagementResource
{
    partial class MainScreen
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.searchClientButton = new System.Windows.Forms.Button();
            this.searchJobsButton = new System.Windows.Forms.Button();
            this.newClientButton = new System.Windows.Forms.Button();
            this.newJobButton = new System.Windows.Forms.Button();
            this.jobsGridView = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jobsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.jobsGridView, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.599508F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.40049F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(769, 381);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.searchClientButton);
            this.flowLayoutPanel1.Controls.Add(this.searchJobsButton);
            this.flowLayoutPanel1.Controls.Add(this.newClientButton);
            this.flowLayoutPanel1.Controls.Add(this.newJobButton);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(763, 26);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // searchClientButton
            // 
            this.searchClientButton.Location = new System.Drawing.Point(3, 3);
            this.searchClientButton.Name = "searchClientButton";
            this.searchClientButton.Size = new System.Drawing.Size(126, 23);
            this.searchClientButton.TabIndex = 0;
            this.searchClientButton.Text = "Search For Clients";
            this.searchClientButton.UseVisualStyleBackColor = true;
            // 
            // searchJobsButton
            // 
            this.searchJobsButton.Location = new System.Drawing.Point(135, 3);
            this.searchJobsButton.Name = "searchJobsButton";
            this.searchJobsButton.Size = new System.Drawing.Size(107, 23);
            this.searchJobsButton.TabIndex = 1;
            this.searchJobsButton.Text = "Search for Jobs";
            this.searchJobsButton.UseVisualStyleBackColor = true;
            this.searchJobsButton.Click += new System.EventHandler(this.searchJobsButton_Click);
            // 
            // newClientButton
            // 
            this.newClientButton.Location = new System.Drawing.Point(248, 3);
            this.newClientButton.Name = "newClientButton";
            this.newClientButton.Size = new System.Drawing.Size(75, 23);
            this.newClientButton.TabIndex = 2;
            this.newClientButton.Text = "New Client";
            this.newClientButton.UseVisualStyleBackColor = true;
            this.newClientButton.Click += new System.EventHandler(this.newClientButton_Click);
            // 
            // newJobButton
            // 
            this.newJobButton.Location = new System.Drawing.Point(329, 3);
            this.newJobButton.Name = "newJobButton";
            this.newJobButton.Size = new System.Drawing.Size(75, 23);
            this.newJobButton.TabIndex = 3;
            this.newJobButton.Text = "New Job";
            this.newJobButton.UseVisualStyleBackColor = true;
            this.newJobButton.Click += new System.EventHandler(this.newJobButton_Click);
            // 
            // jobsGridView
            // 
            this.jobsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.jobsGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.jobsGridView.Location = new System.Drawing.Point(3, 58);
            this.jobsGridView.Name = "jobsGridView";
            this.jobsGridView.Size = new System.Drawing.Size(763, 320);
            this.jobsGridView.TabIndex = 1;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 403);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainScreen";
            this.Text = "CRM";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.jobsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button searchClientButton;
        private System.Windows.Forms.Button searchJobsButton;
        private System.Windows.Forms.Button newClientButton;
        private System.Windows.Forms.Button newJobButton;
        private System.Windows.Forms.DataGridView jobsGridView;
    }
}