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
    public partial class tLearningMaterials : Form
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

        public tLearningMaterials()
        {
            InitializeComponent();
        }

        private void txt_comment_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_comment_Enter_1(object sender, EventArgs e)
        {
            txt_materials.Text = "Drag & Drop Here";
            txt_materials.ForeColor = Color.Silver;
            txt_materials.Text = "";
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string cs = @"Data Source= DESKTOP-MILEE7; Initial Catalog= education; Integrated Security=True";

            SqlConnection conn = new SqlConnection(cs);

            conn.Open();

            try
            {
                if (this.txt_tid.Text == "")
                {
                    MessageBox.Show("Require Teacher ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else if (this.txt_tname.Text == "")
                {
                    MessageBox.Show(" Require Teacher Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else if (this.txt_grd.Text == "")
                {
                    MessageBox.Show(" Require Grade", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else if (this.txt_sub.Text == "")
                {
                    MessageBox.Show("Require Subject", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else if (this.txt_materials.Text == "")
                {
                    MessageBox.Show("Require to upload learning materials successfully", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


                else
                {
                    string sql = "INSERT INTO tMaterial_tbl (teacher_id,teacher_name,subject,grade,material) VALUES(@tid,@tname,@sub,@grd,@mat)";
                    SqlCommand command = new SqlCommand(sql, conn);
                    command.Parameters.AddWithValue("@tid", this.txt_tid.Text);
                    command.Parameters.AddWithValue("@tname", this.txt_tname.Text);
                    command.Parameters.AddWithValue("@sub", this.txt_sub.Text);
                    command.Parameters.AddWithValue("@grd", this.txt_grd.Text);
                    command.Parameters.AddWithValue("@mat", this.txt_materials.Text);
              

                    //int insertedUserId = (int)command.ExecuteScalar();

                    //MessageBox.Show("Inserted Material ID: " + insertedMaterialId, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    int ret = command.ExecuteNonQuery();
                    MessageBox.Show("No of records inserted:" + ret, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    txt_tid.Clear();
                    txt_tname.Clear();
                    txt_sub.Clear();
                    txt_grd.Clear();
                    txt_materials.Clear();

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

        private void txt_materials_Leave(object sender, EventArgs e)
        {

            //txt_materials.Text = "";
            //txt_materials.ForeColor = Color.Black;
            //txt_materials.Text = "Drag & Drop Here";
        }

        private void tLearningMaterials_Load(object sender, EventArgs e)
        {
            btn_save.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_save.Width, btn_save.Height, 20, 20));
            btn_cancel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_cancel.Width, btn_cancel.Height, 20, 20));
            txt_sub.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_sub.Width, txt_sub.Height, 20, 20));
            txt_grd.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_grd.Width, txt_grd.Height, 20, 20));
            txt_tid.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_tid.Width, txt_tid.Height, 20, 20));
            txt_tname.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_tname.Width, txt_tname.Height, 20, 20));
            txt_materials.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_materials.Width, txt_materials.Height, 20, 20));
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
