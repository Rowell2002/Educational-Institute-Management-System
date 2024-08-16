using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
//using FormUtilities;

namespace finalproject
{
    public partial class adminSURecords : Form
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
        public adminSURecords()
        {
            InitializeComponent();
            //Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void adminSURecords_Load(object sender, EventArgs e)
        {
            btn_addUser.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_addUser.Width,btn_addUser.Height, 20, 20));
            btn_updateUser.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_updateUser.Width, btn_updateUser.Height, 20, 20));
            btn_delUser.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_delUser.Width, btn_delUser.Height, 20, 20));

            panel1.BackColor = Color.FromArgb(30, 0, 0, 0);
            panel2.BackColor = Color.FromArgb(30, 0, 0, 0);
        }

        private void btn_addUser_Click(object sender, EventArgs e)
        {
            

            /*adminAddUser aau1 = new adminAddUser();
            aau1.TopLevel = false;
            aau1.Show();
            panel3.Controls.Add(aau1);
            aau1.BringToFront();
            aau1.Show();*/

            adminSURAddUser aau1 = new adminSURAddUser();
            aau1.Show();
            this.Hide();
            

            
            
        }

        //private void btn_updateUser_Click(object sender, EventArgs e)
        //{
        //    adminSURUpdateUser u1 = new adminSURUpdateUser();
        //    u1.Show();
        //    this.Hide();
        //}

        //private void btn_delUser_Click(object sender, EventArgs e)
        //{
        //    adminSURDelUser d1 = new adminSURDelUser();
        //    d1.Show();
        //    this.Hide();
        //}

        //private void pictureBox1_Click(object sender, EventArgs e)
        //{
        //    admin a1 = new admin();
        //    a1.Show();
        //    this.Close();
        //}

        private void btn_addUser_Click_1(object sender, EventArgs e)
        {
            adminSURAddUser aur1 = new adminSURAddUser();
            aur1.TopLevel = false;
            aur1.Show();
            panel1.Controls.Add(aur1);
            aur1.BringToFront();

        }

        private void btn_updateUser_Click_1(object sender, EventArgs e)
        {
            adminSURUpdateUser aur2 = new adminSURUpdateUser();
            aur2.TopLevel = false;
            aur2.Show();
            panel1.Controls.Add(aur2);
            aur2.BringToFront();
        }

        private void btn_delUser_Click_1(object sender, EventArgs e)
        {
            adminSURDelUser aur3 = new adminSURDelUser();
            aur3.TopLevel = false;
            aur3.Show();
            panel1.Controls.Add(aur3);
            aur3.BringToFront();
        }
    }
}
