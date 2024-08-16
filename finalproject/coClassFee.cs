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
    public partial class coClassFee : Form
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
        public coClassFee()
        {
            InitializeComponent();
        }

        private void coClassFee_Load(object sender, EventArgs e)

        {
            btn_search.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_search.Width, btn_search.Height, 20, 20));
            txt_sid.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_sid.Width, txt_sid.Height, 20, 20));
            txt_sname.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_sname.Width, txt_sname.Height, 20, 20));



        }
        private void btn_search_Click_1(object sender, EventArgs e)
        {
            string cs = @"Data Source= DESKTOP-MILEE7; Initial Catalog= education; Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(cs))
            {
                conn.Open();

                try
                {
                    if (this.txt_sid.Text == "")
                    {
                        MessageBox.Show("Require Student ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    if (this.txt_sname.Text == "")
                    {
                        MessageBox.Show("Require Student Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }


                    string sql = "SELECT * FROM payment_tbl WHERE student_ID=@stid AND student_Name=@sname";
                    using (SqlCommand command = new SqlCommand(sql, conn))
                    {
                        command.Parameters.AddWithValue("@stid", this.txt_sid.Text);
                        command.Parameters.AddWithValue("@sname", this.txt_sname.Text);

                        using (SqlDataReader dr = command.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                               // this.txt_accid.Text = dr["acc_ID"].ToString();

                                // Load data into DataGridView
                                dataGridView1.Rows.Clear();
                                int i = 0;
                                do
                                {
                                    i += 1;
                                    dataGridView1.Rows.Add(i, dr["acc_ID"].ToString(), dr["student_ID"].ToString(), dr["student_Name"].ToString(), dr["subject"].ToString(), dr["grade"].ToString(), dr["fee"].ToString(), dr["date"].ToString());
                                }
                                while (dr.Read());
                            }
                            else
                            {
                                MessageBox.Show("No records found...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }

                    // Clear input fields after the search operation
                    txt_sid.Clear();
                    txt_sname.Clear();
                    //txt_accid.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}


