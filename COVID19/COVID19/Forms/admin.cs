using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COVID19.Forms.AdminChild;

namespace COVID19.Forms
{
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            boot boot = new boot();
            this.Dispose();
            boot.ShowDialog();
        }

        private void MainPage_Click(object sender, EventArgs e)
        {
            SonPanel.Controls.Clear();
            this.IsMdiContainer = true;
            admindex ai = new admindex();
            ai.TopLevel = false;
            ai.MdiParent = this;
            ai.Parent = this.SonPanel;//指定子窗体的父容器为
            ai.FormBorderStyle = FormBorderStyle.None;//隐藏子窗体边框，当然也可以在子窗体的窗体加载事件中实现
            ai.Show();
            //this.SonPanel.BackColor = Color.FromArgb(53, 66, 83);
        }

        private void PersonManage_Click(object sender, EventArgs e)
        {
            SonPanel.Controls.Clear();
            this.IsMdiContainer = true;
            actpeople ap = new actpeople();
            ap.TopLevel = false;
            ap.MdiParent = this;
            ap.Parent = this.SonPanel;//指定子窗体的父容器为
            ap.FormBorderStyle = FormBorderStyle.None;//隐藏子窗体边框，当然也可以在子窗体的窗体加载事件中实现
            ap.Show();
            //this.SonPanel.BackColor = Color.FromArgb(100, 66, 83);
            
        }

        private void EpidemicAreaManage_Click(object sender, EventArgs e)
        {
            SonPanel.Controls.Clear();

            this.IsMdiContainer = true;
            riskarea ra = new riskarea();
            ra.TopLevel = false;
            ra.MdiParent = this;
            ra.Parent = this.SonPanel;
            ra.FormBorderStyle = FormBorderStyle.None;
            ra.Show();

        }

        private void CityManage_Click(object sender, EventArgs e)
        {
            SonPanel.Controls.Clear();

            this.IsMdiContainer = true;
            pcity pt = new pcity();
            pt.TopLevel = false;
            pt.MdiParent = this;
            pt.Parent = this.SonPanel;
            pt.FormBorderStyle = FormBorderStyle.None;
            pt.Show();
        }

        private void RecordManage_Click(object sender, EventArgs e)
        {
            SonPanel.Controls.Clear();

            this.IsMdiContainer = true;
            actrecord ar = new actrecord();
            ar.TopLevel = false;
            ar.MdiParent = this;
            ar.Parent = this.SonPanel;
            ar.FormBorderStyle = FormBorderStyle.None;
            ar.Show();
        }

        private void UserManage_Click(object sender, EventArgs e)
        {
            SonPanel.Controls.Clear();
            this.IsMdiContainer = true;
            userLoginManage ulm = new userLoginManage();
            ulm.TopLevel = false;
            ulm.MdiParent = this;
            ulm.Parent = this.SonPanel;
            ulm.FormBorderStyle = FormBorderStyle.None;
            ulm.Show();
        }
    
    }
}
