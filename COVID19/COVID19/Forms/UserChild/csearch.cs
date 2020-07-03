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
    public partial class csearch : Form
    {
        public csearch()
        {
            InitializeComponent();
        }

        private void csearch_Load(object sender, EventArgs e)
        {
            //this.FeverSickTime.CustomFormat = "yyyy-MM-dd";
            //this.FeverSickTime.Format = DateTimePickerFormat.Custom;
        }

        private void searchType_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchTable.DataSource = null;
        }

        private void searchDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchTable.DataSource = null;
        }
        //table
        DataTable rTable, cTable, ptable;

        private void PatientRecord_Click(object sender, EventArgs e)
        {
            searchTable.DataSource = null;
            searchTable.DataSource = rTable;
        }

        private void PotentialCarrier_Click(object sender, EventArgs e)
        {
            searchTable.DataSource = null;
            searchTable.DataSource = ptable;
        }

        private void RelativeRecord_Click(object sender, EventArgs e)
        {
            searchTable.DataSource = null;
            searchTable.DataSource = cTable;
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            string id, name;
            //string fevertime, sicktime;
            string sqlR, sqlC, sqlP;
            MYSQL mYSQL = new MYSQL();

            if (searchType1.Text == "身份证号")
            {
                id = searchCondition.Text;

                if (searchType2.Text == "发热")
                {
                    sqlR = string.Format("SELECT City, Area, StartTime, EndTime FROM Fever_Record " +
                        "WHERE Pid = '{0}' AND EndTime < SickTime ORDER BY(StartTime);", id);

                    sqlC = string.Format("SELECT Pname, HealthStatus, Fever_Patient_Record.City, Fever_Patient_Record.Area, Fever_Patient_Record.StartTime, Fever_Patient_Record.EndTime " +
                        "FROM Fever_Patient_Record, " +
                        "(SELECT Pid, City, Area, StartTime, EndTime " +
                        "FROM Fever_Record " +
                        "WHERE Pid = '{0}' AND EndTime < SickTime" +
                        ")AS R1 " +
                        "WHERE Fever_Patient_Record.Pid <> R1.Pid AND (Fever_Patient_Record.StartTime <= R1.StartTime AND Fever_Patient_Record.EndTime >= R1.EndTime) " +
                        "AND (Fever_Patient_Record.City = R1.City AND Fever_Patient_Record.Area = R1.Area) AND SickTime < R1.EndTime;", id);
                    
                    sqlP = string.Format("SELECT Pname, HealthStatus, Health_Record.City, Health_Record.Area, Health_Record.StartTime, Health_Record.EndTime " +
                        "FROM Health_Record, " +
                        "(SELECT Pid, City, Area, StartTime, EndTime " +
                        "FROM Fever_Record " +
                        "WHERE Pid = '{0}' AND EndTime < SickTime" +
                        ")AS R1 " +
                        "WHERE Health_Record.Pid <> R1.Pid AND (Health_Record.StartTime >= R1.StartTime AND Health_Record.EndTime <= R1.EndTime) " +
                        "AND (Health_Record.City = R1.City AND Health_Record.Area = R1.Area);", id);
                    
                    rTable = mYSQL.GetMessage(sqlR);
                    cTable = mYSQL.GetMessage(sqlC);
                    ptable = mYSQL.GetMessage(sqlP);
                }
                else if (searchType2.Text == "已确诊")
                {
                    sqlR = string.Format("SELECT City, Area, StartTime, EndTime FROM Patient_Record " +
                        "WHERE Pid = '{0}' AND EndTime < SickTime ORDER BY(StartTime);", id);

                    sqlC = string.Format("SELECT Pname, HealthStatus, Fever_Patient_Record.City, Fever_Patient_Record.Area, Fever_Patient_Record.StartTime, Fever_Patient_Record.EndTime " +
                        "FROM Fever_Patient_Record, " +
                        "(SELECT Pid, City, Area, StartTime, EndTime " +
                        "FROM Patient_Record " +
                        "WHERE Pid = '{0}' AND EndTime < SickTime" +
                        ")AS R1 " +
                        "WHERE Fever_Patient_Record.Pid <> R1.Pid AND (Fever_Patient_Record.StartTime <= R1.StartTime AND Fever_Patient_Record.EndTime >= R1.EndTime) " +
                        "AND (Fever_Patient_Record.City = R1.City AND Fever_Patient_Record.Area = R1.Area) AND SickTime < R1.EndTime;", id);

                    sqlP = string.Format("SELECT Pname, HealthStatus, Health_Record.City, Health_Record.Area, Health_Record.StartTime, Health_Record.EndTime " +
                        "FROM Health_Record, " +
                        "(SELECT Pid, City, Area, StartTime, EndTime " +
                        "FROM Patient_Record " +
                        "WHERE Pid = '{0}' AND EndTime < SickTime" +
                        ")AS R1 " +
                        "WHERE Health_Record.Pid <> R1.Pid AND (Health_Record.StartTime >= R1.StartTime AND Health_Record.EndTime <= R1.EndTime) " +
                        "AND (Health_Record.City = R1.City AND Health_Record.Area = R1.Area);", id);
                   
                    rTable = mYSQL.GetMessage(sqlR);
                    cTable = mYSQL.GetMessage(sqlC);
                    ptable = mYSQL.GetMessage(sqlP);
                }
                else
                {
                    MessageBox.Show("请选择查询关键字！");
                }
            }
            else if (searchType1.Text == "姓名")
            {
                name = searchCondition.Text;

                if (searchType2.Text == "发热")
                {
                    sqlR = string.Format("SELECT City, Area, StartTime, EndTime FROM Fever_Record " +
                        "WHERE Pname = '{0}' AND EndTime < SickTime ORDER BY(StartTime);", name);

                    sqlC = string.Format("SELECT Pname, HealthStatus, Fever_Patient_Record.City, Fever_Patient_Record.Area, Fever_Patient_Record.StartTime, Fever_Patient_Record.EndTime " +
                        "FROM Fever_Patient_Record, " +
                        "(SELECT Pid, City, Area, StartTime, EndTime " +
                        "FROM Fever_Record " +
                        "WHERE Pname = '{0}' AND EndTime < SickTime" +
                        ")AS R1 " +
                        "WHERE Fever_Patient_Record.Pid <> R1.Pid AND (Fever_Patient_Record.StartTime <= R1.StartTime AND Fever_Patient_Record.EndTime >= R1.EndTime) " +
                        "AND (Fever_Patient_Record.City = R1.City AND Fever_Patient_Record.Area = R1.Area) AND SickTime < R1.EndTime;", name);

                    sqlP = string.Format("SELECT Pname, HealthStatus, Health_Record.City, Health_Record.Area, Health_Record.StartTime, Health_Record.EndTime " +
                        "FROM Health_Record, " +
                        "(SELECT Pid, City, Area, StartTime, EndTime " +
                        "FROM Fever_Record " +
                        "WHERE Pname = '{0}' AND EndTime < SickTime" +
                        ")AS R1 " +
                        "WHERE Health_Record.Pid <> R1.Pid AND (Health_Record.StartTime >= R1.StartTime AND Health_Record.EndTime <= R1.EndTime) " +
                        "AND (Health_Record.City = R1.City AND Health_Record.Area = R1.Area);", name);

                    rTable = mYSQL.GetMessage(sqlR);
                    cTable = mYSQL.GetMessage(sqlC);
                    ptable = mYSQL.GetMessage(sqlP);
                }
                else if (searchType2.Text == "已确诊")
                {
                    sqlR = string.Format("SELECT City, Area, StartTime, EndTime FROM Patient_Record " +
                        "WHERE Pname = '{0}' AND EndTime < SickTime ORDER BY(StartTime);", name);

                    sqlC = string.Format("SELECT Pname, HealthStatus, Fever_Patient_Record.City, Fever_Patient_Record.Area, Fever_Patient_Record.StartTime, Fever_Patient_Record.EndTime " +
                        "FROM Fever_Patient_Record, " +
                        "(SELECT Pid, City, Area, StartTime, EndTime " +
                        "FROM Patient_Record " +
                        "WHERE Pname = '{0}' AND EndTime < SickTime" +
                        ")AS R1 " +
                        "WHERE Fever_Patient_Record.Pid <> R1.Pid AND (Fever_Patient_Record.StartTime <= R1.StartTime AND Fever_Patient_Record.EndTime >= R1.EndTime) " +
                        "AND (Fever_Patient_Record.City = R1.City AND Fever_Patient_Record.Area = R1.Area) AND SickTime < R1.EndTime;", name);

                    sqlP = string.Format("SELECT Pname, HealthStatus, Health_Record.City, Health_Record.Area, Health_Record.StartTime, Health_Record.EndTime " +
                        "FROM Health_Record, " +
                        "(SELECT Pid, City, Area, StartTime, EndTime " +
                        "FROM Patient_Record " +
                        "WHERE Pname = '{0}' AND EndTime < SickTime" +
                        ")AS R1 " +
                        "WHERE Health_Record.Pid <> R1.Pid AND (Health_Record.StartTime >= R1.StartTime AND Health_Record.EndTime <= R1.EndTime) " +
                        "AND (Health_Record.City = R1.City AND Health_Record.Area = R1.Area);", name);

                    rTable = mYSQL.GetMessage(sqlR);
                    cTable = mYSQL.GetMessage(sqlC);
                    ptable = mYSQL.GetMessage(sqlP);

                }
                else
                {
                    MessageBox.Show("请选择查询关键字！");
                }
            }
            else
            {
                MessageBox.Show("请选择查询关键字！");
            }
        }
    }
}
