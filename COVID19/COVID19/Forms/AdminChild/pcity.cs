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
    public partial class pcity : Form
    {
        public pcity()
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

        private void Add_Click(object sender, EventArgs e)
        {
            string city = City.Text;
            string proregion = ProRegion.Text;

            string sql = string.Format("INSERT INTO Map VALUES('{0}', '{1}');", city, proregion);
            Exec_SQL(sql);
            MessageBox.Show("Add Done!");
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            MYSQL mYSQL = new MYSQL();

            string sql = "SELECT * FROM Map;";
            DataTable table = mYSQL.GetMessage(sql);
            ProRegiontable.DataSource = table;
        }
    }
}
