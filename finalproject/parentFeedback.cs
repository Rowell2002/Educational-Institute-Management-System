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
    public partial class parentFeedback : Form
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
        public parentFeedback()
        {
            InitializeComponent();
        }

        private void parentFeedback_Load(object sender, EventArgs e)
        {
            btn_save.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_save.Width, btn_save.Height, 20, 20));
            btn_cancel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_cancel.Width, btn_cancel.Height, 20, 20));
            txt_pid.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_pid.Width, txt_pid.Height, 20, 20));
            txt_pname.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_pname.Width, txt_pname.Height, 20, 20));
            txt_sub.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_sub.Width, txt_sub.Height, 20, 20));
            txt_tname.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_tname.Width, txt_tname.Height, 20, 20));
            txt_feedback.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_feedback.Width, txt_feedback.Height, 20, 20));
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string cs = @"Data Source= DESKTOP-MILEE7; Initial Catalog= education; Integrated Security=True";

            SqlConnection conn = new SqlConnection(cs);

            conn.Open();
            try
            {
                if (this.txt_pid.Text == "")
                {
                    MessageBox.Show("Require Parent ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else if (this.txt_pname.Text == "")
                {
                    MessageBox.Show("Require Parent Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else if (this.txt_sub.Text == "")
                {
                    MessageBox.Show("Require Subject", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else if (this.txt_tname.Text == "")
                {
                    MessageBox.Show("Require Teacher Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else if (this.txt_feedback.Text == "")
                {
                    MessageBox.Show("Require Your Feedback", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else
                {
                    string sql = "INSERT INTO pFeedback_tbl (parent_id,parent_name,subject,teacher_name,feedback) VALUES(@pid,@pname,@sub,@tname,@feed)";
                    SqlCommand command = new SqlCommand(sql, conn);
                    command.Parameters.AddWithValue("@pid", this.txt_pid.Text);
                    command.Parameters.AddWithValue("@pname", this.txt_pname.Text);
                    command.Parameters.AddWithValue("@sub", this.txt_sub.Text);
                    command.Parameters.AddWithValue("@tname", this.txt_tname.Text);
                    command.Parameters.AddWithValue("@feed", this.txt_feedback.Text);

                    int ret = command.ExecuteNonQuery();
                    MessageBox.Show("No of records inserted:" + ret, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txt_pid.Clear();
                    txt_pname.Clear();
                    txt_sub.Clear();
                    txt_tname.Clear();
                    txt_feedback.Clear();

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
    }
}
