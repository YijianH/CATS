namespace COVID19.Forms.AdminChild
{
    partial class pcity
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pcity));
            this.lable1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.City = new System.Windows.Forms.TextBox();
            this.ProRegion = new System.Windows.Forms.TextBox();
            this.ProRegiontable = new System.Windows.Forms.DataGridView();
            this.Add = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ProRegiontable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lable1
            // 
            resources.ApplyResources(this.lable1, "lable1");
            this.lable1.BackColor = System.Drawing.Color.Transparent;
            this.lable1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lable1.Name = "lable1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Name = "label2";
            // 
            // City
            // 
            resources.ApplyResources(this.City, "City");
            this.City.Name = "City";
            // 
            // ProRegion
            // 
            resources.ApplyResources(this.ProRegion, "ProRegion");
            this.ProRegion.Name = "ProRegion";
            // 
            // ProRegiontable
            // 
            this.ProRegiontable.AllowUserToAddRows = false;
            this.ProRegiontable.AllowUserToDeleteRows = false;
            this.ProRegiontable.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.ProRegiontable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.ProRegiontable, "ProRegiontable");
            this.ProRegiontable.Name = "ProRegiontable";
            this.ProRegiontable.ReadOnly = true;
            this.ProRegiontable.RowTemplate.Height = 30;
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.Transparent;
            this.Add.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.Add, "Add");
            this.Add.Name = "Add";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // refresh
            // 
            this.refresh.BackColor = System.Drawing.Color.Transparent;
            this.refresh.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.refresh, "refresh");
            this.refresh.Name = "refresh";
            this.refresh.UseVisualStyleBackColor = false;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // pcity
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.ProRegiontable);
            this.Controls.Add(this.ProRegion);
            this.Controls.Add(this.City);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lable1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "pcity";
            ((System.ComponentModel.ISupportInitialize)(this.ProRegiontable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lable1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox City;
        private System.Windows.Forms.TextBox ProRegion;
        private System.Windows.Forms.DataGridView ProRegiontable;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}