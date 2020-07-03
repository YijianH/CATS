using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COVID19.Forms.UserChild;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;

namespace COVID19.Forms
{
    public partial class user : Form
    {
        public user()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            boot boot = new boot();
            this.Dispose();
            boot.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MYSQL mYSQL = new MYSQL();
            //MySqlConnection conn = mYSQL.Connection();
            string sql = "SELECT * FROM Person;";
            DataTable table = mYSQL.GetMessage(sql);
            //dataGridView1.DataSource = table;
           // ID.Visible = false;
            //Refresh();
        }

        private void user_Load(object sender, EventArgs e)
        {

        }

        private void CCSearch_Click(object sender, EventArgs e)
        {
            SonPanel.Controls.Clear();
            this.IsMdiContainer = true;
            csearch ce = new csearch();
            ce.TopLevel = false;
            ce.MdiParent = this;
            ce.Parent = this.SonPanel;
            ce.FormBorderStyle = FormBorderStyle.None;
            ce.Show();
        }

        private void PatientSearch_Click(object sender, EventArgs e)
        {
            SonPanel.Controls.Clear();
            this.IsMdiContainer = true;
            psearch pe = new psearch();
            pe.TopLevel = false;
            pe.MdiParent = this;
            pe.Parent = this.SonPanel;
            pe.FormBorderStyle = FormBorderStyle.None;
            pe.Show();
        }

        private void ActRecSearch_Click(object sender, EventArgs e)
        {
            SonPanel.Controls.Clear();
            this.IsMdiContainer = true;
            rsearch re = new rsearch();
            re.TopLevel = false;
            re.MdiParent = this;
            re.Parent = this.SonPanel;
            re.FormBorderStyle = FormBorderStyle.None;
            re.Show();
        }

        private void EpiAreaSearch_Click(object sender, EventArgs e)
        {
            SonPanel.Controls.Clear();
            this.IsMdiContainer = true;
            esearch se = new esearch();
            se.TopLevel = false;
            se.MdiParent = this;
            se.Parent = this.SonPanel;
            se.FormBorderStyle = FormBorderStyle.None;
            se.Show();
        }
    }
}
