namespace COVID19.Forms
{
    partial class register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(register));
            this.account = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.repasswd = new System.Windows.Forms.TextBox();
            this.back = new System.Windows.Forms.Button();
            this.submit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // account
            // 
            this.account.BackColor = System.Drawing.Color.GhostWhite;
            this.account.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.account, "account");
            this.account.Name = "account";
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.Color.GhostWhite;
            this.password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.password, "password");
            this.password.Name = "password";
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // repasswd
            // 
            this.repasswd.BackColor = System.Drawing.Color.GhostWhite;
            this.repasswd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.repasswd, "repasswd");
            this.repasswd.Name = "repasswd";
            this.repasswd.TextChanged += new System.EventHandler(this.repasswd_TextChanged);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Transparent;
            this.back.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.back, "back");
            this.back.Name = "back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // submit
            // 
            this.submit.BackColor = System.Drawing.Color.Transparent;
            this.submit.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.submit, "submit");
            this.submit.Name = "submit";
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.label1.Name = "label1";
            // 
            // register
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.back);
            this.Controls.Add(this.repasswd);
            this.Controls.Add(this.password);
            this.Controls.Add(this.account);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "register";
            this.Opacity = 0.95D;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox account;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox repasswd;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label label1;
    }
}