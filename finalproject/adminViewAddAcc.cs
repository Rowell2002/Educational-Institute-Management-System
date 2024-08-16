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
    public partial class adminViewAddAcc : Form
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
        public adminViewAddAcc()
        {
            InitializeComponent();
        }

        private void adminAddAcc_Load(object sender, EventArgs e)
        {
            btn_add.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_add.Width, btn_add.Height, 20, 20));
            btn_search.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_search.Width, btn_search.Height, 20, 20));
            btn_cancel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_cancel.Width, btn_cancel.Height, 20, 20));
            txt_userID.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0,txt_userID.Width, txt_userID.Height, 20, 20));
            txt_accID.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_accID.Width, txt_accID.Height, 20, 20));
            txt_fname.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_fname.Width, txt_fname.Height, 20, 20));
            txt_lname.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_lname.Width, txt_lname.Height, 20, 20));
        }

        private void txt_fname_Enter(object sender, EventArgs e)
        {
            if (txt_fname.Text == "First Name")
            {
                txt_fname.Text = "";
                txt_fname.ForeColor = Color.Black;
            }
        }

        private void txt_fname_Leave(object sender, EventArgs e)
        {
            if (txt_fname.Text == "")
            {
                txt_fname.Text = "First Name";
                txt_fname.ForeColor = Color.Silver;

            }
        }

        private void txt_lname_Enter(object sender, EventArgs e)
        {
            if (txt_lname.Text == "Last Name")
            {
                txt_lname.Text = "";
                txt_lname.ForeColor = Color.Black;
            }
        }

        private void txt_lname_Leave(object sender, EventArgs e)
        {
            if (txt_lname.Text == "")
            {
                txt_lname.Text = "Last Name";
                txt_lname.ForeColor = Color.Silver;

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            adminViewAcc v1 = new adminViewAcc();
            v1.Show();
            this.Show();
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
                
                if (this.txt_accID.Text == "")
                {
                    MessageBox.Show("Require Valid Account ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else 
                {
                    string sql = "INSERT INTO stAccDetails_tbl (st_ID,fname,lname,acc_ID) VALUES(@stid,@fname,@lname,@accid)";
                    SqlCommand command = new SqlCommand(sql, conn);
                    command.Parameters.AddWithValue("@stid", this.txt_userID.Text);
                    command.Parameters.AddWithValue("@fname", this.txt_fname.Text);
                    command.Parameters.AddWithValue("@lname", this.txt_lname.Text);
                    command.Parameters.AddWithValue("@accid", this.txt_accID.Text);

                    int ret = command.ExecuteNonQuery();
                    MessageBox.Show("No of records inserted:" + ret, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    txt_userID.Clear();
                    txt_fname.Clear();
                    txt_lname.Clear();
                    txt_accID.Clear();
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

        private void btn_search_Click(object sender, EventArgs e)
        {
            string cs = @"Data Source= DESKTOP-MILEE7; Initial Catalog= education; Integrated Security=True";
            SqlConnection conn = new SqlConnection(cs);
            conn.Open();

            try
            {

                string sql = "SELECT * FROM stDetails_tbl WHERE st_ID=@stid";
                SqlCommand command = new SqlCommand(sql, conn);
                command.Parameters.AddWithValue("@stid", this.txt_userID.Text);

                if (this.txt_userID.Text == "")
                {
                    MessageBox.Show("Require User ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else
                {
                    SqlDataReader dr = command.ExecuteReader();
                    if (dr.Read() == true)
                    {
                        this.txt_fname.Text = dr.GetValue(1).ToString();
                        this.txt_lname.Text = dr.GetValue(2).ToString();

                    }
                    else
                    {
                        MessageBox.Show("No records found...", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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


