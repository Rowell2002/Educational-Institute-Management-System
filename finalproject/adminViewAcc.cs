using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalproject
{
    public partial class adminViewAcc : Form
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
        public adminViewAcc()
        {
            InitializeComponent();
        }

        private void adminViewAcc_Load(object sender, EventArgs e)
        {
            btn_addAcc.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_addAcc.Width, btn_addAcc.Height, 20, 20));
            btn_delAcc.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_delAcc.Width, btn_delAcc.Height, 20, 20));           

            panel1.BackColor = Color.FromArgb(30, 0, 0, 0);
            panel2.BackColor = Color.FromArgb(30, 0, 0, 0);
        }

        //private void btn_addAcc_Click(object sender, EventArgs e)
        //{
        //    adminViewAddAcc a1 = new adminViewAddAcc();
        //    a1.Show();
        //    this.Close();
        //}

        //private void btn_delAcc_Click(object sender, EventArgs e)
        //{
        //    adminViewDelAcc v1 = new adminViewDelAcc();
        //    v1.Show();
        //    this.Close();

        //}

        //private void pictureBox1_Click(object sender, EventArgs e)
        //{
        //    admin a1 = new admin();
        //    a1.Show();
        //    this.Close();
        //}

        private void btn_addAcc_Click_1(object sender, EventArgs e)
        {
            adminViewAddAcc a1 = new adminViewAddAcc();
            a1.TopLevel = false;
            a1.Show();
            panel1.Controls.Add(a1);
            a1.BringToFront();
        }

        private void btn_delAcc_Click(object sender, EventArgs e)
        {
            adminViewDelAcc v1 = new adminViewDelAcc();
            v1.TopLevel = false;
            v1.Show();
            panel1.Controls.Add(v1);
            v1.BringToFront();
        }
    }
}
