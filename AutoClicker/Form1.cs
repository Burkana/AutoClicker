using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoClicker
{
    public partial class Form1 : Form
    {

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, uint vk);

        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);


        private const uint MOUSEEVENTF_LEFTDOWN = 0x02;
        private const uint MOUSEEVENTF_LEFTUP = 0x04;
        private const uint MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const uint MOUSEEVENTF_RIGHTUP = 0x10;
        private const uint MOUSEEVENTF_MIDDLEDOWN = 0x20;
        private const uint MOUSEEVENTF_MIDDLEUP = 0x40;

        private const int HOTKEY_ID = 1;
        private const uint VK_F6 = 0x75;

        private bool isClicking = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboClickType.SelectedIndex = 0;
            RegisterHotKey(this.Handle, HOTKEY_ID, 0, VK_F6);
        }

        private void btnToggle_Click(object sender, EventArgs e)
        {
            ToggleClicker();
        }

        private void ToggleClicker()
        {
            isClicking = !isClicking;

            if (isClicking)
            {
                lblStatus.Text = "Status: CLICKING";
                lblStatus.ForeColor = Color.Green;
                btnToggle.Text = "Stop (F6)";


                int delay = (int)numInterval.Value;
                int clickTypeIndex = comboClickType.SelectedIndex;


                numInterval.Enabled = false;
                comboClickType.Enabled = false;


                Task.Run(() => ClickLoop(delay, clickTypeIndex));
            }
            else
            {
                lblStatus.Text = "Status: STOPPED";
                lblStatus.ForeColor = Color.Red;
                btnToggle.Text = "Start (F6)";


                numInterval.Enabled = true;
                comboClickType.Enabled = true;
            }
        }

        private async void ClickLoop(int delay, int clickTypeIndex)
        {

            uint downFlag = MOUSEEVENTF_LEFTDOWN;
            uint upFlag = MOUSEEVENTF_LEFTUP;

            if (clickTypeIndex == 1)
            {
                downFlag = MOUSEEVENTF_RIGHTDOWN;
                upFlag = MOUSEEVENTF_RIGHTUP;
            }
            else if (clickTypeIndex == 2)
            {
                downFlag = MOUSEEVENTF_MIDDLEDOWN;
                upFlag = MOUSEEVENTF_MIDDLEUP;
            }

            while (isClicking)
            {

                mouse_event(downFlag | upFlag, 0, 0, 0, 0);

                await Task.Delay(delay);
            }
        }


        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            const int WM_HOTKEY = 0x0312;
            if (m.Msg == WM_HOTKEY && m.WParam.ToInt32() == HOTKEY_ID)
            {
                ToggleClicker();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            UnregisterHotKey(this.Handle, HOTKEY_ID);
        }
    }
}