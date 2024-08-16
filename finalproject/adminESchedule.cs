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
    public partial class adminESchedule : Form
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
        public adminESchedule()
        {
            InitializeComponent();
        }

        //private void btn_addEmpSchedule_Click(object sender, EventArgs e)
        //{
        //    adminAddEmpSchedule e1 = new adminAddEmpSchedule();
        //    e1.Show();
        //    this.Close();
        //}

        //private void btn_updateEmpSchedule_Click(object sender, EventArgs e)
        //{
        //    adminUpdateEmpSchedule u1 = new adminUpdateEmpSchedule();
        //    u1.Show();
        //    this.Close();
        //}

        private void adminESchedule_Load(object sender, EventArgs e)
        {
            btn_addEmpSchedule.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_addEmpSchedule.Width, btn_addEmpSchedule.Height, 20, 20));
            btn_updateEmpSchedule.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_updateEmpSchedule.Width, btn_updateEmpSchedule.Height, 20, 20));

            emp_pnl.BackColor = Color.FromArgb(30, 0, 0, 0);
            panel2.BackColor = Color.FromArgb(30, 0, 0, 0);
        }

        //private void pictureBox1_Click(object sender, EventArgs e)
        //{
        //    adminSchedule s1 = new adminSchedule();
        //    s1.Show();
        //    this.Close();
        //}

        private void btn_addEmpSchedule_Click_1(object sender, EventArgs e)
        {
            adminAddEmpSchedule e1 = new adminAddEmpSchedule();
            e1.TopLevel = false;
            e1.Show();
            emp_pnl.Controls.Add(e1);
            e1.BringToFront();
        }

        private void btn_updateEmpSchedule_Click_1(object sender, EventArgs e)
        {
            adminUpdateEmpSchedule u1 = new adminUpdateEmpSchedule();
            u1.TopLevel = false;
            u1.Show();
            emp_pnl.Controls.Add(u1);
            u1.BringToFront();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
