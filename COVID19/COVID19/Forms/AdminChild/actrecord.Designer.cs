namespace COVID19.Forms.AdminChild
{
    partial class actrecord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(actrecord));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Ast = new System.Windows.Forms.DateTimePicker();
            this.Aet = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.modify = new System.Windows.Forms.Button();
            this.ActRecordTable = new System.Windows.Forms.DataGridView();
            this.refresh = new System.Windows.Forms.Button();
            this.actID = new System.Windows.Forms.TextBox();
            this.actCity = new System.Windows.Forms.TextBox();
            this.actArea = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ActRecordTable)).BeginInit();
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
            // Ast
            // 
            resources.ApplyResources(this.Ast, "Ast");
            this.Ast.Name = "Ast";
            // 
            // Aet
            // 
            resources.ApplyResources(this.Aet, "Aet");
            this.Aet.Name = "Aet";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
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
            // ActRecordTable
            // 
            this.ActRecordTable.AllowUserToAddRows = false;
            this.ActRecordTable.AllowUserToDeleteRows = false;
            this.ActRecordTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.ActRecordTable, "ActRecordTable");
            this.ActRecordTable.Name = "ActRecordTable";
            this.ActRecordTable.ReadOnly = true;
            this.ActRecordTable.RowTemplate.Height = 30;
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
            // actID
            // 
            resources.ApplyResources(this.actID, "actID");
            this.actID.Name = "actID";
            // 
            // actCity
            // 
            resources.ApplyResources(this.actCity, "actCity");
            this.actCity.Name = "actCity";
            // 
            // actArea
            // 
            resources.ApplyResources(this.actArea, "actArea");
            this.actArea.Name = "actArea";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // actrecord
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.actArea);
            this.Controls.Add(this.actCity);
            this.Controls.Add(this.actID);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.ActRecordTable);
            this.Controls.Add(this.modify);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Aet);
            this.Controls.Add(this.Ast);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "actrecord";
            this.Load += new System.EventHandler(this.actrecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ActRecordTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker Ast;
        private System.Windows.Forms.DateTimePicker Aet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button modify;
        private System.Windows.Forms.DataGridView ActRecordTable;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.TextBox actID;
        private System.Windows.Forms.TextBox actCity;
        private System.Windows.Forms.TextBox actArea;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}