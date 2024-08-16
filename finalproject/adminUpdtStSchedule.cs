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
    public partial class adminUpdtStSchedule : Form
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
        public adminUpdtStSchedule()
        {
            InitializeComponent();
        }

        private void adminUpdtStSchedule_Load(object sender, EventArgs e)
        {
            btn_update.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_update.Width, btn_update.Height, 20, 20));
            btn_search.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_search.Width, btn_search.Height, 20, 20));
            btn_cancel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_cancel.Width, btn_cancel.Height, 20, 20));
            txt_stdID.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_stdID.Width, txt_stdID.Height, 20, 20));
            dtp_date.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, dtp_date.Width, dtp_date.Height, 20, 20));
            txt_fname.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_fname.Width, txt_fname.Height, 20, 20));
            txt_lname.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_lname.Width, txt_lname.Height, 20, 20));
            txt_startTime.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_startTime.Width, txt_startTime.Height, 20, 20));
            txt_endTime.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_endTime.Width, txt_endTime.Height, 20, 20));
            txt_sub.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_sub.Width, txt_sub.Height, 20, 20));
            txt_grade.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_grade.Width, txt_grade.Height, 20, 20));
            txt_sid.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_sid.Width, txt_sid.Height, 20, 20));
            txt_nm.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_nm.Width, txt_nm.Height, 20, 20));

        }

      

        private void btn_update_Click(object sender, EventArgs e)
        {
            string cs = @"Data Source= DESKTOP-MILEE7; Initial Catalog= education; Integrated Security=True";

            SqlConnection conn = new SqlConnection(cs);

            conn.Open();

            try
            {
                string sql = "UPDATE stClsSchedule_tbl SET fname=@fname,lname=@lname,date=@date,startTime=@stime,endTime=@etime,subjects=@sub,grade=@grade WHERE st_ID=@stid or fname=@fname";
                SqlCommand command = new SqlCommand(sql, conn);
                command.Parameters.AddWithValue("@stid", this.txt_stdID.Text);
                command.Parameters.AddWithValue("@fname", this.txt_fname.Text);
                command.Parameters.AddWithValue("@lname", this.txt_lname.Text);
                command.Parameters.AddWithValue("@date", Convert.ToDateTime(this.dtp_date.Text));
                command.Parameters.AddWithValue("@stime", Convert.ToDateTime(this.txt_startTime.Text));
                command.Parameters.AddWithValue("@etime", Convert.ToDateTime(this.txt_endTime.Text));
                command.Parameters.AddWithValue("@sub", this.txt_sub.Text);
                command.Parameters.AddWithValue("@grade", this.txt_grade.Text);


                int ret = command.ExecuteNonQuery();
                MessageBox.Show("No of records updated:" + ret, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txt_sid.Clear();
                txt_nm.Clear();
                txt_stdID.Clear();
                txt_fname.Clear();
                txt_lname.Clear();
                txt_startTime.Clear();
                txt_endTime.Clear();
                txt_sub.Clear();
                txt_grade.Clear();

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

        private void btn_search_Click_1(object sender, EventArgs e)
        {

            string cs = @"Data Source= DESKTOP-MILEE7; Initial Catalog= education; Integrated Security=True";
            SqlConnection conn = new SqlConnection(cs);
            conn.Open();

            try
            {

                string sql = "SELECT * FROM stClsSchedule_tbl WHERE st_ID=@stid or fname=@fname";
                SqlCommand command = new SqlCommand(sql, conn);

                command.Parameters.AddWithValue("@stid", this.txt_sid.Text);
                command.Parameters.AddWithValue("@fname", this.txt_nm.Text);


                if (this.txt_sid.Text == "")
                {
                    MessageBox.Show("Require Student ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else if (this.txt_nm.Text == "")
                {
                    MessageBox.Show("Require Student Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else
                {
                    SqlDataReader dr = command.ExecuteReader();
                    if (dr.Read() == true)
                    {

                        this.txt_stdID.Text = dr.GetValue(0).ToString();
                        this.txt_fname.Text = dr.GetValue(1).ToString();
                        this.txt_lname.Text = dr.GetValue(2).ToString();
                        this.dtp_date.Text = dr.GetValue(3).ToString();
                        this.txt_startTime.Text = dr.GetValue(4).ToString();
                        this.txt_endTime.Text = dr.GetValue(5).ToString();
                        this.txt_sub.Text = dr.GetValue(6).ToString();
                        this.txt_grade.Text = dr.GetValue(7).ToString();
                    }
                    else
                    {
                        MessageBox.Show("No records found...", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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

        //private void pictureBox1_Click(object sender, EventArgs e)
        //{
        //    adminClsSchedule c1 = new adminClsSchedule();
        //    c1.Show();
        //    this.Close();
        //}
    }
}
