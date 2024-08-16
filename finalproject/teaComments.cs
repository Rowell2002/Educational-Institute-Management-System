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
    public partial class teaComments : Form
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
        public teaComments()
        {
            InitializeComponent();
        }

        private void teaComments_Load(object sender, EventArgs e)
        {
            btn_save.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_save.Width, btn_save.Height, 20, 20));
            btn_cancel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_cancel.Width, btn_cancel.Height, 20, 20));
            txt_cid.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_cid.Width, txt_cid.Height, 20, 20));
            txt_sub.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_sub.Width, txt_sub.Height, 20, 20));
            txt_tid.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_tid.Width, txt_tid.Height, 20, 20));
            txt_tname.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_tname.Width, txt_tname.Height, 20, 20));
            txt_sid.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_sid.Width, txt_sid.Height, 20, 20));
            txt_lesson.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_lesson.Width, txt_lesson.Height, 20, 20));
            txt_comment.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_comment.Width, txt_comment.Height, 20, 20));
        }

        private void btn_save_Click(object sender, EventArgs e)
        {

            string cs = @"Data Source= DESKTOP-MILEE7; Initial Catalog= education; Integrated Security=True";

            SqlConnection conn = new SqlConnection(cs);

            conn.Open();
            try
            {
                if (this.txt_cid.Text == "")
                {
                    MessageBox.Show("Require Comment ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else if (this.txt_sid.Text == "")
                {
                    MessageBox.Show("Require Student ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else if (this.txt_tid.Text == "")
                {
                    MessageBox.Show("Require Teacher ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else if (this.txt_tname.Text == "")
                {
                    MessageBox.Show("Require Teacher Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else if (this.txt_sub.Text == "")
                {
                    MessageBox.Show("Require Subject", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else if (this.txt_lesson.Text == "")
                {
                    MessageBox.Show("Require Lesson", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else if (this.txt_comment.Text == "")
                {
                    MessageBox.Show("Require Your Comment", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else
                {
                    string sql = "INSERT INTO stTComment_tbl (comment_id,student_id,teacher_id,teacher_name,subject,teacher_comment,lesson) VALUES(@cid,@sid,@tid,@tname,@sub,@comm,@less)";
                    SqlCommand command = new SqlCommand(sql, conn);
                    command.Parameters.AddWithValue("@cid", this.txt_cid.Text);
                    command.Parameters.AddWithValue("@sid", this.txt_sid.Text);
                    command.Parameters.AddWithValue("@tid", this.txt_tid.Text);
                    command.Parameters.AddWithValue("@tname", this.txt_tname.Text);
                    command.Parameters.AddWithValue("@sub", this.txt_sub.Text);
                    command.Parameters.AddWithValue("@comm", this.txt_comment.Text);
                    command.Parameters.AddWithValue("@less", this.txt_lesson.Text);
                    

                    int ret = command.ExecuteNonQuery();
                    MessageBox.Show("No of records inserted:" + ret, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txt_cid.Clear();
                    txt_sid.Clear();
                    txt_tid.Clear();
                    txt_tname.Clear();
                    txt_sub.Clear();
                    txt_lesson.Clear();
                    txt_comment.Clear();
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

        private void txt_sub_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_lesson_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txt_tid_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_comment_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_tname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_sid_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_cid_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
