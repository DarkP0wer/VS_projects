using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace English
{
    public static class WinAPI
    {
        public static class User32
        {
            public static readonly int WM_NCLBUTTONDOWN = 0xA1;
            public static readonly int HT_CAPTION = 0x2;

            [DllImport("user32.dll")]
            public static extern bool GetCursorPos(ref Point lpPoint);

            [DllImportAttribute("user32.dll")]
            public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

            [DllImportAttribute("user32.dll")]
            public static extern bool ReleaseCapture();
        }
    }


}
