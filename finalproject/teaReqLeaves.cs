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
    public partial class teaReqLeaves : Form
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
        public teaReqLeaves()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void teaReqLeaves_Load(object sender, EventArgs e)
        {
            btn_request.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_request.Width, btn_request.Height, 20, 20));
            btn_cancel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_cancel.Width, btn_cancel.Height, 20, 20));
            txt_eid.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_eid.Width, txt_eid.Height, 20, 20));
            txt_ename.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_ename.Width, txt_ename.Height, 20, 20));
            txt_to.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_to.Width, txt_to.Height, 20, 20));
            txt_from.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_from.Width, txt_from.Height, 20, 20));
            txt_reason.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_reason.Width, txt_reason.Height, 20, 20));
            dtp_date.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, dtp_date.Width, dtp_date.Height, 20, 20));
        }
    }
}
