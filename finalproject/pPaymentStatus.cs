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
    public partial class pPaymentStatus : Form
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
        public pPaymentStatus()
        {
            InitializeComponent();
        }

        private void pPaymentStatus_Load(object sender, EventArgs e)
        {
            btn_search.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_search.Width, btn_search.Height, 20, 20));
            btn_ok.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_ok.Width, btn_ok.Height, 20, 20));
            txt_sid.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_sid.Width, txt_sid.Height, 20, 20));
            txt_sname.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_sname.Width, txt_sname.Height, 20, 20));
        }

        private void btn_search_Click(object sender, EventArgs e)
        {

            string cs = @"Data Source= DESKTOP-MILEE7; Initial Catalog= education; Integrated Security=True";
            SqlConnection conn = new SqlConnection(cs);
            //conn.Open();

            try
            {

                //string sql = "SELECT * FROM class_tbl WHERE subject=@sub and grade=@grd";


                if (this.txt_sid.Text == "")
                {
                    MessageBox.Show("Require Student ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else if (this.txt_sname.Text == "")
                {
                    MessageBox.Show("Require Student Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else
                {
                    SqlCommand command = new SqlCommand();


                    int i = 0;
                    dataGridView1.Rows.Clear();
                    conn.Open();
                    command = new SqlCommand("SELECT * FROM payStatus_tbl WHERE student_ID=@sid and student_Name=@sname", conn);
                    command.Parameters.AddWithValue("@sid", this.txt_sid.Text);
                    command.Parameters.AddWithValue("@sname", this.txt_sname.Text);

                    

                    SqlDataReader dr = command.ExecuteReader();
                    while (dr.Read())
                    {
                        i += 1;
                        dataGridView1.Rows.Add(i, dr["pay_ref"].ToString(), dr["student_ID"].ToString(), dr["student_Name"].ToString(), dr["st_Account"].ToString(), dr["subject"].ToString(), dr["grade"].ToString(), dr["status"].ToString());
                    }

                    txt_sid.Clear();
                    txt_sname.Clear();

                    dr.Close();
                    conn.Close();
                }



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            paymentClerk p1 = new paymentClerk();
            p1.Show();
            this.Close();
        }
    }
}
