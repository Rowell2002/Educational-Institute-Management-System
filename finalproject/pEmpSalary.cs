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
    public partial class pEmpSalary : Form
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
        public pEmpSalary()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pEmpSalary_Load(object sender, EventArgs e)
        {
            btn_search.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_search.Width, btn_search.Height, 20, 20));
            btn_conf.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_conf.Width, btn_conf.Height, 20, 20));
            txt_eid.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_eid.Width, txt_eid.Height, 20, 20));
            txt_ename.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_ename.Width, txt_ename.Height, 20, 20));
            txt_empname.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_empname.Width, txt_empname.Height, 20, 20));
            txt_acc.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_acc.Width, txt_acc.Height, 20, 20));
            txt_ref.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_ref.Width, txt_ref.Height, 20, 20));
            txt_salary.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_salary.Width, txt_salary.Height, 20, 20));

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string cs = @"Data Source= DESKTOP-MILEE7; Initial Catalog= education; Integrated Security=True";
            SqlConnection conn = new SqlConnection(cs);
            conn.Open();

            try
            {

                string sql = "SELECT * FROM empSal_tbl WHERE emp_ID=@eid and emp_Name=@ename";
                SqlCommand command = new SqlCommand(sql, conn);
                command.Parameters.AddWithValue("@eid", this.txt_eid.Text);
                command.Parameters.AddWithValue("@ename", this.txt_ename.Text);


                if (this.txt_eid.Text == "")
                {
                    MessageBox.Show("Require Employee ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else if (this.txt_ename.Text == "")
                {
                    MessageBox.Show("Require Employee Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else
                {
                    SqlDataReader dr = command.ExecuteReader();
                    if (dr.Read() == true)
                    {

                        this.txt_empname.Text = dr.GetValue(2).ToString();
                        this.txt_acc.Text = dr.GetValue(3).ToString();
                        this.txt_ref.Text = dr.GetValue(0).ToString();
                        this.txt_salary.Text = dr.GetValue(4).ToString();
                       
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

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_conf_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Send Payment Successful Message", "Payment Status", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txt_acc.Clear();
            txt_eid.Clear();
            txt_empname.Clear();
            txt_ename.Clear();
            txt_ref.Clear();
            txt_salary.Clear();
           
        }
    }
    }

