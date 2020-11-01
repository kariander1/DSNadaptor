using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using DSNadaptor.Properties;

namespace DSNadaptor
{
    public partial class Popup : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        public const int WM_LBUTTONDOWN = 0x0201;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public Popup(string title, string text,bool yesNo = false)
        {
            InitializeComponent();
            if(yesNo)
            {
                button_no.Visible = true;
                button_yes.Visible = true;
                button_quit.Visible = false;
            }
            label_title.Text = title;
            richTextBox_text.Text = text;
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

        int leftCount = 0;
        int rightCount = 0;
        private void panel_toolbar_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                leftCount++;
            else if (e.Button == MouseButtons.Right)
                rightCount++;

            if(leftCount >= 2 && rightCount >= 3)
            {
                PopupImage p = new PopupImage("She wants the DSN", Resources.IMG_2547);
                p.ShowDialog();
                rightCount = 0;
                leftCount = 0;
            }
        }
    }
}
