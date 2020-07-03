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
    public partial class userLoginManage : Form
    {
        public userLoginManage()
        {
            InitializeComponent();
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
        private void Modify_Click(object sender, EventArgs e)
        {
            string account = userAccount.Text;
            string username = userName.Text;
            //string actype = accountType.Text; //账户升级
            string sql = string.Format("UPDATE Login SET Name = '{0}' WHERE Account = '{1}';", username, account);
            Exec_SQL(sql);
            MessageBox.Show("Update Done!");
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            string account = userAccount.Text;
            //if(account.Length == 0)
            string sql = string.Format("DELETE FROM Login WHERE Account = '{0}';", account);
            Exec_SQL(sql);
            MessageBox.Show("Delete Done!");
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            MYSQL mYSQL = new MYSQL();
            string sql = "SELECT Account, Name FROM Login WHERE Type = 'User';";
            DataTable dataTable = mYSQL.GetMessage(sql);
            userTable.DataSource = dataTable;
        }
    }
}
