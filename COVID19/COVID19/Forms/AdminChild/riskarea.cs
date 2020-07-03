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
using Org.BouncyCastle.Asn1.Cms;

namespace COVID19.Forms.AdminChild
{
    public partial class riskarea : Form
    {
        public riskarea()
        {
            InitializeComponent();
        }

        private int Exec_SQL(string sql)
        {
            
            MYSQL mYSQL = new MYSQL();
            MySqlConnection conn = mYSQL.Connection();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            int res = cmd.ExecuteNonQuery();
            conn.Close();
            return res;
        }
        private void add_Click(object sender, EventArgs e)
        {
            string city = City.Text;
            string area = Area.Text;
            string risklevel = riskLevel.Text;

            string sql = string.Format("INSERT INTO Situation VALUES('{0}', '{1}', '{2}');", city, area, risklevel);
            if (Exec_SQL(sql) != -1)
                MessageBox.Show("Add Done!");
            else 
                MessageBox.Show("Add Fail, Try Again!");
            
        }

        private void delete_Click(object sender, EventArgs e)
        {
            string city = City.Text;
            string area = Area.Text;
            //string risklevel = riskLevel.Text;

            string sql = string.Format("DELETE FROM Situation WHERE City = '{0}' AND Area = '{1}';", city, area);
            Exec_SQL(sql);
            MessageBox.Show("Delete Done!");

        }

        private void modify_Click(object sender, EventArgs e)
        {
            string city = City.Text;
            string area = Area.Text;
            string risklevel = riskLevel.Text;

            string sql = string.Format("UPDATE Situation SET RiskLevel = '{0}' WHERE City = '{1}' AND Area = '{2}';", risklevel, city, area);
            Exec_SQL(sql);
            MessageBox.Show("Update Done!");
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            MYSQL mYSQL = new MYSQL();

            string sql = "SELECT * FROM Situation;";
            DataTable table = mYSQL.GetMessage(sql);
            riskAreatable.DataSource = table;

        }
    }
}
