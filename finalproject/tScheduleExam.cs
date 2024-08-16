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

    public partial class tScheduleExam : Form
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
        public tScheduleExam()
        {
            InitializeComponent();
        }

        private void tScheduleExam_Load(object sender, EventArgs e)
        {
            btn_save.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_save.Width, btn_save.Height, 20, 20));
            btn_cancel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_cancel.Width, btn_cancel.Height, 20, 20));
            txt_refno.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_refno.Width, txt_refno.Height, 20, 20));
            txt_sub.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_sub.Width, txt_sub.Height, 20, 20));
            txt_ename.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_ename.Width, txt_ename.Height, 20, 20));
            txt_stime.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_stime.Width, txt_stime.Height, 20, 20));
            txt_grade.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_grade.Width, txt_grade.Height, 20, 20));
            txt_etime.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_etime.Width, txt_etime.Height, 20, 20));
            dtp_edate.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, dtp_edate.Width, dtp_edate.Height, 20, 20));
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string cs = @"Data Source= DESKTOP-MILEE7; Initial Catalog= education; Integrated Security=True";

            SqlConnection conn = new SqlConnection(cs);

            conn.Open();
            try
            {
                if (this.txt_refno.Text == "")
                {
                    MessageBox.Show("Require Exam Reference Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else if (this.txt_ename.Text == "")
                {
                    MessageBox.Show("Require Exam Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else if (this.txt_sub.Text == "")
                {
                    MessageBox.Show("Require Subject", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else if (this.txt_grade.Text == "")
                {
                    MessageBox.Show("Require Grade", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else if (this.txt_stime.Text == "")
                {
                    MessageBox.Show("Require Exam Start Time", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else if (!TimeSpan.TryParse(txt_stime.Text, out TimeSpan startTime))
                {
                    MessageBox.Show("Require Exam End Time", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else if (!TimeSpan.TryParse(txt_etime.Text, out TimeSpan endTime))
                {
                    MessageBox.Show("Require Exam Date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else
                {
                    string sql = "INSERT INTO stOnlineExm_tbl (exam_ref,exam_name,subject,grade,exam_date,exam_StartTime,exam_EndTime) VALUES(@ref,@ename,@sub,@grd,@edate,@esTime,@eeTime)";
                    SqlCommand command = new SqlCommand(sql, conn);

                    //TimeSpan timeSpan = TimeSpan.TryParseExact(dtp_edate.Text);
                    DateTime examDate = dtp_edate.Value;

                    command.Parameters.AddWithValue("@ref", this.txt_refno.Text);
                    command.Parameters.AddWithValue("@ename", this.txt_ename.Text);
                    command.Parameters.AddWithValue("@sub", this.txt_sub.Text);
                    command.Parameters.AddWithValue("@grd", this.txt_grade.Text);
                    command.Parameters.AddWithValue("@edate", examDate);
                    command.Parameters.AddWithValue("@esTime", startTime);
                    command.Parameters.AddWithValue("@eeTime", endTime);


                    int ret = command.ExecuteNonQuery();
                    MessageBox.Show("No of records inserted:" + ret, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txt_refno.Clear();
                    txt_ename.Clear();
                    txt_sub.Clear();
                    txt_grade.Clear();
                    txt_stime.Clear();
                    txt_etime.Clear();
                }
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            finally
            {
                conn.Close();
            }
        }
    }
}
