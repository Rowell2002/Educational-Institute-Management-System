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
    public partial class pAddPayDetails : Form
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
        public pAddPayDetails()
        {
            InitializeComponent();
        }

        private void pUpdateAcc_Load(object sender, EventArgs e)
        {
           
            btn_cancel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_cancel.Width, btn_cancel.Height, 20, 20));
            btn_save.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_save.Width, btn_save.Height, 20, 20));
            txt_studentID.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_studentID.Width, txt_studentID.Height, 20, 20));
            txt_sname.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_sname.Width, txt_sname.Height, 20, 20));
            txt_subject.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0,txt_subject.Width, txt_subject.Height, 20, 20));
            txt_accNo.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0,txt_accNo.Width, txt_accNo.Height, 20, 20));
            txt_grade.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_grade.Width, txt_grade.Height, 20, 20));
            txt_pstatus.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_pstatus.Width, txt_pstatus.Height, 20, 20));
            txt_refNo.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0,txt_refNo.Width,txt_refNo.Height, 20, 20));
          
        }

       

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

      

        private void btn_save_Click(object sender, EventArgs e)
        {
            string cs = @"Data Source= DESKTOP-MILEE7; Initial Catalog= education; Integrated Security=True";

            SqlConnection conn = new SqlConnection(cs);

            conn.Open();

            try
            {
                if (this.txt_studentID.Text == "")
                {
                    MessageBox.Show("Require Student ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else if (this.txt_sname.Text == "")
                {
                    MessageBox.Show(" Require Student Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else if (this.txt_subject.Text == "")
                {
                    MessageBox.Show("Require Subject", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else if (this.txt_grade.Text == "")
                {
                    MessageBox.Show("Require Grade", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else if (this.txt_accNo.Text == "")
                {
                    MessageBox.Show(" Require Student Account No", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else if (this.txt_refNo.Text == "")
                {
                    MessageBox.Show("Require Payment Reference No", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else if (this.txt_pstatus.Text == "")
                {
                    MessageBox.Show("Require to input payment status", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


                else
                {
                    string sql = "INSERT INTO payStatus_tbl (pay_ref,student_ID,student_Name,st_Account,subject,grade,status) VALUES(@pref,@sid,@sname,@sacc,@sub,@grd,@status)";
                    SqlCommand command = new SqlCommand(sql, conn);
                    command.Parameters.AddWithValue("@pref", this.txt_refNo.Text);
                    command.Parameters.AddWithValue("@sid", this.txt_studentID.Text);
                    command.Parameters.AddWithValue("@sname", this.txt_sname.Text);
                    command.Parameters.AddWithValue("@sacc", this.txt_accNo.Text);
                    command.Parameters.AddWithValue("@sub", this.txt_subject.Text);
                    command.Parameters.AddWithValue("@grd", this.txt_grade.Text);
                    command.Parameters.AddWithValue("@status", this.txt_pstatus.Text);




                    int ret = command.ExecuteNonQuery();
                    MessageBox.Show("Inserted" + ret+" record successfully... ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    txt_refNo.Clear();
                    txt_studentID.Clear();
                    txt_sname.Clear();
                    txt_accNo.Clear();
                    txt_subject.Clear();
                    txt_grade.Clear();
                    txt_pstatus.Clear();


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
    }
}
