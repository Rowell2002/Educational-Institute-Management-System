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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace finalproject
{
    public partial class parent : Form
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
        public parent()
        {
            //InitializeComponent();
            //username = uname;
        }

        private void parent_Load(object sender, EventArgs e)
        {
            button1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button1.Width, button1.Height, 20, 20));
            button2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button2.Width, button2.Height, 20, 20));
            button3.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button3.Width, button3.Height, 20, 20));
            button4.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button4.Width, button4.Height, 20, 20));

            //string sName = GetsName();
            //bl_teacher.Text = sName;

            label2.Text = DateTime.Now.ToString();
        }

        private void btn_results_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            stMarksForm s1 = new stMarksForm();
            s1.TopLevel = false;
            s1.Show();
            panel3.Controls.Add(s1);
            s1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            parentFeedback a1 = new parentFeedback();
            a1.TopLevel = false;
            a1.Show();
            panel1.Controls.Add(a1);
            a1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            stReportForm a1 = new stReportForm();
            a1.TopLevel = false;
            a1.Show();
            panel1.Controls.Add(a1);
            a1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            selectionpg sp1 = new selectionpg();
            sp1.Show();
            this.Hide();
        }
        //private string GetsName()
        //{
        //    string sName = string.Empty;

        //    string cs = @"Data Source= DESKTOP-MILEE7; Initial Catalog= education; Integrated Security=True";
        //    SqlConnection conn = new SqlConnection(cs);
        //    conn.Open();

        //    try
        //    {
        //        string sql = "SELECT emp_Name FROM empDetails_tbl WHERE username = @uname";

        //        SqlCommand command = new SqlCommand(sql, conn);


        //        int i = 0;
        //        command.Parameters.AddWithValue("@uname", username);

        //        SqlDataReader dr = command.ExecuteReader();
        //        if (dr.Read())
        //        {
        //            sName = dr["emp_Name"].ToString();

        //        }
        //        dr.Close();

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error: " + ex.Message);
        //    }

        // return sName;
    

    }
}
