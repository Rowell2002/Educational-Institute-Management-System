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
    public partial class tEnterResults : Form
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
        public tEnterResults()
        {
            InitializeComponent();
        }

        private void tEnterResults_Load(object sender, EventArgs e)
        {
            btn_save.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_save.Width, btn_save.Height, 20, 20));
            btn_cancel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_cancel.Width, btn_cancel.Height, 20, 20));
            btn_calculate.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_calculate.Width, btn_calculate.Height, 20, 20));
            txt_sid.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_sid.Width, txt_sid.Height, 20, 20));
            txt_marks.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_marks.Width, txt_marks.Height, 20, 20));
            txt_grade.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_grade.Width, txt_grade.Height, 20, 20));
            txt_resultid.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_resultid.Width, txt_resultid.Height, 20, 20));
            cmb_exam.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, cmb_exam.Width, cmb_exam.Height, 20, 20));
            cmb_cls.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, cmb_cls.Width, cmb_cls.Height, 20, 20));
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string cs = @"Data Source= DESKTOP-MILEE7; Initial Catalog= education; Integrated Security=True";

            SqlConnection conn = new SqlConnection(cs);

            conn.Open();
            try
            {
                if (this.txt_resultid.Text == "")
                {
                    MessageBox.Show("Require Result ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else if (this.txt_sid.Text == "")
                {
                    MessageBox.Show("Require Student ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else if (this.txt_marks.Text == "")
                {
                    MessageBox.Show("Require Marks", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else
                {
                    string sql = "INSERT INTO result_tbl (result_id,student_id,class,exam_name,marks,grade) VALUES(@rid,@stid,@class,@ename,@marks,@grade)";
                    SqlCommand command = new SqlCommand(sql, conn);
                    command.Parameters.AddWithValue("@rid", this.txt_resultid.Text);
                    command.Parameters.AddWithValue("@stid", this.txt_sid.Text);
                    command.Parameters.AddWithValue("@class", this.cmb_cls.SelectedItem);
                    command.Parameters.AddWithValue("@ename", this.cmb_exam.SelectedItem);
                    command.Parameters.AddWithValue("@marks", this.txt_marks.Text);
                    command.Parameters.AddWithValue("@grade", this.txt_grade.Text);

                    int ret = command.ExecuteNonQuery();
                    MessageBox.Show("No of records inserted:" + ret, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    txt_resultid.Clear();
                    txt_sid.Clear();
                    txt_marks.Clear();
                    txt_grade.Clear();
                    cmb_cls.SelectedIndex = -1;
                    cmb_exam.SelectedIndex = -1;

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

        private void btn_calculate_Click(object sender, EventArgs e)
        {

            if (int.TryParse(txt_marks.Text, out int marks))
            {
                char grade='F';
                if (marks >= 75)
                {
                    grade = 'A';
                }
                else if (marks >= 65 && marks<=75)
                {
                    grade = 'B';
                }
                else if (marks >= 55 && marks<=65)
                {
                    grade = 'C';
                }
                else if (marks >= 40 && marks<=55)
                {
                    grade = 'S';
                }
                else if(marks < 40)
                {
                    grade = 'F';
                }

                txt_grade.Text = grade.ToString();            }
            else
            {
                MessageBox.Show("Please enter a valid number for marks.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
