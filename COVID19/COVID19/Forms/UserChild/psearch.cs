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
    public partial class psearch : Form
    {
        public psearch()
        {
            InitializeComponent();
        }

        private void psearch_Load(object sender, EventArgs e)
        {
            this.psearchDate.CustomFormat = "yyyy-MM-dd";
            this.psearchDate.Format = DateTimePickerFormat.Custom;
            this.psearchDate.Enabled = false;
            this.psearchDate.Visible = false;
        }

        private bool EmptyTable(DataTable dataTable)
        {
            if (dataTable.Rows.Count > 0)
            {
                return false;
            }
            MessageBox.Show("该患者不存在！");
            return true;
        }
        private void Search_Click(object sender, EventArgs e)
        {
            MYSQL mYSQL = new MYSQL();
            string id = searchCondition.Text;
            string name = searchCondition.Text;
            string sicktime = psearchDate.Text;
            string sql;
            DataTable dataTable;
            if (searchType.Text == "身份证号")
            {
                sql = string.Format("SELECT * FROM Patient WHERE Pid = '{0}';", id);
                dataTable = mYSQL.GetMessage(sql);
                if (!EmptyTable(dataTable))
                {
                    psearchTable.DataSource = dataTable;
                }
            }
            else if (searchType.Text == "姓名")
            {
                sql = string.Format("SELECT * FROM Patient WHERE Pname = '{0}';", name);
                dataTable = mYSQL.GetMessage(sql);

                if (!EmptyTable(dataTable))
                {
                    psearchTable.DataSource = dataTable;
                }
            }
            else if (searchType.Text == "确诊时间")
            {
                sql = string.Format("SELECT * FROM Patient WHERE SickTime = '{0}';", sicktime);
                dataTable = mYSQL.GetMessage(sql);
                if (!EmptyTable(dataTable))
                {
                    psearchTable.DataSource = dataTable;
                }
            }
            else
            {
                MessageBox.Show("请选择查询关键字！");
            }
        }

        private void searchType_SelectedIndexChanged(object sender, EventArgs e)
        {
            psearchTable.DataSource = null;
            //用来动态切换查询条件的输入窗口
            if (searchType.Text == "确诊时间")
            {
                psearchDate.Enabled = true;
                psearchDate.Visible = true;
                searchCondition.Enabled = false;
                searchCondition.Visible = false;

            }
            else
            {
                searchCondition.Enabled = true;
                searchCondition.Visible = true;
                psearchDate.Enabled = false;
                psearchDate.Visible = false;
            }
        }
    }
}
