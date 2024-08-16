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
    public partial class teacher : Form
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
        public teacher(string uname)
        {
            InitializeComponent();
            username = uname;
        }

        private void teacher_Load(object sender, EventArgs e)
        {
            btn_results.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_results.Width, btn_results.Height, 20, 20));
            btn_comment.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_comment.Width, btn_comment.Height, 20, 20));
            btn_onlessons.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_onlessons.Width, btn_onlessons.Height, 20, 20));
            btn_exam.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_exam.Width, btn_exam.Height, 20, 20));
            btn_report.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_report.Width, btn_report.Height, 20, 20));
            btn_lmaterials.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_lmaterials.Width, btn_lmaterials.Height, 20, 20));
            btn_leaves.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_leaves.Width, btn_leaves.Height, 20, 20));
            btn_quizes.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_quizes.Width, btn_quizes.Height, 20, 20));
            btn_logout.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_logout.Width, btn_logout.Height, 20, 20));

            string sName = GetsName();
            lbl_teacher.Text = sName;

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
                string sql = "SELECT emp_Name FROM empDetails_tbl WHERE username = @uname" ;

                SqlCommand command = new SqlCommand(sql, conn);


                //int i = 0;
                command.Parameters.AddWithValue("@uname", username);

                SqlDataReader dr = command.ExecuteReader();
                if (dr.Read())
                {
                    sName = dr["emp_Name"].ToString();
                 
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
            selectionpg sp1 = new selectionpg();
            sp1.Show();
            this.Hide();
        }

        private void btn_results_Click(object sender, EventArgs e)
        {

            tEnterResults r1 = new tEnterResults();
            r1.TopLevel = false;
            r1.Show();
            panel3.Controls.Add(r1);
            r1.BringToFront();
        }

        private void btn_comment_Click(object sender, EventArgs e)
        {
            teaComments c1 = new teaComments();
            c1.TopLevel = false;
            c1.Show();
            panel3.Controls.Add(c1);
            c1.BringToFront();
        }

        private void btn_exam_Click(object sender, EventArgs e)
        {
            tScheduleExam t1 = new tScheduleExam();
            t1.TopLevel = false;
            t1.Show();
            panel3.Controls.Add(t1);
            t1.BringToFront();
        }

        private void btn_report_Click(object sender, EventArgs e)
        {
            tReports r1 = new tReports();
            r1.TopLevel = false;
            r1.Show();
            panel3.Controls.Add(r1);
            r1.BringToFront();

        }

        private void btn_quizes_Click(object sender, EventArgs e)
        {
            tQuiz l1 = new tQuiz();
            l1.TopLevel = false;
            l1.Show();
            panel3.Controls.Add(l1);
            l1.BringToFront();
        }

        private void btn_lmaterials_Click(object sender, EventArgs e)
        {
            tLearningMaterials l1 = new tLearningMaterials();
            l1.TopLevel = false;
            l1.Show();
            panel3.Controls.Add(l1);
            l1.BringToFront();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            selectionpg sp1 = new selectionpg();
            sp1.Show();
            this.Hide();
        }

        private void btn_leaves_Click(object sender, EventArgs e)
        {
            teaReqLeaves t1 = new teaReqLeaves();
            t1.TopLevel = false;
            t1.Show();
            panel3.Controls.Add(t1);
            t1.BringToFront();
        }

        private void btn_onlessons_Click(object sender, EventArgs e)
        {
            tConductOnLessons t1 = new tConductOnLessons();
            t1.TopLevel = false;
            t1.Show();
            panel3.Controls.Add(t1);
            t1.BringToFront();
        }
    }
}
