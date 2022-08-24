using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrushWinFormsApp
{
    public partial class CrushMainForm : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        Random random;
     // Timer t;
        public CrushMainForm()
        {
            InitializeComponent();
          /*  t = new Timer()
            {
                Interval = 100
            };
            t.Enabled = true;
          */
            
        }
     
        private void CrushMainForm_Load(object sender, EventArgs e)
        {
            this.Size = new Size(800, 410);
        }
        private void CrushMainForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void btnNo_MouseEnter(object sender, EventArgs e)
        {
             random = new Random();
            var maxWidth = this.ClientSize.Width - btnNo.ClientSize.Width;
            var maxHeight = this.ClientSize.Height - btnNo.ClientSize.Height;
            this.btnNo.Location = new Point(random.Next(maxWidth), random.Next(maxHeight));

        }
        private void btnNo_MouseHover(object sender, EventArgs e)
        {
            random = new Random();
            int x = random.Next(0, this.Width - btnNo.Width);
            int y = random.Next(0, this.Height - btnNo.Height);
            btnNo.Left = x;
            btnNo.Top = y;
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("SABI KO NA NGA BA EH CRUSH MO AKO❤\n AHMMM...CRUSH DIN KITA🥰", "HI CRUSH👋",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
           /* base.OnMouseMove(e);
            var point = new Point(e.Location.X - (btnYes.Width / 2), e.Location.Y - (btnYes.Height / 2));
            btnYes.Location = point;   
           */      
        }

        private void btnExit_MouseEnter(object sender, EventArgs e)
        {
            btnExit.Cursor = Cursors.Hand;
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            btnExit.Cursor = Cursors.Arrow;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            btnExit.Cursor = Cursors.Arrow;
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void label2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

    }
}
