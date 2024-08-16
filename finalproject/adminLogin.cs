using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.Common;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace finalproject
{
    public partial class adminLogin : Form
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


        public adminLogin()
        {
            InitializeComponent();
            
        }

        /*private void txt_uname_Enter(object sender, EventArgs e)
        {
            if(txt_uname.Text == "Enter Username")
            {
                txt_uname.Text = "";
                txt_uname.ForeColor = Color.Black;
            }
        }

        private void txt_uname_Leave(object sender, EventArgs e)
        {
            if(txt_uname.Text == "")
            {
                txt_uname.Text = "Enter Username";
                txt_uname.ForeColor = Color.Silver;

            }
        }

        private void txt_pwd_Enter(object sender, EventArgs e)
        {
            if (txt_pwd.Text == "Enter Password")
            {
                txt_pwd.Text = "";
                txt_pwd.ForeColor = Color.Black;
            }
        }

        private void txt_pwd_Leave(object sender, EventArgs e)
        {
            if (txt_pwd.Text == "")
            {
                txt_pwd.Text = "Enter Password";
                txt_pwd.ForeColor = Color.Silver;

            }
        }*/

        private void txt_pwd_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {
            btn_login.Region = Region.FromHrgn(CreateRoundRectRgn(0,0,btn_login.Width,btn_login.Height,20,20));
            btn_cancel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_cancel.Width, btn_cancel.Height, 20, 20));
            txt_uname.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_uname.Width, txt_uname.Height, 10, 10));
            txt_pwd.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_pwd.Width, txt_pwd.Height, 10, 10));

            panel2.BackColor = Color.FromArgb(50,0,0,0);
        }


       

        private void btn_login_Click_1(object sender, EventArgs e)
        {
            string cs = @"Data Source= DESKTOP-MILEE7; Initial Catalog= education; Integrated Security=True";
            SqlConnection conn = new SqlConnection(cs);
            conn.Open();


            string uname = this.txt_uname.Text;
            string pwd = this.txt_pwd.Text;

            try
            {
                string sql = "SELECT * FROM empDetails_tbl WHERE emp_Type='admin' AND username= '"+txt_uname.Text+"' AND password = '"+txt_pwd.Text+"'";
              

                SqlCommand command = new SqlCommand(sql, conn);

                DataTable dtable = new DataTable();

                SqlDataAdapter dap = new SqlDataAdapter(command);

                dap.Fill(dtable);

                SqlDataReader dr = command.ExecuteReader();

                if(dtable.Rows.Count>0)
                {
                    uname = this.txt_uname.Text;
                    pwd = this.txt_pwd.Text;

                   
                        admin a1 = new admin(uname);
                        a1.Show();
                        this.Hide();
                    

                   
                }

                else
                {
                    MessageBox.Show("Invalid username or password","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    txt_uname.Clear();
                    txt_pwd.Clear();
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
            selectionpg s1 = new selectionpg();
            s1.Show();
            this.Hide();
        }

        private void txt_uname_TextChanged(object sender, EventArgs e)
        {
            /*if(txt_uname.Text == null)
            {
                MessageBox.Show("Please enter username!","Validation Error",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (txt_pwd.Text == null)
            {
                MessageBox.Show("Please enter password!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }*/
        }
    }
}
