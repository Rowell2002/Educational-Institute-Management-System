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
    public partial class parents : Form
    {
        public string username;

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
        public parents(string uname)
        {
            InitializeComponent();
            username = uname;
        }

        private void parents_Load(object sender, EventArgs e)
        {
            btn_feedback.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_feedback.Width, btn_feedback.Height, 20, 20));
            btn_attendance.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_attendance.Width, btn_attendance.Height, 20, 20));
            btn_results.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_results.Width, btn_results.Height, 20, 20));
            btn_logout.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_logout.Width, btn_logout.Height, 20, 20));

            lbl_systemDate.Text = DateTime.Now.ToString();

            string pName = GetpName();
            lbl_parent.Text = pName;

        }

        private string GetpName()
        {
            string adminName = string.Empty;

            string cs = @"Data Source= DESKTOP-MILEE7; Initial Catalog= education; Integrated Security=True";
            SqlConnection conn = new SqlConnection(cs);
            conn.Open();


            try
            {

                string sql = "SELECT parent_name FROM parentDetails_tbl WHERE username=@uname";

                SqlCommand command = new SqlCommand(sql, conn);
                command.Parameters.AddWithValue("uname", username);

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    adminName = reader["parent_name"].ToString();
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            return adminName;

        }

        private void btn_results_Click(object sender, EventArgs e)
        {
            stMarksForm s1 = new stMarksForm();
            s1.TopLevel = false;
            s1.Show();
            panel3.Controls.Add(s1);
            s1.BringToFront();
        }

        private void btn_feedback_Click(object sender, EventArgs e)
        {
            parentFeedback a1 = new parentFeedback();
            a1.TopLevel = false;
            a1.Show();
            panel3.Controls.Add(a1);
            a1.BringToFront();
        }

        private void btn_attendance_Click(object sender, EventArgs e)
        {
            stReportForm a1 = new stReportForm();
            a1.TopLevel = false;
            a1.Show();
            panel3.Controls.Add(a1);
            a1.BringToFront();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            selectionpg s1 = new selectionpg();
            s1.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            selectionpg s1 = new selectionpg();
            s1.Show();
            this.Hide();
        }
    }
}
