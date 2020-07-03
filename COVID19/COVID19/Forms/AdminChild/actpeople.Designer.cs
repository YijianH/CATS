namespace COVID19.Forms.AdminChild
{
    partial class actpeople
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(actpeople));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.actpID = new System.Windows.Forms.TextBox();
            this.actpName = new System.Windows.Forms.TextBox();
            this.actpDate = new System.Windows.Forms.DateTimePicker();
            this.actpTable = new System.Windows.Forms.DataGridView();
            this.Add = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.modify = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.Button();
            this.actpState = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.actpSex = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.actpTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Name = "label4";
            // 
            // actpID
            // 
            resources.ApplyResources(this.actpID, "actpID");
            this.actpID.Name = "actpID";
            this.actpID.TextChanged += new System.EventHandler(this.actpID_TextChanged);
            // 
            // actpName
            // 
            resources.ApplyResources(this.actpName, "actpName");
            this.actpName.Name = "actpName";
            // 
            // actpDate
            // 
            resources.ApplyResources(this.actpDate, "actpDate");
            this.actpDate.Name = "actpDate";
            // 
            // actpTable
            // 
            this.actpTable.AllowUserToAddRows = false;
            this.actpTable.AllowUserToDeleteRows = false;
            this.actpTable.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.actpTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.actpTable, "actpTable");
            this.actpTable.Name = "actpTable";
            this.actpTable.ReadOnly = true;
            this.actpTable.RowTemplate.Height = 30;
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
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.Transparent;
            this.Delete.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.Delete, "Delete");
            this.Delete.Name = "Delete";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // modify
            // 
            this.modify.BackColor = System.Drawing.Color.Transparent;
            this.modify.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.modify, "modify");
            this.modify.Name = "modify";
            this.modify.UseVisualStyleBackColor = false;
            this.modify.Click += new System.EventHandler(this.modify_Click);
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
            // actpState
            // 
            resources.ApplyResources(this.actpState, "actpState");
            this.actpState.FormattingEnabled = true;
            this.actpState.Items.AddRange(new object[] {
            resources.GetString("actpState.Items"),
            resources.GetString("actpState.Items1"),
            resources.GetString("actpState.Items2")});
            this.actpState.Name = "actpState";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Name = "label5";
            // 
            // actpSex
            // 
            resources.ApplyResources(this.actpSex, "actpSex");
            this.actpSex.FormattingEnabled = true;
            this.actpSex.Items.AddRange(new object[] {
            resources.GetString("actpSex.Items"),
            resources.GetString("actpSex.Items1")});
            this.actpSex.Name = "actpSex";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // actpeople
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.actpSex);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.actpState);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.modify);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.actpTable);
            this.Controls.Add(this.actpDate);
            this.Controls.Add(this.actpName);
            this.Controls.Add(this.actpID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "actpeople";
            this.Load += new System.EventHandler(this.actpeople_Load);
            ((System.ComponentModel.ISupportInitialize)(this.actpTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox actpID;
        private System.Windows.Forms.TextBox actpName;
        private System.Windows.Forms.DateTimePicker actpDate;
        private System.Windows.Forms.DataGridView actpTable;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button modify;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.ComboBox actpState;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox actpSex;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}