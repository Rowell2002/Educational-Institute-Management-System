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
    public partial class pPayConf : Form
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
        public pPayConf()
        {
            InitializeComponent();
        }

        private void pPayConf_Load(object sender, EventArgs e)
        {
            btn_search.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_search.Width, btn_search.Height, 20, 20));
            btn_conf.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_conf.Width, btn_conf.Height, 20, 20));
           
            txt_sid.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_sid.Width, txt_sid.Height, 20, 20));
            txt_sname.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_sname.Width, txt_sname.Height, 20, 20));
            txt_sub.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_sub.Width, txt_sub.Height, 20, 20));
            txt_grd.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_grd.Width, txt_grd.Height, 20, 20));
            txt_accNo.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_accNo.Width, txt_accNo.Height, 20, 20));
            txt_ref.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0,txt_ref.Width, txt_ref.Height, 20, 20));
            txt_status.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_status.Width, txt_status.Height, 20, 20));
           
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string cs = @"Data Source= DESKTOP-MILEE7; Initial Catalog= education; Integrated Security=True";
            SqlConnection conn = new SqlConnection(cs);
            conn.Open();

            try
            {

                string sql = "SELECT * FROM payStatus_tbl WHERE student_ID=@sid and subject=@sub and grade=@grd";
                SqlCommand command = new SqlCommand(sql, conn);

                command.Parameters.AddWithValue("@sid", this.txt_sid.Text);
                command.Parameters.AddWithValue("@sub", this.txt_sub.Text);
                command.Parameters.AddWithValue("@grd", this.txt_grd.Text);

                if (this.txt_sid.Text == "")
                {
                    MessageBox.Show("Require Student ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else if (this.txt_sub.Text == "")
                {
                    MessageBox.Show("Require Subject", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (this.txt_grd.Text == "")
                {
                    MessageBox.Show("Require Grade", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else
                {
                    SqlDataReader dr = command.ExecuteReader();
                    if (dr.Read() == true)
                    {

                        this.txt_sname.Text = dr.GetValue(2).ToString();
                        this.txt_accNo.Text = dr.GetValue(3).ToString();
                        this.txt_ref.Text = dr.GetValue(0).ToString();
                        this.txt_status.Text = dr.GetValue(6).ToString();
                   
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

        private void btn_conf_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Send Payment Successful Message","Payment Status",MessageBoxButtons.OK,MessageBoxIcon.Information);

            txt_accNo.Clear();
            txt_grd.Clear();
            txt_ref.Clear();
            txt_sid.Clear();
            txt_status.Clear();
            txt_sname.Clear();
            txt_sub.Clear();

        }
    }
}
