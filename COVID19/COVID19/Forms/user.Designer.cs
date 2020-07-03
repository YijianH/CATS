namespace COVID19.Forms
{
    partial class user
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(user));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.avatar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SonPanel = new System.Windows.Forms.Panel();
            this.PatientSearch = new System.Windows.Forms.Button();
            this.ActRecSearch = new System.Windows.Forms.Button();
            this.EpiAreaSearch = new System.Windows.Forms.Button();
            this.CCSearch = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OrangeRed;
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.avatar);
            this.panel1.Controls.Add(this.label1);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.button5, "button5");
            this.button5.Name = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // avatar
            // 
            this.avatar.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.avatar, "avatar");
            this.avatar.Name = "avatar";
            this.avatar.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // SonPanel
            // 
            this.SonPanel.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.SonPanel, "SonPanel");
            this.SonPanel.Name = "SonPanel";
            this.SonPanel.Tag = "";
            // 
            // PatientSearch
            // 
            this.PatientSearch.BackColor = System.Drawing.Color.Black;
            this.PatientSearch.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.PatientSearch, "PatientSearch");
            this.PatientSearch.ForeColor = System.Drawing.Color.Azure;
            this.PatientSearch.Name = "PatientSearch";
            this.PatientSearch.UseVisualStyleBackColor = false;
            this.PatientSearch.Click += new System.EventHandler(this.PatientSearch_Click);
            // 
            // ActRecSearch
            // 
            this.ActRecSearch.BackColor = System.Drawing.Color.Black;
            this.ActRecSearch.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.ActRecSearch, "ActRecSearch");
            this.ActRecSearch.ForeColor = System.Drawing.Color.Azure;
            this.ActRecSearch.Name = "ActRecSearch";
            this.ActRecSearch.UseVisualStyleBackColor = false;
            this.ActRecSearch.Click += new System.EventHandler(this.ActRecSearch_Click);
            // 
            // EpiAreaSearch
            // 
            this.EpiAreaSearch.BackColor = System.Drawing.Color.Black;
            this.EpiAreaSearch.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.EpiAreaSearch, "EpiAreaSearch");
            this.EpiAreaSearch.ForeColor = System.Drawing.Color.Azure;
            this.EpiAreaSearch.Name = "EpiAreaSearch";
            this.EpiAreaSearch.UseVisualStyleBackColor = false;
            this.EpiAreaSearch.Click += new System.EventHandler(this.EpiAreaSearch_Click);
            // 
            // CCSearch
            // 
            this.CCSearch.BackColor = System.Drawing.Color.Black;
            this.CCSearch.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.CCSearch, "CCSearch");
            this.CCSearch.ForeColor = System.Drawing.Color.Azure;
            this.CCSearch.Name = "CCSearch";
            this.CCSearch.UseVisualStyleBackColor = false;
            this.CCSearch.Click += new System.EventHandler(this.CCSearch_Click);
            // 
            // user
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SonPanel);
            this.Controls.Add(this.CCSearch);
            this.Controls.Add(this.EpiAreaSearch);
            this.Controls.Add(this.ActRecSearch);
            this.Controls.Add(this.PatientSearch);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "user";
            this.Load += new System.EventHandler(this.user_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox avatar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel SonPanel;
        private System.Windows.Forms.Button PatientSearch;
        private System.Windows.Forms.Button ActRecSearch;
        private System.Windows.Forms.Button EpiAreaSearch;
        private System.Windows.Forms.Button CCSearch;
    }
}