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
    public partial class tReports : Form
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
        public tReports()
        {
            InitializeComponent();
        }

        private void tReports_Load(object sender, EventArgs e)
        {
            btn_salReport.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_salReport.Width, btn_salReport.Height, 20, 20));
            btn_attendance.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_attendance.Width, btn_attendance.Height, 20, 20));
            btn_results.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_results.Width, btn_results.Height, 20, 20));

            panel1.BackColor = Color.FromArgb(30, 0, 0, 0);
            panel2.BackColor = Color.FromArgb(30, 0, 0, 0);
        }

        private void btn_attendance_Click(object sender, EventArgs e)
        {
           stReportForm a1 = new stReportForm();
            a1.TopLevel = false;
            a1.Show();
            panel1.Controls.Add(a1);
            a1.BringToFront();
        }

        private void btn_salReport_Click(object sender, EventArgs e)
        {
            crystalform1 a1 = new crystalform1();
            a1.TopLevel = false;
            a1.Show();
            panel1.Controls.Add(a1);
            a1.BringToFront();
        }

        private void btn_results_Click(object sender, EventArgs e)
        {
            viewMarksForm a1 = new viewMarksForm();
            a1.TopLevel = false;
            a1.Show();
            panel1.Controls.Add(a1);
            a1.BringToFront();
        }
    }
}
