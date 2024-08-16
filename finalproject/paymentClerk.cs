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
    public partial class paymentClerk : Form
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
        public paymentClerk()
        {
            InitializeComponent();
        }

        private void btn_sAttendance_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void paymentClerk_Load(object sender, EventArgs e)
        {
            btn_payStatus.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_payStatus.Width, btn_payStatus.Height, 20, 20));
            btn_addpd.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_addpd.Width, btn_addpd.Height, 20, 20));
            btn_payConf.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_payConf.Width, btn_payConf.Height, 20, 20));
           
            btn_empSal.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_empSal.Width, btn_empSal.Height, 20, 20));
            btn_logout.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_logout.Width, btn_logout.Height, 20, 20));

            string pcName = GetPcName();
            lbl_pc.Text = pcName;

            label2.Text = DateTime.Now.ToString();

        }

        private string GetPcName()
        {
            string pcName = string.Empty;

            string cs = @"Data Source= DESKTOP-MILEE7; Initial Catalog= education; Integrated Security=True";
            SqlConnection conn = new SqlConnection(cs);
            conn.Open();


            try
            {

                string sql = "SELECT emp_Name FROM empDetails_tbl WHERE emp_ID = 'e010'";

                SqlCommand command = new SqlCommand(sql, conn);

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    pcName = reader["emp_Name"].ToString();
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            return pcName;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_payStatus_Click(object sender, EventArgs e)
        {
            pPaymentStatus p1 = new pPaymentStatus();
            p1.TopLevel = false;
            p1.Show();
            panel3.Controls.Add(p1);
            p1.BringToFront();
        }

        private void btn_updateAcc_Click(object sender, EventArgs e)
        {
            pAddPayDetails p1 = new pAddPayDetails();
            p1.TopLevel = false;
            p1.Show();
            panel3.Controls.Add(p1);
            p1.BringToFront();
        }

        private void btn_payConf_Click(object sender, EventArgs e)
        {
            pPayConf p1 = new pPayConf();
            p1.TopLevel = false;
            p1.Show();
            panel3.Controls.Add(p1);
            p1.BringToFront();
        }

        private void btn_empSal_Click(object sender, EventArgs e)
        {
            pEmpSalary p1 = new pEmpSalary();
            p1.TopLevel = false;
            p1.Show();
            panel3.Controls.Add(p1);
            p1.BringToFront();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            selectionpg s1 = new selectionpg();
            s1.Show();
            this.Hide();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            selectionpg s1 = new selectionpg();
            s1.Show();
            this.Hide();
        }
    }
}
