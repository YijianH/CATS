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
    public partial class rsearch : Form
    {
        public rsearch()
        {
            InitializeComponent();
        }

        private void rsearch_Load(object sender, EventArgs e)
        {
            this.searchSt.Enabled = false;
            this.searchEt.Enabled = false;
            this.searchSt.Visible = false;
            this.searchEt.Visible = false;
            this.searchSt.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.searchSt.Format = DateTimePickerFormat.Custom;
            this.searchEt.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.searchEt.Format = DateTimePickerFormat.Custom;
            this.label1.Visible = false;
            this.search.Location = new System.Drawing.Point(200, 100);
        }

        private void searchType_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchTable.DataSource = null;

            if (searchType.Text == "地点-时间段")
            {
                searchCondition.Clear();
                searchSt.Enabled = true;
                searchEt.Enabled = true;
                searchSt.Visible = true;
                searchEt.Visible = true;
                searchCondition.Enabled = true;
                searchCondition.Visible = true;
                search.Location = new System.Drawing.Point(400, 150);
            }
            else
            {
                searchCondition.Clear();
                searchCondition.Enabled = true;
                searchCondition.Visible = true;
                searchSt.Enabled = false;
                searchEt.Enabled = false;
                searchSt.Visible = false;
                searchEt.Visible = false;
                search.Location = new System.Drawing.Point(200, 100);
            }
        }

        private bool EmptyTable(DataTable dataTable)
        {
            if (dataTable.Rows.Count > 0)
            {
                return false;
            }
            MessageBox.Show("无相关记录！");
            return true;
        }
        private void search_Click(object sender, EventArgs e)
        {
            MYSQL mYSQL = new MYSQL();
            string name;
            string cityArea;
            string st, et;
            string sql;

            if (searchType.Text == "姓名")
            {
                name = searchCondition.Text;//另外显示该人的信息
                sql = string.Format("SELECT City, Area, StartTime, EndTime FROM Person, Record " +
                    "WHERE Person.Pid = Record.Pid AND Person.Pname = '{0}' ORDER BY(StartTime);", name);

                DataTable dataTable = mYSQL.GetMessage(sql);
                if (!EmptyTable(dataTable))
                    searchTable.DataSource = dataTable;
            }
            else if (searchType.Text == "地点(城市-区域)")
            {
                cityArea = searchCondition.Text;
                string[] array1 = cityArea.Split('-'); //另外显示该区域的情况
                sql = string.Format("SELECT Pname, HealthStatus, StartTime, EndTime FROM Person, Record " +
                    "WHERE Person.Pid = Record.Pid AND City = '{0}' AND Area = '{1}';", array1[0], array1[1]);//

                DataTable dataTable = mYSQL.GetMessage(sql);
                if (!EmptyTable(dataTable))
                    searchTable.DataSource = dataTable;
            }
            else if (searchType.Text == "地点-时间段")
            {
                cityArea = searchCondition.Text;
                st = searchSt.Text;
                et = searchEt.Text;
                string[] array2 = cityArea.Split('-');

                sql = string.Format("SELECT Pname, HealthStatus, StartTime, EndTime FROM Person, Record " +
                    "WHERE Person.Pid = Record.Pid AND City = '{0}' AND Area = '{1}' " +
                    "AND StartTime >= '{2}' AND EndTime <= '{3}';", array2[0], array2[1], st, et);

                DataTable dataTable = mYSQL.GetMessage(sql);
                if (!EmptyTable(dataTable))
                    searchTable.DataSource = dataTable;
            }
            else
            {
                MessageBox.Show("请选择查询关键字！");
            }
        }
    }
}
