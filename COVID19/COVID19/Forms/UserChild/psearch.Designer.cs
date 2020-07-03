namespace COVID19.Forms.UserChild
{
    partial class psearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(psearch));
            this.searchType = new System.Windows.Forms.ComboBox();
            this.searchCondition = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Button();
            this.psearchTable = new System.Windows.Forms.DataGridView();
            this.psearchDate = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.psearchTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // searchType
            // 
            resources.ApplyResources(this.searchType, "searchType");
            this.searchType.FormattingEnabled = true;
            this.searchType.Items.AddRange(new object[] {
            resources.GetString("searchType.Items"),
            resources.GetString("searchType.Items1"),
            resources.GetString("searchType.Items2")});
            this.searchType.Name = "searchType";
            this.searchType.SelectedIndexChanged += new System.EventHandler(this.searchType_SelectedIndexChanged);
            // 
            // searchCondition
            // 
            resources.ApplyResources(this.searchCondition, "searchCondition");
            this.searchCondition.Name = "searchCondition";
            // 
            // Search
            // 
            this.Search.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.Search, "Search");
            this.Search.Name = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // psearchTable
            // 
            this.psearchTable.AllowUserToAddRows = false;
            this.psearchTable.AllowUserToDeleteRows = false;
            this.psearchTable.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.psearchTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.psearchTable.GridColor = System.Drawing.Color.WhiteSmoke;
            resources.ApplyResources(this.psearchTable, "psearchTable");
            this.psearchTable.Name = "psearchTable";
            this.psearchTable.ReadOnly = true;
            this.psearchTable.RowTemplate.Height = 30;
            // 
            // psearchDate
            // 
            resources.ApplyResources(this.psearchDate, "psearchDate");
            this.psearchDate.Name = "psearchDate";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // psearch
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.psearchDate);
            this.Controls.Add(this.psearchTable);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.searchCondition);
            this.Controls.Add(this.searchType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "psearch";
            this.Load += new System.EventHandler(this.psearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.psearchTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox searchType;
        private System.Windows.Forms.TextBox searchCondition;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.DataGridView psearchTable;
        private System.Windows.Forms.DateTimePicker psearchDate;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}