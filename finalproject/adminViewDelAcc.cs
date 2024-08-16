﻿using System;
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
    public partial class adminViewDelAcc : Form
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
        public adminViewDelAcc()
        {
            InitializeComponent();
        }

        private void adminViewDelAcc_Load(object sender, EventArgs e)
        {
            btn_delete.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_delete.Width, btn_delete.Height, 20, 20));
            btn_search.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_search.Width, btn_search.Height, 20, 20));
            btn_cancel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_cancel.Width, btn_cancel.Height, 20, 20));
            txt_userID.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_userID.Width, txt_userID.Height, 20, 20));
            txt_accID.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_accID.Width, txt_accID.Height, 20, 20));
            txt_fname.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_fname.Width, txt_fname.Height, 20, 20));
            txt_lname.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_lname.Width, txt_lname.Height, 20, 20));
            txt_uname.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_uname.Width, txt_uname.Height, 20, 20));
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string cs = @"Data Source= DESKTOP-MILEE7; Initial Catalog= education; Integrated Security=True";
            SqlConnection conn = new SqlConnection(cs);
            conn.Open();

            try
            {

                string sql = "SELECT * FROM stAccDetails_tbl WHERE st_ID=@stid and fname=@fname";
                SqlCommand command = new SqlCommand(sql, conn);
                command.Parameters.AddWithValue("@stid", this.txt_userID.Text);
                command.Parameters.AddWithValue("@fname", this.txt_uname.Text);

                if (this.txt_userID.Text == "")
                {
                    MessageBox.Show("Require User ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else if(this.txt_uname.Text == "")
                {
                    MessageBox.Show("Require User Name","Error",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                SqlDataReader dr = command.ExecuteReader();
                if (dr.Read() == true)
                {
                    this.txt_fname.Text = dr.GetValue(1).ToString();
                    this.txt_lname.Text = dr.GetValue(2).ToString();
                    this.txt_accID.Text = dr.GetValue(3).ToString();

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

            finally
            {
                conn.Close();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string cs = @"Data Source= DESKTOP-MILEE7; Initial Catalog= education; Integrated Security=True";
            SqlConnection conn = new SqlConnection(cs);
            conn.Open();

            try
            {
                string sql = "DELETE FROM stAccDetails_tbl WHERE st_ID=@stid or fname=@fname";
                SqlCommand command = new SqlCommand(sql, conn);
                command.Parameters.AddWithValue("@stid", this.txt_userID.Text);
                command.Parameters.AddWithValue("@fname", this.txt_uname.Text);

                string mret = MessageBox.Show("Are you sure to delete this record?", "Warning",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning).ToString();

                if (mret == "Yes")
                {
                    int ret = command.ExecuteNonQuery();
                    MessageBox.Show("No of records deleted: " + ret, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txt_userID.Clear();
                    txt_fname.Clear();
                    txt_lname.Clear();
                    txt_accID.Clear();
                    txt_uname.Clear();

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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            adminViewAcc v1 = new adminViewAcc();
            v1.Show();
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
