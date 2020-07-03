namespace COVID19.Forms.UserChild
{
    partial class esearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(esearch));
            this.searchType = new System.Windows.Forms.ComboBox();
            this.searchCondition = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Button();
            this.searchRiskLevel = new System.Windows.Forms.ComboBox();
            this.esearchTable = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.esearchTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // searchType
            // 
            this.searchType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchType.Font = new System.Drawing.Font("苹方 中等", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.searchType.FormattingEnabled = true;
            this.searchType.Items.AddRange(new object[] {
            "省(简称)",
            "城市",
            "风险等级"});
            this.searchType.Location = new System.Drawing.Point(89, 74);
            this.searchType.Margin = new System.Windows.Forms.Padding(0);
            this.searchType.Name = "searchType";
            this.searchType.Size = new System.Drawing.Size(206, 37);
            this.searchType.TabIndex = 0;
            this.searchType.Text = "请选择查询的关键字";
            this.searchType.SelectedIndexChanged += new System.EventHandler(this.searchType_SelectedIndexChanged);
            // 
            // searchCondition
            // 
            this.searchCondition.Location = new System.Drawing.Point(89, 141);
            this.searchCondition.Margin = new System.Windows.Forms.Padding(0);
            this.searchCondition.Name = "searchCondition";
            this.searchCondition.Size = new System.Drawing.Size(260, 28);
            this.searchCondition.TabIndex = 1;
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.Transparent;
            this.search.FlatAppearance.BorderSize = 0;
            this.search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search.Font = new System.Drawing.Font("苹方 中等", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.search.Location = new System.Drawing.Point(374, 137);
            this.search.Margin = new System.Windows.Forms.Padding(0);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(93, 47);
            this.search.TabIndex = 2;
            this.search.Text = "查找";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // searchRiskLevel
            // 
            this.searchRiskLevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchRiskLevel.Font = new System.Drawing.Font("苹方 中等", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.searchRiskLevel.FormattingEnabled = true;
            this.searchRiskLevel.Items.AddRange(new object[] {
            "L1",
            "L2",
            "L3"});
            this.searchRiskLevel.Location = new System.Drawing.Point(89, 143);
            this.searchRiskLevel.Margin = new System.Windows.Forms.Padding(0);
            this.searchRiskLevel.Name = "searchRiskLevel";
            this.searchRiskLevel.Size = new System.Drawing.Size(260, 37);
            this.searchRiskLevel.TabIndex = 3;
            this.searchRiskLevel.Text = "请选择风险等级";
            // 
            // esearchTable
            // 
            this.esearchTable.AllowUserToAddRows = false;
            this.esearchTable.AllowUserToDeleteRows = false;
            this.esearchTable.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.esearchTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.esearchTable.Location = new System.Drawing.Point(89, 209);
            this.esearchTable.Margin = new System.Windows.Forms.Padding(0);
            this.esearchTable.Name = "esearchTable";
            this.esearchTable.ReadOnly = true;
            this.esearchTable.RowHeadersWidth = 62;
            this.esearchTable.RowTemplate.Height = 30;
            this.esearchTable.Size = new System.Drawing.Size(658, 330);
            this.esearchTable.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(777, 74);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(777, 274);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 200);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // esearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1000, 710);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.esearchTable);
            this.Controls.Add(this.searchRiskLevel);
            this.Controls.Add(this.search);
            this.Controls.Add(this.searchCondition);
            this.Controls.Add(this.searchType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "esearch";
            this.Text = "esearch";
            this.Load += new System.EventHandler(this.esearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.esearchTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox searchType;
        private System.Windows.Forms.TextBox searchCondition;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.ComboBox searchRiskLevel;
        private System.Windows.Forms.DataGridView esearchTable;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}