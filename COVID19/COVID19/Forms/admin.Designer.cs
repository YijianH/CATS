namespace COVID19.Forms
{
    partial class admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.avatar = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.UserManage = new System.Windows.Forms.Button();
            this.MainPage = new System.Windows.Forms.Button();
            this.CityManage = new System.Windows.Forms.Button();
            this.PersonManage = new System.Windows.Forms.Button();
            this.RecordManage = new System.Windows.Forms.Button();
            this.EpidemicAreaManage = new System.Windows.Forms.Button();
            this.SonPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.avatar);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.button1, "button1");
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.ForeColor = System.Drawing.Color.Azure;
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.ForeColor = System.Drawing.Color.Azure;
            this.label1.Name = "label1";
            // 
            // avatar
            // 
            this.avatar.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.avatar, "avatar");
            this.avatar.Name = "avatar";
            this.avatar.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Controls.Add(this.UserManage);
            this.panel2.Controls.Add(this.MainPage);
            this.panel2.Controls.Add(this.CityManage);
            this.panel2.Controls.Add(this.PersonManage);
            this.panel2.Controls.Add(this.RecordManage);
            this.panel2.Controls.Add(this.EpidemicAreaManage);
            this.panel2.ForeColor = System.Drawing.Color.GhostWhite;
            this.panel2.Name = "panel2";
            // 
            // UserManage
            // 
            this.UserManage.BackColor = System.Drawing.Color.Black;
            this.UserManage.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.UserManage, "UserManage");
            this.UserManage.Name = "UserManage";
            this.UserManage.UseVisualStyleBackColor = false;
            this.UserManage.Click += new System.EventHandler(this.UserManage_Click);
            // 
            // MainPage
            // 
            this.MainPage.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.MainPage, "MainPage");
            this.MainPage.Name = "MainPage";
            this.MainPage.UseVisualStyleBackColor = true;
            this.MainPage.Click += new System.EventHandler(this.MainPage_Click);
            // 
            // CityManage
            // 
            this.CityManage.BackColor = System.Drawing.Color.Black;
            this.CityManage.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.CityManage, "CityManage");
            this.CityManage.Name = "CityManage";
            this.CityManage.UseVisualStyleBackColor = false;
            this.CityManage.Click += new System.EventHandler(this.CityManage_Click);
            // 
            // PersonManage
            // 
            this.PersonManage.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.PersonManage, "PersonManage");
            this.PersonManage.Name = "PersonManage";
            this.PersonManage.UseVisualStyleBackColor = true;
            this.PersonManage.Click += new System.EventHandler(this.PersonManage_Click);
            // 
            // RecordManage
            // 
            this.RecordManage.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.RecordManage, "RecordManage");
            this.RecordManage.Name = "RecordManage";
            this.RecordManage.UseVisualStyleBackColor = true;
            this.RecordManage.Click += new System.EventHandler(this.RecordManage_Click);
            // 
            // EpidemicAreaManage
            // 
            this.EpidemicAreaManage.BackColor = System.Drawing.Color.Black;
            this.EpidemicAreaManage.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.EpidemicAreaManage, "EpidemicAreaManage");
            this.EpidemicAreaManage.Name = "EpidemicAreaManage";
            this.EpidemicAreaManage.UseVisualStyleBackColor = false;
            this.EpidemicAreaManage.Click += new System.EventHandler(this.EpidemicAreaManage_Click);
            // 
            // SonPanel
            // 
            this.SonPanel.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.SonPanel, "SonPanel");
            this.SonPanel.Name = "SonPanel";
            // 
            // admin
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.Controls.Add(this.SonPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "admin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox avatar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button UserManage;
        private System.Windows.Forms.Button CityManage;
        private System.Windows.Forms.Button EpidemicAreaManage;
        private System.Windows.Forms.Button RecordManage;
        private System.Windows.Forms.Button PersonManage;
        private System.Windows.Forms.Button MainPage;
        private System.Windows.Forms.Panel SonPanel;
    }
}