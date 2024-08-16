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
    public partial class eResults : Form
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
        public eResults()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void eResults_Load(object sender, EventArgs e)
        {
            btn_submit.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_submit.Width, btn_submit.Height, 20, 20));
            btn_cancel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_cancel.Width, btn_cancel.Height, 20, 20));
            txt_stID.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_stID.Width, txt_stID.Height, 20, 20));
            txt_eid.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_eid.Width, txt_eid.Height, 20, 20));
            txt_ename.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_ename.Width, txt_ename.Height, 20, 20));
            txt_marks.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_marks.Width, txt_marks.Height, 20, 20));
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            string cs = @"Data Source= DESKTOP-MILEE7; Initial Catalog= education; Integrated Security=True";

            SqlConnection conn = new SqlConnection(cs);

            conn.Open();

            try
            {
                if (this.txt_stID.Text == "")
                {
                    MessageBox.Show("Require Student ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else if (this.txt_eid.Text == "")
                {
                    MessageBox.Show("Require Exam Reference No", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else if (this.txt_ename.Text == "")
                {
                    MessageBox.Show("Require Exam Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (this.txt_marks.Text == "")
                {
                    MessageBox.Show("Require Marks", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }



                else
                {
                    string sql = "INSERT INTO results_tbl (ex_refNo,student_ID,exam_Name,marks) VALUES(@eid,@sid,@ename,@marks)";
                    SqlCommand command = new SqlCommand(sql, conn);
                    command.Parameters.AddWithValue("@eid", this.txt_eid.Text);
                    command.Parameters.AddWithValue("@sid", this.txt_stID.Text);
                    command.Parameters.AddWithValue("@ename", this.txt_ename.Text);
                    command.Parameters.AddWithValue("@marks", this.txt_marks.Text);


                    int ret = command.ExecuteNonQuery();
                    MessageBox.Show("Number of records inserted:" + ret, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    txt_stID.Clear();
                    txt_ename.Clear();
                    txt_eid.Clear();
                    txt_marks.Clear();
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
