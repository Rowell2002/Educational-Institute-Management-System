using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalproject
{
    public partial class stMarksForm : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
      (
          int nLeftRect,     // x-coordinate of upper-left corner
          int nTopRect,      // y-coordinate of upper-left corner
          int nRightRect,    // x-coordinate of lower-right corner
          int nBottomRect,   // y-coordinate of lower-right corner
          int nWidthEllipse, // width of ellipse
          int nHeightEllipse // height of ellipse
      );
        public stMarksForm()
        {
            InitializeComponent();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                string cs = "Data Source=DESKTOP-MILEE7; Initial Catalog=education; Integrated Security=True";
                SqlConnection conn = new SqlConnection(cs);

                conn.Open();

                string sql = "SELECT student_id,class,exam_name,marks,grade FROM result_tbl WHERE student_id=@stid";
                SqlCommand comm = new SqlCommand(sql, conn);
                comm.Parameters.AddWithValue("@stid", this.txt_sid.Text);

                SqlDataAdapter dap = new SqlDataAdapter(comm);
                DataSet ds = new DataSet();
                dap.Fill(ds);

                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    stMarks rpt = new stMarks();
                    rpt.Load(@"C:\Users\amc trading sharjah\Documents\GAD\finalproject\finalproject\stMarks.rpt");
                    rpt.SetDataSource(ds.Tables[0]);
                    this.crystalReportViewer1.ReportSource = rpt;
                }
                else
                {
                    MessageBox.Show("No records found for the given student ID.", "No Records", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                conn.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void stMarksForm_Load(object sender, EventArgs e)
        {

            btn_search.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_search.Width, btn_search.Height, 20, 20));
            txt_sid.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_sid.Width, txt_sid.Height, 20, 20));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
