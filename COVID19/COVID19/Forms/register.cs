using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COVID19.Forms
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            login login = new login();
            this.Dispose();
            login.ShowDialog();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            string ac = account.Text;
            string passwd = password.Text;
            string rep = repasswd.Text;
            if (passwd == rep)
            {
                MYSQL mYSQL = new MYSQL();

                MySqlConnection conn = mYSQL.Connection();
                conn.Open();
                string sql = string.Format("INSERT INTO Login VALUES('{0}', 'kkk', '{1}', 'User');", ac, passwd);
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();

                MessageBox.Show("注册成功，即将返回登陆界面...");
                login login = new login();
                this.Dispose();
                login.ShowDialog();
            }
            else
            {
                MessageBox.Show("密码不一致，请重新输入！");
            }
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            password.UseSystemPasswordChar = true;
        }

        private void repasswd_TextChanged(object sender, EventArgs e)
        {
            repasswd.UseSystemPasswordChar = true;
        }
    }
}
