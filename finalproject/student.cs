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
    public partial class student : Form
    {
        private string username;

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
        public student(string uname)
        {
            InitializeComponent();
            username = uname;
        }

        private void teacher_Load(object sender, EventArgs e)
        {
            btn_clsSchedule.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_clsSchedule.Width, btn_clsSchedule.Height, 20, 20));
            btn_submit.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_submit.Width, btn_submit.Height, 20, 20));
            btn_onexams.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_onexams.Width, btn_onexams.Height, 20, 20));
            btn_que.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_que.Width, btn_que.Height, 20, 20));
            btn_eva.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_eva.Width, btn_eva.Height, 20, 20));
            btn_tcom.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_tcom.Width, btn_tcom.Height, 20, 20));
            btn_vResults.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_vResults.Width, btn_vResults.Height, 20, 20));
            btn_logout.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_logout.Width, btn_logout.Height, 20, 20));

            string sName = GetsName();
            lbl_st.Text = sName;

            label2.Text = DateTime.Now.ToString();
        }

        private string GetsName()
        {
            string sName = string.Empty;

            string cs = @"Data Source= DESKTOP-MILEE7; Initial Catalog= education; Integrated Security=True";
            SqlConnection conn = new SqlConnection(cs);
            conn.Open();


            try
            {

                string sql = "SELECT fname,lname FROM stDetails_tbl WHERE username = @uname";

                SqlCommand command = new SqlCommand(sql, conn);
                command.Parameters.AddWithValue("@uname", username);

                SqlDataReader dr = command.ExecuteReader();
                if (dr.Read())
                {
                    sName = dr["fname"].ToString() + " " + dr["lname"].ToString();
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            return sName;

        }
    

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            selectionpg sp1 = new selectionpg();
            sp1.Show();
            this.Hide();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            selectionpg sp1 = new selectionpg();
            sp1.Show();
            this.Hide();
        }

        private void btn_clsSchedule_Click(object sender, EventArgs e)
        {
            studentClsSchedule s1 = new studentClsSchedule();
            s1.TopLevel = false;
            s1.Show();
            panel3.Controls.Add(s1);
            s1.BringToFront();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            sSubmitAss s1 = new sSubmitAss();
            s1.TopLevel = false;
            s1.Show();
            panel3.Controls.Add(s1);
            s1.BringToFront();
        }

        private void btn_onexams_Click(object sender, EventArgs e)
        {
            stOnlineExams s1 = new stOnlineExams();
            s1.TopLevel = false;
            s1.Show();
            panel3.Controls.Add(s1);
            s1.BringToFront();
        }

        private void btn_que_Click(object sender, EventArgs e)
        {
            stQue s1 = new stQue();
            s1.TopLevel = false;
            s1.Show();
            panel3.Controls.Add(s1);
            s1.BringToFront();
        }

        private void btn_eva_Click(object sender, EventArgs e)
        {
            stEvaluation s1 = new stEvaluation();
            s1.TopLevel = false;
            s1.Show();
            panel3.Controls.Add(s1);
            s1.BringToFront();
        }

        private void btn_tcom_Click(object sender, EventArgs e)
        {
            stTeacherComment s1 = new stTeacherComment();
            s1.TopLevel = false;
            s1.Show();
            panel3.Controls.Add(s1);
            s1.BringToFront();
        }

        private void btn_vResults_Click(object sender, EventArgs e)
        {
            stMarksForm s1 = new stMarksForm();
            s1.TopLevel = false;
            s1.Show();
            panel3.Controls.Add(s1);
            s1.BringToFront();
        }
    }
}
