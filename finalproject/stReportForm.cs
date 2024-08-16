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
    public partial class stReportForm : Form
    {
        public stReportForm()
        {
            InitializeComponent();
        }

        private void stReportForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            string cs = "Data Source=DESKTOP-MILEE7; Initial Catalog=education; Integrated Security=True";
            SqlConnection conn = new SqlConnection(cs);

            conn.Open();

            string sql = "SELECT * FROM stAttendance_tbl";
            SqlCommand comm = new SqlCommand(sql, conn);

            sAttend rpt = new sAttend();
            rpt.Load(@"C:\Users\amc trading sharjah\Documents\GAD\finalproject\finalproject\studentAttendance.rpt");

            this.crystalReportViewer1.ReportSource = rpt;

            conn.Close();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string cs = "Data Source=DESKTOP-MILEE7; Initial Catalog=education; Integrated Security=True";
            SqlConnection conn = new SqlConnection(cs);

            conn.Open();

            string sql = "SELECT * FROM stAttendance WHERE student_ID=@stid";
            SqlCommand comm = new SqlCommand(sql, conn);
            comm.Parameters.AddWithValue("@stid", this.txt_sid.Text);

            SqlDataAdapter dap = new SqlDataAdapter(comm);
            DataSet ds = new DataSet();
            dap.Fill(ds);

            sAttend rpt = new sAttend();
            rpt.Load(@"C:\Users\amc trading sharjah\Documents\GAD\finalproject\finalproject\studentAttendance.rpt");
            rpt.SetDataSource(ds.Tables[0]);
            this.crystalReportViewer1.ReportSource = rpt;

            conn.Close();
        }
    }
}
