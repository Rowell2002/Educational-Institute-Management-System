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
    public partial class adminResults : Form
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
        public adminResults()
        {
            InitializeComponent();
        }

        private void adminResults_Load(object sender, EventArgs e)
        {
            btn_update.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_update.Width, btn_update.Height, 20, 20));
            btn_search.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_search.Width, btn_search.Height, 20, 20));
            btn_cancel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_cancel.Width, btn_cancel.Height, 20, 20));
            txt_stID.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_stID.Width, txt_stID.Height, 20, 20));
            dtp_date.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, dtp_date.Width, dtp_date.Height, 20, 20));
            txt_stname.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_stname.Width, txt_stname.Height, 20, 20));
            txt_sid.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_sid.Width, txt_sid.Height, 20, 20));
            txt_snm.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_snm.Width, txt_snm.Height, 20, 20));
            txt_sub.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_sub.Width, txt_sub.Height, 20, 20));
            txt_cls.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_cls.Width, txt_cls.Height, 20, 20));
            txt_grd.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_grd.Width, txt_grd.Height, 20, 20));
        }

        private void btn_search_Click(object sender, EventArgs e)
        {

        }
    }
}
