using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;

namespace finalproject
{

    public partial class admin : Form
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
        public admin(string uname)
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            username = uname;
        }

        private void admin_Load(object sender, EventArgs e)
        {
            btn_suRecords.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_suRecords.Width, btn_suRecords.Height, 20, 20));
            btn_vAcc.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_vAcc.Width, btn_vAcc.Height, 20, 20));
            btn_schedule.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_schedule.Width, btn_schedule.Height, 20, 20));
            btn_suRecords.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_suRecords.Width, btn_suRecords.Height, 20, 20));
            btn_sub.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_sub.Width, btn_sub.Height, 20, 20));
            btn_cls.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_cls.Width, btn_cls.Height, 20, 20));
            btn_results.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_results.Width, btn_results.Height, 20, 20));
            btn_reports.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_reports.Width, btn_reports.Height, 20, 20));
            btn_events.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_events.Width, btn_events.Height, 20, 20));
            btn_logout.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_logout.Width, btn_logout.Height, 20, 20));


            label7.Text = DateTime.Now.ToString();

            string adminName = GetAdminName();
            lbl_admin.Text =  adminName;
        }

        private string GetAdminName()
        {
            string adminName = string.Empty;

            string cs = @"Data Source= DESKTOP-MILEE7; Initial Catalog= education; Integrated Security=True";
            SqlConnection conn = new SqlConnection(cs);
            conn.Open();

            
                try
                {

                    string sql = "SELECT emp_Name FROM empDetails_tbl WHERE username=@uname";

                    SqlCommand command = new SqlCommand(sql, conn);
                    command.Parameters.AddWithValue("uname", username);
                
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        adminName = reader["emp_Name"].ToString();
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

                return adminName;
               
        }      

private void btn_suRecords_Click(object sender, EventArgs e)
        {
            adminSURecords aur1 = new adminSURecords();
            aur1.TopLevel = false;
            aur1.Show();
            panel3.Controls.Add(aur1);           
            aur1.BringToFront();
            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        public void AddFormToPanel(Form form1)
        {
           
            
        }

        private void btn_vAcc_Click(object sender, EventArgs e)
        {
            adminViewAcc v1 = new adminViewAcc();
            v1.TopLevel = false;
            v1.Show();
            panel3.Controls.Add(v1);
            v1.BringToFront();

           
        }

        private void btn_schedule_Click(object sender, EventArgs e)
        {
            adminSchedule as1 = new adminSchedule();
            as1.TopLevel = false;
            as1.Show();
            panel3.Controls.Add(as1);
            as1.BringToFront();
          
        }

        private void btn_sub_Click(object sender, EventArgs e)
        {
            adminSubject s1 = new adminSubject();
            s1.TopLevel = false;
            s1.Show();
            panel3.Controls.Add(s1);
            s1.BringToFront();
        }

        private void btn_cls_Click(object sender, EventArgs e)
        {
           adminCls c1 = new adminCls();
            c1.TopLevel = false;
            c1.Show();
            panel3.Controls.Add(c1);
            c1.BringToFront();
        }

        private void btn_results_Click(object sender, EventArgs e)
        {
            adminResults r1 = new adminResults();
            r1.TopLevel = false;
            r1.Show();
            panel3.Controls.Add(r1);
            r1.BringToFront();
        }

        private void btn_reports_Click(object sender, EventArgs e)
        {
            salaryform re1 = new salaryform();
            re1.TopLevel = false;
            re1.Show();
            panel3.Controls.Add(re1);
            re1.BringToFront();
        }

        private void btn_events_Click(object sender, EventArgs e)
        {
            adminEvents e1 = new adminEvents();
            e1.TopLevel = false;
            e1.Show();
            panel3.Controls.Add(e1);
            e1.BringToFront();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            selectionpg sp1 = new selectionpg();
            sp1.Show();
            this.Hide();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            selectionpg s1 = new selectionpg();
            s1.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
