using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalproject
{
    public partial class salaryform : Form
    {
        public salaryform()
        {
            InitializeComponent();
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            try
            {
                string cs = "Data Source=DESKTOP-MILEE7; Initial Catalog=education; Integrated Security=True";
                SqlConnection conn = new SqlConnection(cs);

                conn.Open();

                string sql = "SELECT * FROM report_tbl";
                SqlCommand comm = new SqlCommand(sql, conn);

                yrSalary rpt = new yrSalary();
                rpt.Load(@"C:\Users\amc trading sharjah\Documents\GAD\finalproject\finalproject\yrSalary.rpt");

                this.crystalReportViewer1.ReportSource = rpt;

                conn.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                string cs = "Data Source=DESKTOP-MILEE7; Initial Catalog=education; Integrated Security=True";
                SqlConnection conn = new SqlConnection(cs);

                conn.Open();

                string sql = "SELECT * FROM report_tbl WHERE emp_ID=@eid";
                SqlCommand comm = new SqlCommand(sql, conn);
                comm.Parameters.AddWithValue("@eid", this.txt_eid.Text);

                SqlDataAdapter dap = new SqlDataAdapter(comm);
                DataSet ds = new DataSet();
                dap.Fill(ds);

                yrSalary rpt = new yrSalary();
                rpt.Load(@"C:\Users\amc trading sharjah\Documents\GAD\finalproject\finalproject\yrSalary.rpt");
                rpt.SetDataSource(ds.Tables[0]);
                this.crystalReportViewer1.ReportSource = rpt;

                conn.Close();
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
