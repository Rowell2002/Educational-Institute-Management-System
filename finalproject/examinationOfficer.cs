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
    public partial class examinationOfficer : Form
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
        public examinationOfficer(string uname)
        {
            InitializeComponent();
            username = uname;
        }

       

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void examinationOfficer_Load(object sender, EventArgs e)
        {
            btn_exmOffence.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_exmOffence.Width, btn_exmOffence.Height, 20, 20));
            btn_result.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_result.Width, btn_result.Height, 20, 20));
            btn_logout.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_logout.Width, btn_logout.Height, 20, 20));


            string exName = GetExName();
            lbl_ex.Text = exName;

            label2.Text = DateTime.Now.ToString();
        }

        private string GetExName()
        {
            string exName = string.Empty;

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
                    exName = reader["emp_Name"].ToString();
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            return exName;

        }

        private void btn_exmOffence_Click(object sender, EventArgs e)
        {
            eOffence e1 = new eOffence();
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

       

        private void btn_result_Click(object sender, EventArgs e)
        {
            eResults ee1 = new eResults();
            ee1.TopLevel = false;
            ee1.Show();
            panel3.Controls.Add(ee1);
            ee1.BringToFront();
        }
    }
}
