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
    public partial class stQue : Form
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
        public stQue()
        {
            InitializeComponent();
        }

        private void stQue_Load(object sender, EventArgs e)
        {

            btn_submit.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_submit.Width, btn_submit.Height, 20, 20));
            btn_cancel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_cancel.Width, btn_cancel.Height, 20, 20));
            txt_grade.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_grade.Width, txt_grade.Height, 20, 20));
            txt_que.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_que.Width, txt_que.Height, 20, 20));
            txt_sub.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_sub.Width, txt_sub.Height, 20, 20));
            txt_stID.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_stID.Width, txt_stID.Height, 20, 20));
            txt_teacher.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_teacher.Width, txt_teacher.Height, 20, 20));
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
                    MessageBox.Show("Require subject ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else if (this.txt_grade.Text == "")
                {
                    MessageBox.Show(" Require Grade", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else if (this.txt_sub.Text == "")
                {
                    MessageBox.Show("Require Subject", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else if (this.txt_que.Text == "")
                {
                    MessageBox.Show("Require to enter assignment succsfully", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else if (this.txt_teacher.Text == "")
                {
                    MessageBox.Show("Require to enter teacher's name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


                else
                {
                    string sql = "INSERT INTO stQue_tbl (student_id,teacher_name,subject,grade,question) VALUES(@stid,@tname,@sub,@grd,@que)";
                    SqlCommand command = new SqlCommand(sql, conn);
                    command.Parameters.AddWithValue("@stid", this.txt_stID.Text);
                    command.Parameters.AddWithValue("@tname", this.txt_teacher.Text);
                    command.Parameters.AddWithValue("@sub", this.txt_sub.Text);
                    command.Parameters.AddWithValue("@grd", this.txt_grade.Text);
                    command.Parameters.AddWithValue("@que", this.txt_que.Text);



                    int ret = command.ExecuteNonQuery();
                    MessageBox.Show("No of records inserted:" + ret, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    txt_stID.Clear();
                    txt_sub.Clear();
                    txt_que.Clear();
                    txt_grade.Clear();
                    txt_teacher.Clear();    


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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_sub_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txt_que_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txt_que_Enter(object sender, EventArgs e)
        {
            if (txt_que.Text == "Ask Your Question")
            {
                txt_que.Text = "";
                txt_que.ForeColor = Color.Black;
            }
        }

        private void txt_que_Leave(object sender, EventArgs e)
        {
            if (txt_que.Text == "")
            {
                txt_que.Text = "Ask Your Question";
                txt_que.ForeColor = Color.Silver;

            }
        }
    }
}

