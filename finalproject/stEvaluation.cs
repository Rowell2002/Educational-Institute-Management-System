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
using System.Web.UI.WebControls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace finalproject
{
    public partial class stEvaluation : Form
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
        public stEvaluation()
        {
            InitializeComponent();
           
        }
     
        private void stEvaluation_Load(object sender, EventArgs e)
        {
            btn_submit.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_submit.Width, btn_submit.Height, 20, 20));
            btn_cancel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_cancel.Width, btn_cancel.Height, 20, 20));
            cmb_teacher.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, cmb_teacher.Width, cmb_teacher.Height, 20, 20));
            txt_eva.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_eva.Width, txt_eva.Height, 20, 20));
            txt_id.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_id.Width, txt_id.Height, 20, 20));

            string cs = @"Data Source= DESKTOP-MILEE7; Initial Catalog= education; Integrated Security=True";

            SqlConnection conn = new SqlConnection(cs);

            try
            {
                conn.Open();
                string query = "SELECT emp_Name,emp_id FROM empDetails_tbl";
                SqlCommand command = new SqlCommand(query, conn);
                SqlDataReader dr = command.ExecuteReader();

                while (dr.Read())
                {
                    cmb_teacher.Items.Add(dr["emp_Name"].ToString());
                   // txt_id.Text = dr["emp_id"].ToString();
                }

                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }

        private void btn_submit_Click(object sender, EventArgs e)
        {

            string cs = @"Data Source= DESKTOP-MILEE7; Initial Catalog= education; Integrated Security=True";

            SqlConnection conn = new SqlConnection(cs);

            conn.Open();

            try
            {
                if (this.txt_eva.Text == "")
                {
                    MessageBox.Show("Evaluate your teacher", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else
                {
                    string sql = "INSERT INTO stEvaluation_tbl (teacher_id,teacher_name,evaluation) VALUES(@tid,@tname,@eva)";
                    SqlCommand command = new SqlCommand(sql, conn);
                    command.Parameters.AddWithValue("@tname", this.cmb_teacher.Text);
                    command.Parameters.AddWithValue("@tid", this.txt_id.Text);
                    command.Parameters.AddWithValue("@eva", this.txt_eva.Text);
                  

                    int ret = command.ExecuteNonQuery();
                    MessageBox.Show("No of records inserted:" + ret, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    txt_eva.Clear();
                    txt_id.Clear();
                  
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

        private void cmb_teacher_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cmb_teacher.SelectedValue != null)
            //{
            //    txt_id.Text = cmb_teacher.SelectedValue.ToString();
            //}
        }

        private void pb_search_Click(object sender, EventArgs e)
        {
            string cs = @"Data Source= DESKTOP-MILEE7; Initial Catalog= education; Integrated Security=True";
            SqlConnection conn = new SqlConnection(cs);
            conn.Open();

            try
            {

                string sql = "SELECT emp_id FROM empDetails_tbl where emp_Name=@tname";
                SqlCommand command = new SqlCommand(sql, conn);
                command.Parameters.AddWithValue("@tname", this.cmb_teacher.Text);
                command.Parameters.AddWithValue("@tid", this.txt_id.Text);


                SqlDataReader dr = command.ExecuteReader();
                if (dr.Read() == true)
                {
                    this.txt_id.Text = dr.GetValue(0).ToString();

                }
                else
                {
                    MessageBox.Show("No records found...", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
