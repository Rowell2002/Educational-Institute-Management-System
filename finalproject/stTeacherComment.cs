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
    public partial class stTeacherComment : Form
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
        public stTeacherComment()
        {
            InitializeComponent();
        }

        private void stTeacherComment_Load(object sender, EventArgs e)
        {
            btn_ok.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_ok.Width, btn_ok.Height, 20, 20));
            txt_sid.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_sid.Width, txt_sid.Height, 20, 20));


        }

       
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pb_search_Click_1(object sender, EventArgs e)
        {

            string cs = @"Data Source= DESKTOP-MILEE7; Initial Catalog= education; Integrated Security=True";
            SqlConnection conn = new SqlConnection(cs);

            try
            {

                SqlCommand command = new SqlCommand();


                int i = 0;
                dataGridView1.Rows.Clear();
                conn.Open();
                command = new SqlCommand("SELECT * FROM stTComment_tbl where student_id=@sid", conn);
                command.Parameters.AddWithValue("@sid", this.txt_sid.Text);

                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    i += 1;
                    dataGridView1.Rows.Add(i, dr["teacher_name"].ToString(), dr["subject"].ToString(), dr["teacher_comment"].ToString());
                }
                dr.Close();
                conn.Close();
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
