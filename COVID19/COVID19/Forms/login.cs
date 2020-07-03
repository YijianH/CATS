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

namespace COVID19.Forms
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            boot bt = new boot();
            bt.ShowDialog();
        }
        
        //登陆
        private void button1_Click(object sender, EventArgs e)
        {
            
            string account = textBox1.Text;
            string type = loginType.Text;
            string passwd = textBox2.Text;
            MYSQL mYSQL = new MYSQL();
            MySqlConnection conn = mYSQL.Connection();
            conn.Open();

            string sql = string.Format("SELECT * FROM Login WHERE Account='{0}' AND Passwd='{1}';", account, passwd);
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            object result = cmd.ExecuteScalar();
            if (result != null)
            {
                if (type == "User")
                {
                    user user = new user();
                    this.Dispose();
                    user.ShowDialog();
                }
                else if (type == "Admin")
                {
                    admin admin = new admin();
                    this.Dispose();
                    admin.ShowDialog();
                }
                else
                {
                    MessageBox.Show("请选择账户类型！");
                }
            }
            else
            {
                MessageBox.Show("账号或密码错误，请重新输入!");
            }    
            conn.Close();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            register register = new register();
            this.Dispose();
            register.ShowDialog();
        }
    }
}
