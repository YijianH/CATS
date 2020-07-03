namespace COVID19.Forms.AdminChild
{
    partial class riskarea
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(riskarea));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.City = new System.Windows.Forms.TextBox();
            this.Area = new System.Windows.Forms.TextBox();
            this.riskAreatable = new System.Windows.Forms.DataGridView();
            this.add = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.modify = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.Button();
            this.riskLevel = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.riskAreatable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Name = "label3";
            // 
            // City
            // 
            this.City.BackColor = System.Drawing.Color.FloralWhite;
            resources.ApplyResources(this.City, "City");
            this.City.Name = "City";
            // 
            // Area
            // 
            this.Area.BackColor = System.Drawing.Color.FloralWhite;
            resources.ApplyResources(this.Area, "Area");
            this.Area.Name = "Area";
            // 
            // riskAreatable
            // 
            this.riskAreatable.AllowUserToAddRows = false;
            this.riskAreatable.AllowUserToDeleteRows = false;
            this.riskAreatable.BackgroundColor = System.Drawing.Color.Snow;
            this.riskAreatable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.riskAreatable, "riskAreatable");
            this.riskAreatable.Name = "riskAreatable";
            this.riskAreatable.ReadOnly = true;
            this.riskAreatable.RowTemplate.Height = 30;
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.Transparent;
            this.add.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.add, "add");
            this.add.ForeColor = System.Drawing.Color.Navy;
            this.add.Name = "add";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.Transparent;
            this.delete.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.delete, "delete");
            this.delete.ForeColor = System.Drawing.Color.Navy;
            this.delete.Name = "delete";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // modify
            // 
            this.modify.BackColor = System.Drawing.Color.Transparent;
            this.modify.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.modify, "modify");
            this.modify.ForeColor = System.Drawing.Color.Navy;
            this.modify.Name = "modify";
            this.modify.UseVisualStyleBackColor = false;
            this.modify.Click += new System.EventHandler(this.modify_Click);
            // 
            // refresh
            // 
            this.refresh.BackColor = System.Drawing.Color.Transparent;
            this.refresh.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.refresh, "refresh");
            this.refresh.ForeColor = System.Drawing.Color.Navy;
            this.refresh.Name = "refresh";
            this.refresh.UseVisualStyleBackColor = false;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // riskLevel
            // 
            this.riskLevel.BackColor = System.Drawing.Color.FloralWhite;
            resources.ApplyResources(this.riskLevel, "riskLevel");
            this.riskLevel.FormattingEnabled = true;
            this.riskLevel.Items.AddRange(new object[] {
            resources.GetString("riskLevel.Items"),
            resources.GetString("riskLevel.Items1"),
            resources.GetString("riskLevel.Items2")});
            this.riskLevel.Name = "riskLevel";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FloralWhite;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // riskarea
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.riskLevel);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.modify);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.add);
            this.Controls.Add(this.riskAreatable);
            this.Controls.Add(this.Area);
            this.Controls.Add(this.City);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "riskarea";
            ((System.ComponentModel.ISupportInitialize)(this.riskAreatable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox City;
        private System.Windows.Forms.TextBox Area;
        private System.Windows.Forms.DataGridView riskAreatable;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button modify;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.ComboBox riskLevel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}