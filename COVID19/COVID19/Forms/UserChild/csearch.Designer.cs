namespace COVID19.Forms.UserChild
{
    partial class csearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(csearch));
            this.searchTable = new System.Windows.Forms.DataGridView();
            this.searchType1 = new System.Windows.Forms.ComboBox();
            this.searchCondition = new System.Windows.Forms.TextBox();
            this.PatientRecord = new System.Windows.Forms.Button();
            this.RelativeRecord = new System.Windows.Forms.Button();
            this.searchType2 = new System.Windows.Forms.ComboBox();
            this.confirm = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.PotentialCarrier = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.searchTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // searchTable
            // 
            this.searchTable.AllowUserToAddRows = false;
            this.searchTable.AllowUserToDeleteRows = false;
            this.searchTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchTable.Location = new System.Drawing.Point(64, 310);
            this.searchTable.Name = "searchTable";
            this.searchTable.ReadOnly = true;
            this.searchTable.RowHeadersWidth = 62;
            this.searchTable.RowTemplate.Height = 30;
            this.searchTable.Size = new System.Drawing.Size(632, 272);
            this.searchTable.TabIndex = 2;
            // 
            // searchType1
            // 
            this.searchType1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchType1.Font = new System.Drawing.Font("苹方 中等", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.searchType1.FormattingEnabled = true;
            this.searchType1.Items.AddRange(new object[] {
            "身份证号",
            "姓名"});
            this.searchType1.Location = new System.Drawing.Point(64, 68);
            this.searchType1.Name = "searchType1";
            this.searchType1.Size = new System.Drawing.Size(162, 37);
            this.searchType1.TabIndex = 3;
            this.searchType1.Text = "请选择";
            this.searchType1.SelectedIndexChanged += new System.EventHandler(this.searchType_SelectedIndexChanged);
            // 
            // searchCondition
            // 
            this.searchCondition.Font = new System.Drawing.Font("苹方 中等", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.searchCondition.Location = new System.Drawing.Point(266, 68);
            this.searchCondition.Name = "searchCondition";
            this.searchCondition.Size = new System.Drawing.Size(165, 37);
            this.searchCondition.TabIndex = 4;
            // 
            // PatientRecord
            // 
            this.PatientRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PatientRecord.Location = new System.Drawing.Point(64, 270);
            this.PatientRecord.Name = "PatientRecord";
            this.PatientRecord.Size = new System.Drawing.Size(107, 40);
            this.PatientRecord.TabIndex = 6;
            this.PatientRecord.Text = "活动记录";
            this.PatientRecord.UseVisualStyleBackColor = true;
            this.PatientRecord.Click += new System.EventHandler(this.PatientRecord_Click);
            // 
            // RelativeRecord
            // 
            this.RelativeRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RelativeRecord.Location = new System.Drawing.Point(171, 270);
            this.RelativeRecord.Name = "RelativeRecord";
            this.RelativeRecord.Size = new System.Drawing.Size(130, 40);
            this.RelativeRecord.TabIndex = 7;
            this.RelativeRecord.Text = "疑似感染源";
            this.RelativeRecord.UseVisualStyleBackColor = true;
            this.RelativeRecord.Click += new System.EventHandler(this.RelativeRecord_Click);
            // 
            // searchType2
            // 
            this.searchType2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchType2.Font = new System.Drawing.Font("苹方 中等", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.searchType2.FormattingEnabled = true;
            this.searchType2.Items.AddRange(new object[] {
            "发热",
            "已确诊"});
            this.searchType2.Location = new System.Drawing.Point(266, 142);
            this.searchType2.Name = "searchType2";
            this.searchType2.Size = new System.Drawing.Size(165, 37);
            this.searchType2.TabIndex = 9;
            this.searchType2.Text = "请选择";
            this.searchType2.SelectedIndexChanged += new System.EventHandler(this.searchDate_SelectedIndexChanged);
            // 
            // confirm
            // 
            this.confirm.BackColor = System.Drawing.Color.Transparent;
            this.confirm.FlatAppearance.BorderSize = 0;
            this.confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirm.Font = new System.Drawing.Font("苹方 中等", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.confirm.Location = new System.Drawing.Point(477, 142);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(87, 37);
            this.confirm.TabIndex = 10;
            this.confirm.Text = "确认";
            this.confirm.UseVisualStyleBackColor = false;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("苹方 中等", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(63, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 29);
            this.label2.TabIndex = 11;
            this.label2.Text = "当前身体状态：";
            // 
            // PotentialCarrier
            // 
            this.PotentialCarrier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PotentialCarrier.Location = new System.Drawing.Point(301, 270);
            this.PotentialCarrier.Name = "PotentialCarrier";
            this.PotentialCarrier.Size = new System.Drawing.Size(130, 40);
            this.PotentialCarrier.TabIndex = 12;
            this.PotentialCarrier.Text = "潜在携带者";
            this.PotentialCarrier.UseVisualStyleBackColor = true;
            this.PotentialCarrier.Click += new System.EventHandler(this.PotentialCarrier_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(779, 353);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(779, 203);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(150, 150);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(779, 53);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(150, 150);
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // csearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1000, 710);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PotentialCarrier);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.searchType2);
            this.Controls.Add(this.RelativeRecord);
            this.Controls.Add(this.PatientRecord);
            this.Controls.Add(this.searchCondition);
            this.Controls.Add(this.searchType1);
            this.Controls.Add(this.searchTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "csearch";
            this.Text = "csearch";
            this.Load += new System.EventHandler(this.csearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.searchTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView searchTable;
        private System.Windows.Forms.ComboBox searchType1;
        private System.Windows.Forms.TextBox searchCondition;
        private System.Windows.Forms.Button PatientRecord;
        private System.Windows.Forms.Button RelativeRecord;
        private System.Windows.Forms.ComboBox searchType2;
        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button PotentialCarrier;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}