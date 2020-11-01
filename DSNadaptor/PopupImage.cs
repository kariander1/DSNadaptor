using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace DSNadaptor
{
    public partial class PopupImage : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        public const int WM_LBUTTONDOWN = 0x0201;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public PopupImage(string title, Image img,bool yesNo = false)
        {
            InitializeComponent();
            if(yesNo)
            {
                button_no.Visible = true;
                button_yes.Visible = true;
                button_quit.Visible = false;
            }
            label_title.Text = title;
            pictureBox_image.BackgroundImage = img;
            pictureBox_image.BackgroundImageLayout = ImageLayout.Stretch;
            //richTextBox_text.Text = text;
            Form_Main.FadeIn(this,10);
        }

        private void button_quit_Click(object sender, EventArgs e)
        {
            endDialog(DialogResult.No);
        }
       

        private void panel_toolbar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void button_yes_Click(object sender, EventArgs e)
        {
            endDialog(DialogResult.Yes);
        }
        private void endDialog(DialogResult dialogResult)
        {
            Form_Main.FadeOut(this, 10);
            this.DialogResult = dialogResult;
        }
    }
}
