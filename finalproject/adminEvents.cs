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

    
    public partial class adminEvents : Form
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
        public adminEvents()
        {
            InitializeComponent();
        }

        private void adminEvents_Load(object sender, EventArgs e)
        {
            btn_save.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_save.Width, btn_save.Height, 20, 20));
            btn_cancel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_cancel.Width, btn_cancel.Height, 20, 20));
            txt_eventName.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_eventName.Width, txt_eventName.Height, 20, 20));
            dtp_date.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, dtp_date.Width, dtp_date.Height, 20, 20));
            txt_venue.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_venue.Width, txt_venue.Height, 20, 20));
            txt_time.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_time.Width,txt_time.Height, 20, 20));
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string cs = @"Data Source= DESKTOP-MILEE7; Initial Catalog= education; Integrated Security=True";

            SqlConnection conn = new SqlConnection(cs);

            conn.Open();

            try
            {
                if (this.txt_eventName.Text == "")
                {
                    MessageBox.Show("Require event name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else if (this.dtp_date.Text == "")
                {
                    MessageBox.Show("Require date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else if (this.txt_venue.Text == "")
                {
                    MessageBox.Show("Require venue", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (this.txt_time.Text == "")
                {
                    MessageBox.Show("Require event time", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

               

                else
                {
                    string sql = "INSERT INTO eventDetails_tbl (event_Name,Venue,Date,Time) VALUES(@evname,@venue,@date,@time)";
                    SqlCommand command = new SqlCommand(sql, conn);
                    command.Parameters.AddWithValue("@evname", this.txt_eventName.Text);
                    command.Parameters.AddWithValue("@venue", this.txt_venue.Text);
                    command.Parameters.AddWithValue("@date", Convert.ToDateTime(this.dtp_date.Text));
                    command.Parameters.AddWithValue("@time", Convert.ToDateTime(this.txt_time.Text));
                   
                    int ret = command.ExecuteNonQuery();
                    MessageBox.Show("No of records inserted:" + ret, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);


                   txt_eventName.Clear();
                   txt_venue.Clear();
                    txt_time.Clear();


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
    }
}
