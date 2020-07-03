using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COVID19.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace COVID19
{
    public partial class boot : Form
    {
        public boot()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //this.button1.BackColor = Color.FromArgb(53, 66, 83);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            login fd = new login();
            fd.ShowDialog();
            Application.ExitThread(); //登陆界面后进入的界面会消失
        
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            service fd = new service();
            this.Hide();
            fd.ShowDialog();
            this.Dispose();
        }

    }
    public partial class MYSQL
    {
        //声明一个连接对象
        //public MySqlConnection Conn; 
        //返回一个连接对象
        public MySqlConnection Connection()
        {
            MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder
            {
                Server = "192.168.119.152",
                Port = 3306,
                Database = "COVID19",
                UserID = "root",
                Password = "mysql"
            };
            MySqlConnection conn = new MySqlConnection(sb.ConnectionString);//实例化连接
            return conn;
        }
        //
        public DataTable GetMessage(String sql)
        {
            MySqlConnection conn = Connection();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            conn.Close();
            return table;
        }
        
        //便民查询
        public object ConvientService()
        {
            object result = new Object();
            return result;
        }
    }
}
