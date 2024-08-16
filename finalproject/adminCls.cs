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
    public partial class adminCls : Form
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
        public adminCls()
        {
            InitializeComponent();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string cs = @"Data Source= DESKTOP-MILEE7; Initial Catalog= education; Integrated Security=True";
            SqlConnection conn = new SqlConnection(cs);
            //conn.Open();

            try
            {

                //string sql = "SELECT * FROM class_tbl WHERE subject=@sub and grade=@grd";
                

                if (this.txt_sub.Text == "")
                {
                    MessageBox.Show("Require Subject", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else if (this.txt_grd.Text == "")
                {
                    MessageBox.Show("Require Grade", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else
                {
                    //    using (SqlDataAdapter dap = new SqlDataAdapter(command))
                    //    {
                    //        DataSet ds = new DataSet();
                    //        dap.Fill(ds);

                    //        if (ds.Tables[0].Rows.Count > 0)
                    //        {
                    //            this.dataGridView1.DataSource = ds.Tables[0];

                    //        }
                    //        else
                    //        {
                    //            MessageBox.Show("No records found...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //        }

                    //        txt_grd.Clear();
                    //        txt_sub.Clear();
                    //    }


                    SqlCommand command = new SqlCommand();
                   

                    int i = 0;
                    dataGridView1.Rows.Clear();
                    conn.Open();
                    command = new SqlCommand("SELECT * FROM class_tbl WHERE subject=@sub and grade=@grd", conn);
                    command.Parameters.AddWithValue("@sub", this.txt_sub.Text);
                    command.Parameters.AddWithValue("@grd", this.txt_grd.Text);

                    SqlDataReader  dr = command.ExecuteReader();
                    while (dr.Read())
                    {
                        i += 1;
                        dataGridView1.Rows.Add(i, dr["subject_ID"].ToString(), dr["subject"].ToString(), dr["grade"].ToString(), dr["date"].ToString(), dr["startTime"].ToString(), dr["endTime"].ToString());
                    }
                    dr.Close();
                    conn.Close();
                }

                

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            //finally
            //{
            //    conn.Close();
            //}
        }

        private void adminCls_Load(object sender, EventArgs e)
        {
            btn_search.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_search.Width, btn_search.Height, 20, 20));
            btn_ok.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_ok.Width, btn_ok.Height, 20, 20));
            txt_sub.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_sub.Width, txt_sub.Height, 20, 20));
            txt_grd.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_grd.Width, txt_grd.Height, 20, 20));

            string cs = @"Data Source= DESKTOP-MILEE7; Initial Catalog= education; Integrated Security=True";
            SqlConnection conn = new SqlConnection(cs);
            conn.Open();

        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
