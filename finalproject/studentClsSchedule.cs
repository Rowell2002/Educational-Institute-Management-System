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
    public partial class studentClsSchedule : Form
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
        public studentClsSchedule()
        {
            InitializeComponent();
        }

        private void del_pnl_Paint(object sender, PaintEventArgs e)
        {
            //btn_view.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_view.Width, btn_view.Height, 20, 20));
        }

        private void studentClsSchedule_Load(object sender, EventArgs e)
        {
            btn_view.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_view.Width, btn_view.Height, 20, 20));
        }

        private void btn_view_Click(object sender, EventArgs e)
        {

            string cs = @"Data Source= DESKTOP-MILEE7; Initial Catalog= education; Integrated Security=True";
            SqlConnection conn = new SqlConnection(cs);

            try
            {
                    SqlCommand command = new SqlCommand();

                    int i = 0;
                    dataGridView1.Rows.Clear();
                    conn.Open();
                    command = new SqlCommand("SELECT * FROM stClsSchedule_tbl WHERE st_ID='s001'", conn);
                    //command.Parameters.AddWithValue("@sub", this.txt_sub.Text);
                    //command.Parameters.AddWithValue("@grd", this.txt_grd.Text);

                    SqlDataReader dr = command.ExecuteReader();
                    while (dr.Read())
                    {
                        i += 1;
                        dataGridView1.Rows.Add(i, dr["subjects"].ToString(), dr["grade"].ToString(), dr["date"].ToString(), dr["startTime"].ToString(), dr["endTime"].ToString());
                    }
                    dr.Close();
                    conn.Close();
                }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
    }
}
