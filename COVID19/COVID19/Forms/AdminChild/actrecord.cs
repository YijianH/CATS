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
    public partial class actrecord : Form
    {
        public actrecord()
        {
            InitializeComponent();
        }

        private void actrecord_Load(object sender, EventArgs e)
        {
            this.Ast.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.Ast.Format = DateTimePickerFormat.Custom;
            this.Aet.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.Aet.Format = DateTimePickerFormat.Custom;
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
            string id = actID.Text;
            string city = actCity.Text;
            string area = actArea.Text;
            string st = Ast.Text;
            string et = Aet.Text;

            string sql = string.Format("INSERT INTO Record VALUES('{0}', '{1}', '{2}', '{3}', '{4}');", id, city, area, st, et);
            Exec_SQL(sql);

            sql = string.Format("SELECT * FROM Record WHERE Pid = '{0}' AND City = '{1}' AND Area = '{2}' AND StartTime >= '{3}' AND EndTime <= '{4}'; ", id, city, area, st, et);
            MYSQL mYSQL = new MYSQL();
            DataTable table = mYSQL.GetMessage(sql);
            ActRecordTable.DataSource = table;

            MessageBox.Show("Add Done!");
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            string id = actID.Text;
            string city = actCity.Text;
            string area = actArea.Text;
            string st = Ast.Text;
            string et = Aet.Text;

            string sql = string.Format("DELETE FROM Record WHERE Pid = '{0}' AND City = '{1}' AND Area = '{2}' AND StartTime >= '{3}' AND EndTime <= '{4}';", id, city, area, st, et);
            Exec_SQL(sql);

            sql = string.Format("SELECT * FROM Record WHERE Pid = '{0}' AND City = '{1}' AND Area = '{2}' AND StartTime >= '{3}' AND EndTime <= '{4}'; ", id, city, area, st, et);
            MYSQL mYSQL = new MYSQL();
            DataTable table = mYSQL.GetMessage(sql);
            ActRecordTable.DataSource = table;

            MessageBox.Show("Delete Done!");
        }

        private void modify_Click(object sender, EventArgs e)
        {
            //怎么实现全码的更改?
            string id = actID.Text;
            string city = actCity.Text;
            string area = actArea.Text;
            string st = Ast.Text;
            string et = Aet.Text;

            //string sql = string.Format("UPDATE Record WHERE Pid = '{0}' AND City = '{1}' AND Area = '{2}' AND StartTime = '{3}' AND EndTime = '{4}';", id, city, area, st, et);
            string sql = string.Format("INSERT INTO Record VALUES('{0}', '{1}', '{2}', '{3}', '{4}');", id, city, area, st, et);
            Exec_SQL(sql);

            sql = string.Format("SELECT * FROM Record WHERE Pid = '{0}' AND City = '{1}' AND Area = '{2}' AND StartTime >= '{3}' AND EndTime <= '{4}'; ", id, city, area, st, et);
            MYSQL mYSQL = new MYSQL();
            DataTable table = mYSQL.GetMessage(sql);
            ActRecordTable.DataSource = table;

            MessageBox.Show("Update Done!");
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            MYSQL mYSQL = new MYSQL();

            string sql = "SELECT * FROM Record";
            DataTable table = mYSQL.GetMessage(sql);
            ActRecordTable.DataSource = table;
        }
    }
}
