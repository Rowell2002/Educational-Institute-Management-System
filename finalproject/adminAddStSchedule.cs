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
    public partial class adminAddStSchedule : Form
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
        public adminAddStSchedule()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string cs = @"Data Source= DESKTOP-MILEE7; Initial Catalog= education; Integrated Security=True";

            SqlConnection conn = new SqlConnection(cs);

            conn.Open();

            try
            {
                if (this.txt_stID.Text == "")
                {
                    MessageBox.Show("Require student ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else if (this.dtp_date.Text == "")
                {
                    MessageBox.Show("Require date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else if (this.txt_fname.Text == "")
                {
                    MessageBox.Show("Require student first name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (this.txt_lname.Text == "")
                {
                    MessageBox.Show("Require student last name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else if (this.txt_startTime.Text == "")
                {
                    MessageBox.Show("Require class start time", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else if (this.txt_endTime.Text == "")
                {
                    MessageBox.Show("Require class end time", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (this.txt_sub.Text == "")
                {
                    MessageBox.Show("Require subject", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else
                {
                    string sql = "INSERT INTO stClsSchedule_tbl (st_ID,fname,lname,date,startTime,endTime,subjects) VALUES(@stid,@fname,@lname,@date,@stime,@etime,@sub)";
                    SqlCommand command = new SqlCommand(sql, conn);
                    command.Parameters.AddWithValue("@stid", this.txt_stID.Text);
                    command.Parameters.AddWithValue("@fname", this.txt_fname.Text);
                    command.Parameters.AddWithValue("@lname", this.txt_lname.Text);
                    command.Parameters.AddWithValue("@date", Convert.ToDateTime(this.dtp_date.Text));
                    command.Parameters.AddWithValue("@stime", Convert.ToDateTime(this.txt_startTime.Text));
                    command.Parameters.AddWithValue("@etime", Convert.ToDateTime(this.txt_endTime.Text));
                    command.Parameters.AddWithValue("@sub", this.txt_sub.Text);
                    command.Parameters.AddWithValue("@grade", this.txt_grade.Text);

                    int ret = command.ExecuteNonQuery();
                    MessageBox.Show("No of records inserted:" + ret, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    txt_stID.Clear();
                    txt_fname.Clear();
                    txt_lname.Clear();
                    txt_startTime.Clear();
                    txt_endTime.Clear();
                    txt_grade.Clear();
                    txt_sub.Clear();
                   

                    /*txt_fname.Text = "First Name";
                    txt_fname.ForeColor = Color.Silver;
                    txt_lname.Text = "Last Name";
                    txt_lname.ForeColor = Color.Silver;
                    txt_email.Text = "example@gmail.com";
                    txt_email.ForeColor = Color.Silver;*/

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

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private void pictureBox1_Click(object sender, EventArgs e)
        //{
        //    adminClsSchedule c1 = new adminClsSchedule();
        //    c1.Show();
        //    this.Close();
        //}

        private void adminAddStSchedule_Load(object sender, EventArgs e)
        {
            btn_add.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_add.Width, btn_add.Height, 20, 20));
            btn_cancel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_cancel.Width, btn_cancel.Height, 20, 20));
            txt_stID.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_stID.Width, txt_stID.Height, 20, 20));
            dtp_date.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, dtp_date.Width, dtp_date.Height, 20, 20));
            txt_fname.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_fname.Width, txt_fname.Height, 20, 20));
            txt_lname.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_lname.Width, txt_lname.Height, 20, 20));
            txt_startTime.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_startTime.Width, txt_startTime.Height, 20, 20));
            txt_endTime.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_endTime.Width, txt_endTime.Height, 20, 20));
            txt_grade.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_grade.Width, txt_grade.Height, 20, 20));
            txt_sub.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_sub.Width, txt_sub.Height, 20, 20));

        }

        

        //private void pictureBox1_Click_1(object sender, EventArgs e)
        //{
        //    adminClsSchedule c1 = new adminClsSchedule();
        //    c1.Show();
        //    this.Close();
        //}
    }
}
