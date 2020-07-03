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
    public partial class admindex : Form
    {
        public admindex()
        {
            InitializeComponent();
        }

        private void admindex_Load(object sender, EventArgs e)
        {
            AdminIndexTable.Enabled = false;
            AdminIndexTable.Visible = false;
            
            MYSQL mYSQL = new MYSQL();
            MySqlConnection conn = mYSQL.Connection();
            conn.Open();
            string [] sql = { "SELECT COUNT(*) Num FROM Person WHERE HealthStatus = 'Sick';", 
                              "SELECT COUNT(*) Num FROM Person WHERE HealthStatus = 'Fever';",
                              "SELECT COUNT(*) Num FROM Situation WHERE RiskLevel = 'L1';",
                              "SELECT COUNT(*) Num FROM Login WHERE Type = 'Admin';"
                               };
            string[] res = new string[4];
            for (int i = 0;i < 4;i++)
            {
                MySqlCommand cmd = new MySqlCommand(sql[i], conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                res[i] = dataSet.Tables[0].Rows[0]["Num"].ToString();
            }

            conn.Close();
            ConfirmedCases.Text += res[0];
            LikelyInfection.Text += res[1];
            HighRiskArea.Text += res[2];
            AdminCounts.Text += res[3];
            
        }
        private bool state = true;
        private void ConfirmedCases_Click(object sender, EventArgs e)
        {
            if (state)
            {
                AdminIndexTable.Enabled = true;
                AdminIndexTable.Visible = true;
                MYSQL mYSQL = new MYSQL();

                string sql = "SELECT Pname, HealthStatus, SickTime FROM Person WHERE HealthStatus = 'Sick' LIMIT 0, 10;";
                DataTable dataTable = mYSQL.GetMessage(sql);
                AdminIndexTable.DataSource = dataTable;
            }
            else
            {
                AdminIndexTable.Enabled = false;
                AdminIndexTable.Visible = false;
            }
            state = !state;

            
        }

        private void LikelyInfection_Click(object sender, EventArgs e)
        {
            if (state)
            {
                AdminIndexTable.Enabled = true;
                AdminIndexTable.Visible = true;
                MYSQL mYSQL = new MYSQL();
                string sql = "SELECT Pname, HealthStatus, SickTime FROM Person WHERE HealthStatus = 'Fever' LIMIT 0, 10;";
                DataTable dataTable = mYSQL.GetMessage(sql);
                AdminIndexTable.DataSource = dataTable;
            }
            else
            {
                AdminIndexTable.Enabled = false;
                AdminIndexTable.Visible = false;
            }
            state = !state;
        }

        private void HighRiskArea_Click(object sender, EventArgs e)
        {
            if (state)
            {
                AdminIndexTable.Enabled = true;
                AdminIndexTable.Visible = true;
                MYSQL mYSQL = new MYSQL();
                string sql = "SELECT City, Area, RiskLevel FROM Situation WHERE RiskLevel = 'L1';";
                DataTable dataTable = mYSQL.GetMessage(sql);
                AdminIndexTable.DataSource = dataTable;
            }
            else
            {
                AdminIndexTable.Enabled = false;
                AdminIndexTable.Visible = false;
            }

            state = !state;
        }

        private void AdminCounts_Click(object sender, EventArgs e)
        {
            if (state)
            {
                AdminIndexTable.Enabled = true;
                AdminIndexTable.Visible = true;
                MYSQL mYSQL = new MYSQL();
                string sql = "SELECT Account, Name FROM Login WHERE Type = 'Admin';";

                DataTable dataTable = mYSQL.GetMessage(sql);
                AdminIndexTable.DataSource = dataTable;
            }
            else
            {
                AdminIndexTable.Enabled = false;
                AdminIndexTable.Visible = false;
            }
            state = !state;
        }
    }
}
