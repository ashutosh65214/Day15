using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day15
{
    public partial class Form1 : Form
    {
        private SqlConnection con = null;
        private SqlDataAdapter adapter = null;
        private DataSet ds = null;

        public Form1()
        {
            InitializeComponent();
        }
        private void RefreshTable()
        {
            using (con = new SqlConnection(ConfigurationManager.ConnectionStrings["HRSQL"].ConnectionString))
            {
                using (adapter = new SqlDataAdapter("Select * from Department", con))
                {
                    ds = new DataSet();
                    adapter.Fill(ds, "Department");
                    GridDepartment.DataSource = ds.Tables["Department"];
                }
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            using (con = new SqlConnection(ConfigurationManager.ConnectionStrings["HRSQL"].ConnectionString))
            {
                using (adapter = new SqlDataAdapter("Select * from Department", con))
                {
                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);//This is will generate Insert, Update or Delete Command
                    ds = new DataSet();
                    adapter.Fill(ds, "Department");
                    //Create new row in the dataset
                    DataRow dr = ds.Tables["Department"].NewRow();
                    dr["cDepartmentCode"] = TxtDepartCode.Text;
                    dr["vDepartmentName"] = TxtDepartName.Text;
                    dr["vDepartmentHead"] = TxtDepartHead.Text;
                    dr["vLocation"] = TxtLocation.Text;
                    //Add data row to dataset
                    ds.Tables["Department"].Rows.Add(dr);
                    //Updating Dataset to Database
                    adapter.Update(ds, "Department");
                }
            }

        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            this.RefreshTable();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.RefreshTable();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            using (con = new SqlConnection(ConfigurationManager.ConnectionStrings["HRSQL"].ConnectionString))
            {
                using (adapter = new SqlDataAdapter("Select * from Department", con))
                {
                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);//This is will generate Insert, Update or Delete Command
                    ds = new DataSet();
                    adapter.Fill(ds, "Department");

                    //Applying Primary key
                    DataColumn[] dc = new DataColumn[1];
                    dc[0] = ds.Tables["Department"].Columns["cDepartmentCode"];
                    ds.Tables["Department"].PrimaryKey = dc;

                    //Find the Department Code from Dataset
                    DataRow dr = ds.Tables["Department"].Rows.Find(TxtDepartCode.Text);

                    //Delete the row 
                    //ds.Tables["Department"].Rows.Remove(dr);
                    dr.Delete();//Removing row using DataRow object

                    //update Dataset to Database
                    adapter.Update(ds, "Department");
                    adapter.Fill(ds, "Department");
                }
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            using (con = new SqlConnection(ConfigurationManager.ConnectionStrings["HRSQL"].ConnectionString))
            {
                using (adapter = new SqlDataAdapter("Select * from Department", con))
                {
                    ds = new DataSet();
                    adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                    adapter.Fill(ds, "Department");
                    SqlCommandBuilder obj =
                        new SqlCommandBuilder(adapter);
                    DataRow dr = ds.Tables[0].Rows.Find(TxtDepartCode.Text);
                    dr["vDepartmentName"] = TxtDepartName.Text;
                    dr["vDepartmentHead"] = TxtDepartHead.Text;
                    dr["vLocation"] = TxtLocation.Text;
                    adapter.Update(ds, "Department");
                    MessageBox.Show("Updated");
                    GridDepartment.DataSource = ds.Tables["Department"];
                }
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
