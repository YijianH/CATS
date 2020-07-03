using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COVID19.Forms.UserChild
{
    public partial class esearch : Form
    {
        public esearch()
        {
            InitializeComponent();
        }

        private void esearch_Load(object sender, EventArgs e)
        {
            this.searchRiskLevel.Enabled = false;
            this.searchRiskLevel.Visible = false;
        }

        private void searchType_SelectedIndexChanged(object sender, EventArgs e)
        {
            esearchTable.DataSource = null;
            if (searchType.Text == "风险等级")
            {
                searchRiskLevel.Enabled = true;
                searchRiskLevel.Visible = true;
                searchCondition.Enabled = false;
                searchCondition.Visible = false;
               
            }
            else
            {
                searchCondition.Enabled = true;
                searchCondition.Visible = true;
                searchRiskLevel.Enabled = false;
                searchRiskLevel.Visible = false;
            }
        }

        private void search_Click(object sender, EventArgs e)
        {
            MYSQL mYSQL = new MYSQL();
            string sql;
            string province, city, risklevel;

            if (searchType.Text == "省(简称)")
            {
                province = searchCondition.Text;
                sql = string.Format("SELECT Situation.City, Area, RiskLevel FROM Situation, Map WHERE Situation.City = Map.City AND Province = '{0}';", province);
                DataTable dataTable = mYSQL.GetMessage(sql);
                esearchTable.DataSource = dataTable;
            }
            else if (searchType.Text == "城市")
            {
                city = searchCondition.Text;
                sql = string.Format("SELECT * FROM Situation WHERE City = '{0}';", city);
                DataTable dataTable = mYSQL.GetMessage(sql);
                esearchTable.DataSource = dataTable;
            }
            else if (searchType.Text == "风险等级")
            {
                risklevel = searchRiskLevel.Text;
                sql = string.Format("SELECT * FROM Situation WHERE RiskLevel = '{0}';", risklevel);
                DataTable dataTable = mYSQL.GetMessage(sql);
                esearchTable.DataSource = dataTable;
            }
            else
            {
                MessageBox.Show("请选择查询关键字！");
            }
        }
    }
}
