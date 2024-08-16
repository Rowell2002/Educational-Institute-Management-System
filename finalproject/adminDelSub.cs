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
    public partial class adminDelSub : Form
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
        public adminDelSub()
        {
            InitializeComponent();
        }

        private void adminDelSub_Load(object sender, EventArgs e)
        {
            btn_del.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_del.Width, btn_del.Height, 20, 20));
            btn_cancel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_cancel.Width, btn_cancel.Height, 20, 20));
            btn_search.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_search.Width, btn_search.Height, 20, 20));
            txt_sub.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_sub.Width, txt_sub.Height, 20, 20));
            txt_subID.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_subID.Width, txt_subID.Height, 20, 20));
            txt_subName.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_subName.Width, txt_subName.Height, 20, 20));
            txt_grd.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_grd.Width, txt_grd.Height, 20, 20));
            txt_grade.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_grade.Width, txt_grade.Height, 20, 20));
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string cs = @"Data Source= DESKTOP-MILEE7; Initial Catalog= education; Integrated Security=True";
            SqlConnection conn = new SqlConnection(cs);
            conn.Open();

            try
            {

                string sql = "SELECT * FROM sub_tbl WHERE grade=@grade and subject_Name=@sub";
                SqlCommand command = new SqlCommand(sql, conn);
                command.Parameters.AddWithValue("@sub", this.txt_sub.Text);
                command.Parameters.AddWithValue("@grade", this.txt_grade.Text);

                if (this.txt_sub.Text == "")
                {
                    MessageBox.Show("Require subject", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (this.txt_grade.Text == "")
                {
                    MessageBox.Show("Require grade", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    SqlDataReader dr = command.ExecuteReader();
                    if (dr.Read() == true)
                    {
                        this.txt_subID.Text = dr.GetValue(0).ToString();
                        this.txt_subName.Text = dr.GetValue(1).ToString();
                        this.txt_grd.Text = dr.GetValue(2).ToString();

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

        private void btn_del_Click(object sender, EventArgs e)
        {
            string cs = @"Data Source= DESKTOP-MILEE7; Initial Catalog= education; Integrated Security=True";
            SqlConnection conn = new SqlConnection(cs);
            conn.Open();

            try
            {
                string sql = "DELETE FROM sub_tbl WHERE subject_ID=@subid and subject_Name=@sub";
                SqlCommand command = new SqlCommand(sql, conn);
                command.Parameters.AddWithValue("@subid", this.txt_subID.Text);

                string mret = MessageBox.Show("Are you sure to delete this record?", "Warning",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning).ToString();

                if (mret == "Yes")
                {
                    int ret = command.ExecuteNonQuery();
                    MessageBox.Show("No of records deleted: " + ret, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txt_sub.Clear();
                    txt_subID.Clear();
                    txt_subName.Clear();
                    txt_grd.Clear();
                    txt_grade.Clear();

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
