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
    public partial class crystalform1 : Form
    {
        public crystalform1()
        {
            InitializeComponent();
        }

        private void crystalform1_Load(object sender, EventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string cs = "Data Source=DESKTOP-MILEE7; Initial Catalog=education; Integrated Security=True";
            SqlConnection conn = new SqlConnection(cs);

            conn.Open();

            string sql = "SELECT * FROM View WHERE emp_ID=@emp";
            SqlCommand comm = new SqlCommand(sql, conn);
            comm.Parameters.AddWithValue("@emp", this.txt_emp.Text);

            SqlDataAdapter dap = new SqlDataAdapter(comm);
            DataSet ds = new DataSet();
            dap.Fill(ds);

            salaryReport rpt = new salaryReport();
            rpt.Load(@"C:\Users\amc trading sharjah\Documents\GAD\finalproject\finalproject\salaryReport.rpt");
            rpt.SetDataSource(ds.Tables[0]);
            this.crystalReportViewer1.ReportSource = rpt;

            conn.Close();
 
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            string cs = "Data Source=DESKTOP-MILEE7; Initial Catalog=education; Integrated Security=True";
            SqlConnection conn = new SqlConnection(cs);

            conn.Open();

            string sql = "SELECT * FROM View";
            SqlCommand comm = new SqlCommand(sql, conn);

            salaryReport rpt = new salaryReport();
            rpt.Load(@"C:\Users\amc trading sharjah\Documents\GAD\finalproject\finalproject\salaryReport.rpt");

            this.crystalReportViewer1.ReportSource = rpt;

            conn.Close();
        }
    }
}
