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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace finalproject
{

    public partial class coordinator : Form
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
        public coordinator(string uname)
        {
            InitializeComponent();
            username = uname;
        }

        private void coordinator_Load(object sender, EventArgs e)
        {
            btn_clsFeeDetails.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_clsFeeDetails.Width, btn_clsFeeDetails.Height, 20, 20));
            btn_tSchedule.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_tSchedule.Width, btn_tSchedule.Height, 20, 20));
            btn_sAttendance.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_sAttendance.Width, btn_sAttendance.Height, 20, 20));
            btn_clsList.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_clsList.Width, btn_clsList.Height, 20, 20));
            btn_sub.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_sub.Width, btn_sub.Height, 20, 20));
            btn_logout.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_logout.Width, btn_logout.Height, 20, 20));

            string coName = GetCoName();
            lbl_co.Text = coName;

            label2.Text = DateTime.Now.ToString();
        }

        private string GetCoName()
        {
            string coName = string.Empty;

            string cs = @"Data Source= DESKTOP-MILEE7; Initial Catalog= education; Integrated Security=True";
            SqlConnection conn = new SqlConnection(cs);
            conn.Open();


            try
            {

                string sql = "SELECT emp_Name FROM empDetails_tbl WHERE username=@uname";

                SqlCommand command = new SqlCommand(sql, conn);
                command.Parameters.AddWithValue("@uname", username);

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    coName = reader["emp_Name"].ToString();
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            return coName;

        }

        private void btn_clsFeeDetails_Click(object sender, EventArgs e)
        {
            coClassFee c1 = new coClassFee();
            c1.TopLevel = false;
            c1.Show();
            panel3.Controls.Add(c1);
            c1.BringToFront();
        }

        private void btn_tSchedule_Click(object sender, EventArgs e)
        {
            coTeacherSchedule t1 = new coTeacherSchedule();
            t1.TopLevel = false;
            t1.Show();
            panel3.Controls.Add(t1);
            t1.BringToFront();
        }

        private void btn_sAttendance_Click(object sender, EventArgs e)
        {
            stReportForm a1 = new stReportForm();
            a1.TopLevel = false;
            a1.Show();
            panel3.Controls.Add(a1);
            a1.BringToFront();
        }

        private void btn_clsList_Click(object sender, EventArgs e)
        {
            adminCls t1 = new adminCls();
            t1.TopLevel = false;
            t1.Show();
            panel3.Controls.Add(t1);
            t1.BringToFront();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            selectionpg s1 = new selectionpg();
            s1.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            selectionpg sp1 = new selectionpg();
            sp1.Show();
            this.Hide();
        }

        private void btn_sub_Click(object sender, EventArgs e)
        {
            SubjectReport t1 = new SubjectReport();
            t1.TopLevel = false;
            t1.Show();
            panel3.Controls.Add(t1);
            t1.BringToFront();
        }

        //private string GetAdminName()
        //{
        //    string adminName = string.Empty;


        //    string cs = @"Data Source= DESKTOP-MILEE7; Initial Catalog= education; Integrated Security=True";
        //    SqlConnection conn = new SqlConnection(cs);
        //    conn.Open();


        //    try
        //    {

        //        string sql = "SELECT emp_Name FROM empDetails_tbl WHERE username=@unmame and password=@pwd";

        //        SqlCommand command = new SqlCommand(sql, conn);

        //        command.Parameters.AddWithValue("@Username", uname);
        //        command.Parameters.AddWithValue("@Password", pwd);

        //        SqlDataReader reader = command.ExecuteReader();
        //        if (reader.Read())
        //        {
        //            adminName = reader["emp_Name"].ToString();
        //        }
        //        reader.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error: " + ex.Message);
        //    }

        //    return adminName;

        //}

    }
}
