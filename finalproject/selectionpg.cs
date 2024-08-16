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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace finalproject
{
    public partial class selectionpg : Form
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

        public selectionpg()
        {
            InitializeComponent();
        }

       

        private void admin_btn_Enter(object sender, EventArgs e)
        {

        }

        private void selectionpg_Load(object sender, EventArgs e)
        {
            
            admin_btn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, admin_btn.Width, admin_btn.Height, 20, 20));
            coordinator_btn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, coordinator_btn.Width, coordinator_btn.Height, 20, 20));
            btn_paymentClerk.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_paymentClerk.Width, btn_paymentClerk.Height, 20, 20));
            eofficer_btn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, eofficer_btn.Width, eofficer_btn.Height, 20, 20));
            Teacher_btn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Teacher_btn.Width, Teacher_btn.Height, 20, 20));
            st_btn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, st_btn.Width, st_btn.Height, 20, 20));
            parent_btn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, parent_btn.Width, parent_btn.Height, 20, 20));
        }

        private void admin_btn_Click(object sender, EventArgs e)
        {
            adminLogin a1 = new adminLogin();
            a1.Show();
            this.Hide();
        }

        private void coordinator_btn_Click(object sender, EventArgs e)
        {
            coLogin c1 = new coLogin();
            c1.Show();
            this.Hide();
        }

        private void eofficer_btn_Click(object sender, EventArgs e)
        {
            exLogin e1 = new exLogin();
            e1.Show();
            this.Hide();
        }

        private void Teacher_btn_Click(object sender, EventArgs e)
        {
            teacherLogin t1 = new teacherLogin();
            t1.Show();
            this.Hide();
        }

        private void btn_paymentClerk_Click(object sender, EventArgs e)
        {
            payLogin p1 = new payLogin();
            p1.Show();
            this.Hide();
        }

        private void st_btn_Click(object sender, EventArgs e)
        {
            stLogin s1 = new stLogin();
            s1.Show();
            this.Hide();
        }

        private void parent_btn_Click(object sender, EventArgs e)
        {
            parentLogin s1 = new parentLogin();
            s1.Show();
            this.Hide();
        }
    }
}
