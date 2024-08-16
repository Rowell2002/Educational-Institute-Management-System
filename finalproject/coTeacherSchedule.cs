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
    public partial class coTeacherSchedule : Form
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
        public coTeacherSchedule()
        {
            InitializeComponent();
        }

        private void coTeacherSchedule_Load(object sender, EventArgs e)
        {

            btn_update.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_update.Width, btn_update.Height, 20, 20));
            btn_cancel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_cancel.Width, btn_cancel.Height, 20, 20));
            btn_search.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_search.Width, btn_search.Height, 20, 20));
            txt_empID.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_empID.Width, txt_empID.Height, 20, 20));
            dtp_date.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, dtp_date.Width, dtp_date.Height, 20, 20));
            txt_fname.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_fname.Width, txt_fname.Height, 20, 20));
            txt_lname.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_lname.Width, txt_lname.Height, 20, 20));
            txt_stime.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_stime.Width, txt_stime.Height, 20, 20));
            txt_etime.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_etime.Width, txt_etime.Height, 20, 20));
            txt_eid.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_eid.Width, txt_eid.Height, 20, 20));
            txt_enm.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_enm.Width, txt_enm.Height, 20, 20));
            txt_sub.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_sub.Width, txt_sub.Height, 20, 20));
            txt_grd.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_grd.Width, txt_grd.Height, 20, 20));
        }

       private void btn_update_Click(object sender, EventArgs e)
{
    string cs = @"Data Source= DESKTOP-MILEE7; Initial Catalog= education; Integrated Security=True";
    using (SqlConnection conn = new SqlConnection(cs))
    {
        conn.Open();
        SqlTransaction transaction = conn.BeginTransaction();

        try
        {
            if (MessageBox.Show("Are you sure you want to update teacher schedule", "Update Teacher Schedule", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sql1 = "UPDATE eScheduleDetails_tbl SET fname=@fname, lname=@lname, date=@date, startTime=@stime, endTime=@etime, subjects=@sub, grade=@grd WHERE emp_ID=@empid OR fname=@fname";
                using (SqlCommand command = new SqlCommand(sql1, conn, transaction))
                {
                    command.Parameters.AddWithValue("@empid", this.txt_empID.Text);
                    command.Parameters.AddWithValue("@fname", this.txt_fname.Text);
                    command.Parameters.AddWithValue("@lname", this.txt_lname.Text);
                    command.Parameters.AddWithValue("@date", Convert.ToDateTime(this.dtp_date.Text));
                    command.Parameters.AddWithValue("@stime", this.txt_stime.Text);
                    command.Parameters.AddWithValue("@etime", this.txt_etime.Text);
                    command.Parameters.AddWithValue("@sub", this.txt_sub.Text);
                    command.Parameters.AddWithValue("@grd", this.txt_grd.Text);

                    int ret = command.ExecuteNonQuery();
                    MessageBox.Show("No of records updated: " + ret, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                  
                }

                string sql2 = "UPDATE stClsSchedule_tbl SET date=@date,startTime=@stime,endTime=@etime WHERE subjects=@sub OR grade=@grd";
                using (SqlCommand command2 = new SqlCommand(sql2, conn, transaction))
                {
                    command2.Parameters.AddWithValue("@date", Convert.ToDateTime(this.dtp_date.Text));
                    command2.Parameters.AddWithValue("@stime",this.txt_stime.Text);
                    command2.Parameters.AddWithValue("@etime",this.txt_etime.Text);
                    command2.Parameters.AddWithValue("@sub", this.txt_sub.Text);
                    command2.Parameters.AddWithValue("@grd", this.txt_grd.Text);

                    int ret2 = command2.ExecuteNonQuery();
                    MessageBox.Show("No of records updated: " + ret2, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show("Successfully sent the updated schedule to the parent", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                transaction.Commit();
            }
        }
        catch (Exception ex)
        {
            transaction.Rollback();
            MessageBox.Show(ex.Message);
        }
    }
}



        private void btn_search_Click(object sender, EventArgs e)
            {
                string cs = @"Data Source= DESKTOP-MILEE7; Initial Catalog= education; Integrated Security=True";
                SqlConnection conn = new SqlConnection(cs);
                conn.Open();

                try
                {

                    string sql = "SELECT * FROM eScheduleDetails_tbl WHERE emp_ID=@empid and fname=@fname";
                    SqlCommand command = new SqlCommand(sql, conn);
                    command.Parameters.AddWithValue("@empid", this.txt_eid.Text);
                    command.Parameters.AddWithValue("@fname", this.txt_enm.Text);

                    if (this.txt_eid.Text == "")
                    {
                        MessageBox.Show("Require Employee ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    else if (this.txt_enm.Text == "")
                    {
                        MessageBox.Show("Require Employee Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    else
                    {

                        SqlDataReader dr = command.ExecuteReader();
                        if (dr.Read() == true)
                        {

                            this.txt_empID.Text = dr.GetValue(0).ToString();
                            this.txt_fname.Text = dr.GetValue(1).ToString();
                            this.txt_lname.Text = dr.GetValue(2).ToString();
                            this.dtp_date.Text = dr.GetValue(3).ToString();
                            this.txt_stime.Text = dr.GetValue(4).ToString();
                            this.txt_etime.Text = dr.GetValue(5).ToString();
                            this.txt_sub.Text = dr.GetValue(7).ToString();
                            this.txt_grd.Text = dr.GetValue(8).ToString();
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





        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
