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
    public partial class adminSubject : Form
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
        public adminSubject()
        {
            InitializeComponent();
        }

        private void admincSubject_Load(object sender, EventArgs e)
        {
            btn_addSub.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_addSub.Width, btn_addSub.Height, 20, 20));
            btn_DelSub.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_DelSub.Width, btn_DelSub.Height, 20, 20));

            
            panel2.BackColor = Color.FromArgb(30, 0, 0, 0);
        }

        private void btn_addSub_Click(object sender, EventArgs e)
        {
            adminAddSub s1 = new adminAddSub();
            s1.TopLevel = false;
            s1.Show();
            sub_pnl.Controls.Add(s1);
            s1.BringToFront();

        }

        private void btn_DelSub_Click(object sender, EventArgs e)
        {
            adminDelSub s1 = new adminDelSub();
            s1.TopLevel = false;
            s1.Show();
            sub_pnl.Controls.Add(s1);
            s1.BringToFront();
        }
    }
}
