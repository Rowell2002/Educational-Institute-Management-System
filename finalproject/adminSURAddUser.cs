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
    public partial class adminSURAddUser : Form
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
        public adminSURAddUser()
        {
            InitializeComponent();
        }
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string cs = @"Data Source= DESKTOP-MILEE7; Initial Catalog= education; Integrated Security=True";

            SqlConnection conn = new SqlConnection(cs);

            conn.Open();
            try
            {
                if (this.txt_userID.Text == "")
                {
                    MessageBox.Show("Require Student ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else if (this.txt_contact.Text == "")
                {
                    MessageBox.Show("Require contact number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else if (this.txt_fname.Text == "")
                {
                    MessageBox.Show("Require student first name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (this.txt_lname.Text == "")
                {
                    MessageBox.Show("Require student last name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
                else if (this.txt_email.Text == "")
                {
                    MessageBox.Show("Require valid email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else if (this.txt_address.Text == "")
                {
                    MessageBox.Show("Require student address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else
                {
                    string sql = "INSERT INTO stDetails_tbl (st_ID,fname,lname,email,contact,address) VALUES(@stid,@fname,@lname,@email,@contact,@address)";
                    SqlCommand command = new SqlCommand(sql, conn);
                    command.Parameters.AddWithValue("@stid", this.txt_userID.Text);
                    command.Parameters.AddWithValue("@fname", this.txt_fname.Text);
                    command.Parameters.AddWithValue("@lname", this.txt_lname.Text);
                    command.Parameters.AddWithValue("@email", this.txt_email.Text);
                    command.Parameters.AddWithValue("@contact", this.txt_contact.Text);
                    command.Parameters.AddWithValue("@address", this.txt_address.Text);

                    int ret = command.ExecuteNonQuery();
                    MessageBox.Show("No of records inserted:" + ret, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    txt_userID.Clear();
                    txt_fname.Clear();
                    txt_lname.Clear();
                    txt_contact.Clear();
                    txt_address.Clear();
                    txt_email.Clear();

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

        //private void pictureBox1_Click(object sender, EventArgs e)
        //{
        //    adminSURecords a1 = new adminSURecords();
        //    a1.Show();
        //    this.Close();
        //}

        private void txt_fname_TextChanged(object sender, EventArgs e)
        {

        }


        private void txt_fname_Enter_1(object sender, EventArgs e)
        {
            if (txt_fname.Text == "First Name")
            {
                txt_fname.Text = "";
                txt_fname.ForeColor = Color.Black;
            }
        }

        private void txt_fname_Leave_1(object sender, EventArgs e)
        {
            if (txt_fname.Text == "")
            {
                txt_fname.Text = "First Name";
                txt_fname.ForeColor = Color.Silver;

            }
        }

        private void txt_lname_Enter_1(object sender, EventArgs e)
        {
            if (txt_lname.Text == "Last Name")
            {
                txt_lname.Text = "";
                txt_lname.ForeColor = Color.Black;
            }
        }

        private void txt_lname_Leave_1(object sender, EventArgs e)
        {
            if (txt_lname.Text == "")
            {
                txt_lname.Text = "Last Name";
                txt_lname.ForeColor = Color.Silver;

            }
        }

        private void txt_email_Enter_1(object sender, EventArgs e)
        {
            if (txt_email.Text == "example@gmail.com")
            {
                txt_email.Text = "";
                txt_email.ForeColor = Color.Black;
            }
        }

        private void txt_email_Leave_1(object sender, EventArgs e)
        {
            if (txt_email.Text == "")
            {
                txt_email.Text = "example@gmail.com";
                txt_email.ForeColor = Color.Silver;

            }
        }

        private void txt_fname_ForeColorChanged(object sender, EventArgs e)
        {
            if(txt_fname.Text == "First Name")
            {
                txt_fname.ForeColor = Color.Silver;
            }
            else
            {
                txt_fname.ForeColor = Color.Black;
            }
        }

        private void adminAddUser_Load(object sender, EventArgs e)
        {
            btn_add.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_add.Width, btn_add.Height, 20, 20));
            btn_cancel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_cancel.Width, btn_cancel.Height, 20, 20));
            txt_userID.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_userID.Width, txt_userID.Height, 20, 20));
            txt_email.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_email.Width, txt_email.Height, 20, 20));
            txt_fname.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_fname.Width, txt_fname.Height, 20, 20));
            txt_lname.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_lname.Width, txt_lname.Height, 20, 20));
            txt_contact.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_contact.Width, txt_contact.Height, 20, 20));
            txt_address.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_address.Width, txt_address.Height, 20, 20));

        }

        private void txt_userID_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
