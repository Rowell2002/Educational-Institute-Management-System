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
    public partial class coStAttendance : Form
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
        public coStAttendance()
        {
            InitializeComponent();
        }

        private void coStAttendance_Load(object sender, EventArgs e)
        {
            btn_search.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_search.Width, btn_search.Height, 20, 20));
            txt_sid.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_sid.Width, txt_sid.Height, 20, 20));
            txt_snm.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_snm.Width, txt_snm.Height, 20, 20));
           
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string cs = @"Data Source= DESKTOP-MILEE7; Initial Catalog= education; Integrated Security=True";
            SqlConnection conn = new SqlConnection(cs);
            //conn.Open();

            try
            {
                if (this.txt_sid.Text == "")
                {
                    MessageBox.Show("Require Student ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else if (this.txt_snm.Text == "")
                {
                    MessageBox.Show("Require Student Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }



                SqlCommand command = new SqlCommand();


                    int i = 0;
                    dataGridView1.Rows.Clear();
                    conn.Open();
                    command = new SqlCommand("SELECT * FROM stAttendance_tbl WHERE student_ID=@sid and student_Name=@snm", conn);
                    command.Parameters.AddWithValue("@sid", this.txt_sid.Text);
                    command.Parameters.AddWithValue("@snm", this.txt_snm.Text);

                    SqlDataReader dr = command.ExecuteReader();
                    while (dr.Read())
                    {
                        i += 1;
                        dataGridView1.Rows.Add(i, dr["student_ID"].ToString(), dr["student_Name"].ToString(), dr["subject"].ToString(), dr["grade"].ToString(), dr["date"].ToString(), dr["attendance"].ToString());
                    }
                    dr.Close();
                    conn.Close();
                }



            
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
