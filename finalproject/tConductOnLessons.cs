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
    public partial class tConductOnLessons : Form
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
        public tConductOnLessons()
        {
            InitializeComponent();
        }

        private void tConductOnLessons_Load(object sender, EventArgs e)
        {
            btn_save.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_save.Width, btn_save.Height, 20, 20));
            btn_cancel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_cancel.Width, btn_cancel.Height, 20, 20));
            txt_lid.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_lid.Width, txt_lid.Height, 20, 20));
            txt_sub.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_sub.Width, txt_sub.Height, 20, 20));
            txt_lname.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_lname.Width, txt_lname.Height, 20, 20));
            txt_sTime.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_sTime.Width, txt_sTime.Height, 20, 20));
            txt_eTime.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_eTime.Width, txt_eTime.Height, 20, 20));
            dtp_date.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, dtp_date.Width, dtp_date.Height, 20, 20));
            txt_cls.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_cls.Width, txt_cls.Height, 20, 20));
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
