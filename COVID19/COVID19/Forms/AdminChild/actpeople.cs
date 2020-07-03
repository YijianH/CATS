using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace COVID19.Forms.AdminChild
{
    public partial class actpeople : Form
    {
        public actpeople()
        {
            InitializeComponent();
        }

        private void actpeople_Load(object sender, EventArgs e)
        {
            this.actpDate.CustomFormat = "yyyy-MM-dd";
            this.actpDate.Format = DateTimePickerFormat.Custom;
        }

        private void Exec_SQL(string sql)
        {
            MYSQL mYSQL = new MYSQL();
            MySqlConnection conn = mYSQL.Connection();

            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            string id = actpID.Text;
            string name = actpName.Text;
            string sex = actpSex.Text;
            string hs = actpState.Text;
            string st = actpDate.Text;

            string sql;
            if (hs == "Health")
            {
                sql = string.Format("INSERT INTO Person VALUES('{0}', '{1}', '{2}', '{3}', NULL);", id, name, sex, hs);
            }
            else
            {
                sql = string.Format("INSERT INTO Person VALUES('{0}', '{1}', '{2}', '{3}', '{4}');", id, name, sex, hs, st);
            }

            Exec_SQL(sql);
            
            sql = string.Format("SELECT * FROM Person WHERE Pid = '{0}';", id);
            MYSQL mYSQL = new MYSQL();
            DataTable table = mYSQL.GetMessage(sql);
            actpTable.DataSource = table;

            MessageBox.Show("Add Done!");
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            string id = actpID.Text;
            string sql = string.Format("DELETE FROM Person WHERE Pid = '{0}';", id);
            Exec_SQL(sql);
            
            sql = string.Format("SELECT * FROM Person WHERE Pid = '{0}';", id);
            MYSQL mYSQL = new MYSQL();
            DataTable table = mYSQL.GetMessage(sql);
            actpTable.DataSource = table;

            MessageBox.Show("Delete Done!");
        }

        private void modify_Click(object sender, EventArgs e)
        {
            string id = actpID.Text;
            string name = actpName.Text;
            string sex = actpSex.Text;
            string hs = actpState.Text;
            string st = actpDate.Text;

            string sql;
            if (hs == "Health")
            {
                sql = string.Format("UPDATE HealthStatus = '{0}', SickTime = NULL FROM Person WHERE Pid = '{1}';", hs, id);
            }
            else
            {   //update 的sql语句居然写错了。。。。
                sql = string.Format("UPDATE Person SET HealthStatus = '{0}', SickTime = '{1}' WHERE Pid = '{2}';", hs, st, id);
            }

            Exec_SQL(sql);

            sql = string.Format("SELECT * FROM Person WHERE Pid = '{0}';", id);
            MYSQL mYSQL = new MYSQL();
            DataTable table = mYSQL.GetMessage(sql);
            actpTable.DataSource = table;

            MessageBox.Show("Update Done!");
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            MYSQL mYSQL = new MYSQL();

            string sql = "SELECT * FROM Person;";
            DataTable table = mYSQL.GetMessage(sql);

            actpTable.DataSource = table;
        }

        private void actpID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
