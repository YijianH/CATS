namespace COVID19.Forms.AdminChild
{
    partial class admindex
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admindex));
            this.HighRiskArea = new System.Windows.Forms.Button();
            this.ConfirmedCases = new System.Windows.Forms.Button();
            this.LikelyInfection = new System.Windows.Forms.Button();
            this.AdminCounts = new System.Windows.Forms.Button();
            this.AdminIndexTable = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.AdminIndexTable)).BeginInit();
            this.SuspendLayout();
            // 
            // HighRiskArea
            // 
            this.HighRiskArea.BackColor = System.Drawing.Color.PowderBlue;
            this.HighRiskArea.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.HighRiskArea, "HighRiskArea");
            this.HighRiskArea.ForeColor = System.Drawing.Color.SeaShell;
            this.HighRiskArea.Name = "HighRiskArea";
            this.HighRiskArea.UseVisualStyleBackColor = false;
            this.HighRiskArea.Click += new System.EventHandler(this.HighRiskArea_Click);
            // 
            // ConfirmedCases
            // 
            this.ConfirmedCases.BackColor = System.Drawing.Color.SkyBlue;
            resources.ApplyResources(this.ConfirmedCases, "ConfirmedCases");
            this.ConfirmedCases.FlatAppearance.BorderSize = 0;
            this.ConfirmedCases.ForeColor = System.Drawing.Color.SeaShell;
            this.ConfirmedCases.Name = "ConfirmedCases";
            this.ConfirmedCases.UseVisualStyleBackColor = false;
            this.ConfirmedCases.Click += new System.EventHandler(this.ConfirmedCases_Click);
            // 
            // LikelyInfection
            // 
            this.LikelyInfection.BackColor = System.Drawing.Color.PaleTurquoise;
            this.LikelyInfection.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.LikelyInfection, "LikelyInfection");
            this.LikelyInfection.ForeColor = System.Drawing.Color.SeaShell;
            this.LikelyInfection.Name = "LikelyInfection";
            this.LikelyInfection.UseVisualStyleBackColor = false;
            this.LikelyInfection.Click += new System.EventHandler(this.LikelyInfection_Click);
            // 
            // AdminCounts
            // 
            this.AdminCounts.BackColor = System.Drawing.Color.LightBlue;
            this.AdminCounts.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.AdminCounts, "AdminCounts");
            this.AdminCounts.ForeColor = System.Drawing.Color.SeaShell;
            this.AdminCounts.Name = "AdminCounts";
            this.AdminCounts.UseVisualStyleBackColor = false;
            this.AdminCounts.Click += new System.EventHandler(this.AdminCounts_Click);
            // 
            // AdminIndexTable
            // 
            this.AdminIndexTable.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.AdminIndexTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AdminIndexTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.AdminIndexTable, "AdminIndexTable");
            this.AdminIndexTable.Name = "AdminIndexTable";
            this.AdminIndexTable.RowTemplate.Height = 30;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightCyan;
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.GhostWhite;
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LavenderBlush;
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Name = "panel4";
            // 
            // admindex
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AdminIndexTable);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AdminCounts);
            this.Controls.Add(this.LikelyInfection);
            this.Controls.Add(this.ConfirmedCases);
            this.Controls.Add(this.HighRiskArea);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "admindex";
            this.Load += new System.EventHandler(this.admindex_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AdminIndexTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button HighRiskArea;
        private System.Windows.Forms.Button ConfirmedCases;
        private System.Windows.Forms.Button LikelyInfection;
        private System.Windows.Forms.Button AdminCounts;
        private System.Windows.Forms.DataGridView AdminIndexTable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}