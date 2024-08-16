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
    public partial class eOffence : Form
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
        public eOffence()
        {
            InitializeComponent();
        }

        private void eOffence_Load(object sender, EventArgs e)
        {

            btn_submit.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_submit.Width, btn_submit.Height, 20, 20));
            btn_cancel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_cancel.Width, btn_cancel.Height, 20, 20));
            txt_stID.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_stID.Width, txt_stID.Height, 20, 20));
            dtp_date.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, dtp_date.Width, dtp_date.Height, 20, 20));
            txt_ename.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_ename.Width, txt_ename.Height, 20, 20));
            txt_offtype.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_offtype.Width, txt_offtype.Height, 20, 20));
           
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            string cs = @"Data Source= DESKTOP-MILEE7; Initial Catalog= education; Integrated Security=True";

            SqlConnection conn = new SqlConnection(cs);

            conn.Open();

            try
            {
                if (this.txt_stID.Text == "")
                {
                    MessageBox.Show("Require Student ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else if (this.dtp_date.Text == "")
                {
                    MessageBox.Show("Require date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else if (this.txt_ename.Text == "")
                {
                    MessageBox.Show("Require Exam Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (this.txt_offtype.Text == "")
                {
                    MessageBox.Show("Require Offence type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

              

                else
                {
                    string sql = "INSERT INTO offence_tbl (student_ID,exam_Name,date,offence_Type) VALUES(@stid,@ename,@date,@otype)";
                    SqlCommand command = new SqlCommand(sql, conn);
                    command.Parameters.AddWithValue("@stid", this.txt_stID.Text);
                    command.Parameters.AddWithValue("@ename", this.txt_ename.Text);
                    command.Parameters.AddWithValue("@date", Convert.ToDateTime(this.dtp_date.Text));                 
                    command.Parameters.AddWithValue("@otype", this.txt_offtype.Text);
                  

                    int ret = command.ExecuteNonQuery();
                    MessageBox.Show("Number of records inserted:" + ret, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    txt_stID.Clear();
                    txt_ename.Clear();
                    txt_offtype.Clear();
                   
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            finally
            {
                conn.Close();
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
