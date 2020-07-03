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
    public partial class service : Form
    {
        public service()
        {
            InitializeComponent();
        }

        private void service_Load(object sender, EventArgs e)
        {
            this.Sst.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.Sst.Format = DateTimePickerFormat.Custom;
            this.Set.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.Set.Format = DateTimePickerFormat.Custom;
            //this.Sst.ShowUpDown = true;
            //this.Sst.ShowUpDown = true;
        }

        public bool Is_sick(MYSQL mYSQL, string id)
        {
            string sql = string.Format("SELECT * FROM Patient WHERE Pid = '{0}';", id);
            DataTable table = mYSQL.GetMessage(sql);

            if (table.Rows.Count > 0)
            {
                 Stable.DataSource = table;
                 return true;
            } 
            else
                return false;
        }

        public bool Is_fever(MYSQL mYSQL, string id)
        {
            string sql = string.Format("SELECT * FROM Fever WHERE Pid = '{0}';", id);
            DataTable table = mYSQL.GetMessage(sql);

            if (table.Rows.Count > 0)
            {
                Stable.DataSource = table;
                return true;
            }
            else
                return false;
        }

        public bool Is_likely(MYSQL mYSQL, string city, string area, string st, string et) //看是否有与确诊病例接触的可能
        {
            string sql = string.Format("SELECT Pname, City, Area, StartTime, EndTime, SickTime FROM Patient_Record WHERE City = '{0}' AND Area = '{1}' AND StartTime <= '{2}' AND EndTime > '{3}';", city, area, st, st);
            DataTable table = mYSQL.GetMessage(sql);

            if (table.Rows.Count > 0)
            {
                Stable.DataSource = table;
                return true;
            }
            else
                return false;
        }
        //bool state = true;
        public void ConService()
        {
            string id = SID.Text;
            string city = Scity.Text;
            string area = Sarea.Text;
            string st = Sst.Text;
            string et = Set.Text;
            MYSQL mYSQL = new MYSQL();
            //string sql = string.Format("SELECT * FROM Patient_Record WHERE City = '{0}' AND Area = '{1}';", city, area);

            if (Is_sick(mYSQL, id))
            {
                MessageBox.Show("你已确诊，请积极配合治疗，祝早日康复！");
                //Stable.DataSource = null;
            }
            else if (Is_fever(mYSQL, id))
            {
                MessageBox.Show("你有发热迹象，请及时到医院检查！");
                //Stable.DataSource = null;
            }
            else if (Is_likely(mYSQL, city, area, st, st))
            {
                MessageBox.Show("你与确诊者近期存在疑似接触，请及时到医院进行核酸检测！");
                //Stable.DataSource = null;
            }
            else
            {
                Stable.DataSource = null;
                MessageBox.Show("暂无查询结果，请做好自我防护！");
            }

            //DataTable table = mYSQL.GetMessage(sql);
            //Stable.DataSource = table;
            //conn.Close();
        }

        private void Ssearch_Click(object sender, EventArgs e)
        {
            ConService();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            boot boot = new boot();
            this.Dispose();
            boot.ShowDialog();
        }
    }
}
