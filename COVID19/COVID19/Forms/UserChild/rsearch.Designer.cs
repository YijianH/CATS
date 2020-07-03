namespace COVID19.Forms.UserChild
{
    partial class rsearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rsearch));
            this.searchType = new System.Windows.Forms.ComboBox();
            this.searchCondition = new System.Windows.Forms.TextBox();
            this.searchSt = new System.Windows.Forms.DateTimePicker();
            this.searchEt = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.Button();
            this.searchTable = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.searchTable)).BeginInit();
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
            "姓名",
            "地点(城市-区域)",
            "地点-时间段"});
            this.searchType.Location = new System.Drawing.Point(87, 76);
            this.searchType.Margin = new System.Windows.Forms.Padding(0);
            this.searchType.Name = "searchType";
            this.searchType.Size = new System.Drawing.Size(178, 37);
            this.searchType.TabIndex = 0;
            this.searchType.Text = "请选择查询关键字";
            this.searchType.SelectedIndexChanged += new System.EventHandler(this.searchType_SelectedIndexChanged);
            // 
            // searchCondition
            // 
            this.searchCondition.Font = new System.Drawing.Font("苹方 中等", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.searchCondition.Location = new System.Drawing.Point(87, 149);
            this.searchCondition.Name = "searchCondition";
            this.searchCondition.Size = new System.Drawing.Size(178, 37);
            this.searchCondition.TabIndex = 1;
            // 
            // searchSt
            // 
            this.searchSt.Font = new System.Drawing.Font("苹方 中等", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.searchSt.Location = new System.Drawing.Point(307, 149);
            this.searchSt.Margin = new System.Windows.Forms.Padding(0);
            this.searchSt.Name = "searchSt";
            this.searchSt.Size = new System.Drawing.Size(178, 37);
            this.searchSt.TabIndex = 2;
            // 
            // searchEt
            // 
            this.searchEt.Font = new System.Drawing.Font("苹方 中等", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.searchEt.Location = new System.Drawing.Point(528, 149);
            this.searchEt.Margin = new System.Windows.Forms.Padding(0);
            this.searchEt.Name = "searchEt";
            this.searchEt.Size = new System.Drawing.Size(178, 37);
            this.searchEt.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("苹方 中等", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(495, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "-";
            // 
            // search
            // 
            this.search.FlatAppearance.BorderSize = 0;
            this.search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search.Font = new System.Drawing.Font("苹方 中等", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.search.Location = new System.Drawing.Point(623, 202);
            this.search.Margin = new System.Windows.Forms.Padding(0);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(83, 37);
            this.search.TabIndex = 5;
            this.search.Text = "查找";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // searchTable
            // 
            this.searchTable.AllowUserToAddRows = false;
            this.searchTable.AllowUserToDeleteRows = false;
            this.searchTable.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.searchTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchTable.Location = new System.Drawing.Point(87, 268);
            this.searchTable.Name = "searchTable";
            this.searchTable.RowHeadersWidth = 62;
            this.searchTable.RowTemplate.Height = 30;
            this.searchTable.Size = new System.Drawing.Size(596, 304);
            this.searchTable.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(755, 128);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(755, 328);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 200);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // rsearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1000, 710);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.searchTable);
            this.Controls.Add(this.search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchEt);
            this.Controls.Add(this.searchSt);
            this.Controls.Add(this.searchCondition);
            this.Controls.Add(this.searchType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "rsearch";
            this.Text = "rsearch";
            this.Load += new System.EventHandler(this.rsearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.searchTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox searchType;
        private System.Windows.Forms.TextBox searchCondition;
        private System.Windows.Forms.DateTimePicker searchSt;
        private System.Windows.Forms.DateTimePicker searchEt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.DataGridView searchTable;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}