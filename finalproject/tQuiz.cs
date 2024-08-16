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
    public partial class tQuiz : Form
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
        public tQuiz()
        {
            InitializeComponent();
        }

        private void tQuiz_Load(object sender, EventArgs e)
        {
            btn_upload.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_upload.Width, btn_upload.Height, 20, 20));
            btn_cancel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_cancel.Width, btn_cancel.Height, 20, 20));
            txt_sub.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_sub.Width, txt_sub.Height, 20, 20));
            txt_cls.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_cls.Width, txt_cls.Height, 20, 20));
            txt_time.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_time.Width, txt_time.Height, 20, 20));
            txt_que.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_que.Width, txt_que.Height, 20, 20));
            dtp_date.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, dtp_date.Width, dtp_date.Height, 20, 20));
        }
    }
}
