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
    public partial class adminClsSchedule : Form
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
        public adminClsSchedule()
        {
            InitializeComponent();
        }

        //private void btn_addEmpSchedule_Click(object sender, EventArgs e)
        //{
        //    adminAddStSchedule s1 = new adminAddStSchedule();
        //    s1.Show();
        //    this.Close();
        //}

        private void btn_addStSchedule_Click_1(object sender, EventArgs e)
        {
            adminAddStSchedule s1 = new adminAddStSchedule();
            s1.TopLevel = false;
            s1.Show();
            cls_pnl.Controls.Add(s1);
            s1.BringToFront();
        }

        private void btn_updateStSchedule_Click(object sender, EventArgs e)
        {
            adminUpdtStSchedule u1 = new adminUpdtStSchedule();
            u1.TopLevel = false;
            u1.Show();
            cls_pnl.Controls.Add(u1);
            u1.BringToFront();
        }

        private void adminClsSchedule_Load(object sender, EventArgs e)
        {
            btn_addStSchedule.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_addStSchedule.Width, btn_addStSchedule.Height, 20, 20));
            btn_updateStSchedule.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_updateStSchedule.Width, btn_updateStSchedule.Height, 20, 20));

            cls_pnl.BackColor = Color.FromArgb(30, 0, 0, 0);
            panel2.BackColor = Color.FromArgb(30, 0, 0, 0);
        }
    }
}
