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
    public partial class adminAddSub : Form
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
        public adminAddSub()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void adminAddSub_Load(object sender, EventArgs e)
        {
            btn_add.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_add.Width, btn_add.Height, 20, 20));
            btn_cancel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_cancel.Width, btn_cancel.Height, 20, 20));
            txt_subID.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_subID.Width, txt_subID.Height, 20, 20));
            txt_subName.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_subName.Width, txt_subName.Height, 20, 20));
            txt_grd.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_grd.Width, txt_grd.Height, 20, 20));
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string cs = @"Data Source= DESKTOP-MILEE7; Initial Catalog= education; Integrated Security=True";

            SqlConnection conn = new SqlConnection(cs);

            conn.Open();

            try
            {
                if (this.txt_subID.Text == "")
                {
                    MessageBox.Show("Require subject ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else if (this.txt_subName.Text == "")
                {
                    MessageBox.Show(" Require subject Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else if (this.txt_grd.Text == "")
                {
                    MessageBox.Show("Require grade", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                

                else
                {
                    string sql = "INSERT INTO sub_tbl (subject_ID,subject_Name,grade) VALUES(@subid,@subname,@grd)";
                    SqlCommand command = new SqlCommand(sql, conn);
                    command.Parameters.AddWithValue("@subid", this.txt_subID.Text);
                    command.Parameters.AddWithValue("@subname", this.txt_subName.Text);
                    command.Parameters.AddWithValue("@grd", this.txt_grd.Text);
                   


                    int ret = command.ExecuteNonQuery();
                    MessageBox.Show("No of records inserted:" + ret, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    txt_subID.Clear();
                    txt_subName.Clear();
                    txt_grd.Clear();
                    

                    /*txt_fname.Text = "First Name";
                    txt_fname.ForeColor = Color.Silver;
                    txt_lname.Text = "Last Name";
                    txt_lname.ForeColor = Color.Silver;
                    txt_email.Text = "example@gmail.com";
                    txt_email.ForeColor = Color.Silver;*/

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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_grd_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_subName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_subID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
