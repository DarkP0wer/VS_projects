using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace BrightnessTest
{
    public partial class Form1 : Form
    {
        class Win32
        {
            public const int WS_EX_TRANSPARENT = 0x00000020;
            public const int WS_EX_LAYERED = 0x00080000;
            public const int GWL_EXSTYLE = (-20);


            [DllImport("user32.dll")]
            public static extern int GetWindowLong(IntPtr hwnd, int index);

            [DllImport("user32.dll")]
            public static extern int SetWindowLong(IntPtr hwnd, int index, int newStyle);


            public static void makeTransparent(IntPtr hwnd)
            {
                // Change the extended window style to include WS_EX_TRANSPARENT
                int extendedStyle = GetWindowLong(hwnd, GWL_EXSTYLE);
                Win32.SetWindowLong(hwnd, GWL_EXSTYLE, extendedStyle | WS_EX_TRANSPARENT);
            }


            public static void makeNormal(IntPtr hwnd)
            {
                //Remove the WS_EX_TRANSPARENT flag from the extended window style
                int extendedStyle = GetWindowLong(hwnd, GWL_EXSTYLE);
                Win32.SetWindowLong(hwnd, GWL_EXSTYLE, extendedStyle & ~WS_EX_TRANSPARENT);
            }

        }

        /*public static class MouseHook
        {
            public static event EventHandler MouseAction = delegate { };


            public static void Start()
            {
                _hookID = SetHook(_proc);
            }


            public static void stop()
            {
                UnhookWindowsHookEx(_hookID);
            }

            private static LowLevelMouseProc _proc = HookCallback;
            private static IntPtr _hookID = IntPtr.Zero;

            private static IntPtr SetHook(LowLevelMouseProc proc)
            {
                using (Process curProcess = Process.GetCurrentProcess())
                using (ProcessModule curModule = curProcess.MainModule)
                {
                    return SetWindowsHookEx(WH_MOUSE_LL, proc,
                      GetModuleHandle(curModule.ModuleName), 0);
                }
            }

            private delegate IntPtr LowLevelMouseProc(int nCode, IntPtr wParam, IntPtr lParam);

            private static IntPtr HookCallback(
            int nCode, IntPtr wParam, IntPtr lParam)
            {
                if (nCode >= 0 && MouseMessages.WM_LBUTTONDOWN == (MouseMessages)wParam)
                {
                    MSLLHOOKSTRUCT hookStruct = (MSLLHOOKSTRUCT)Marshal.PtrToStructure(lParam, typeof(MSLLHOOKSTRUCT));
                    MouseAction(null, new EventArgs());
                }
                return CallNextHookEx(_hookID, nCode, wParam, lParam);
            }

            private const int WH_MOUSE_LL = 14;

            private enum MouseMessages
            {
                WM_LBUTTONDOWN = 0x0201,
                WM_LBUTTONUP = 0x0202,
                WM_MOUSEMOVE = 0x0200,
                WM_MOUSEWHEEL = 0x020A,
                WM_RBUTTONDOWN = 0x0204,
                WM_RBUTTONUP = 0x0205
            }

            [StructLayout(LayoutKind.Sequential)]
            private struct POINT
            {
                public int x;
                public int y;
            }

            [StructLayout(LayoutKind.Sequential)]
            private struct MSLLHOOKSTRUCT
            {
                public POINT pt;
                public uint mouseData;
                public uint flags;
                public uint time;
                public IntPtr dwExtraInfo;
            }

            [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
            private static extern IntPtr SetWindowsHookEx(int idHook,
              LowLevelMouseProc lpfn, IntPtr hMod, uint dwThreadId);

            [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            private static extern bool UnhookWindowsHookEx(IntPtr hhk);

            [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
            private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode,
              IntPtr wParam, IntPtr lParam);

            [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
            private static extern IntPtr GetModuleHandle(string lpModuleName);
        }


        private void Event(object sender, EventArgs e)
        {
            
        }
        */


        GlobalKeyboardHook gHook;
        int brigthness = 75;


        public Form1()
        {
            InitializeComponent();

            gHook = new GlobalKeyboardHook();
            gHook.KeyDown += new System.Windows.Forms.KeyEventHandler(gHook_KeyDown);
            /*foreach (System.Windows.Forms.Keys key in Enum.GetValues(typeof(System.Windows.Forms.Keys)))
                gHook.HookedKeys.Add(key);*/
            gHook.HookedKeys.Add(System.Windows.Forms.Keys.Up);
            gHook.HookedKeys.Add(System.Windows.Forms.Keys.Down);
            //MouseHook.Start();
            //MouseHook.MouseAction += new EventHandler(Event);
        }


        public void gHook_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    {
                        if (System.Windows.Input.Keyboard.IsKeyDown(System.Windows.Input.Key.LeftCtrl) && System.Windows.Input.Keyboard.IsKeyDown(System.Windows.Input.Key.LeftShift))
                        {
                            timer_clear_text.Enabled = false;

                            if (brigthness < 98) brigthness++;

                            this.Opacity = brigthness / 100.0;
                            label_info.Text = brigthness.ToString();
                            timer_clear_text.Enabled = true;
                        }
                        break;
                    }
                case Keys.Down:
                    {
                        if (System.Windows.Input.Keyboard.IsKeyDown(System.Windows.Input.Key.LeftCtrl) && System.Windows.Input.Keyboard.IsKeyDown(System.Windows.Input.Key.LeftShift))
                        {
                            timer_clear_text.Enabled = false;

                            if (brigthness > 1) brigthness--;

                            this.Opacity = brigthness / 100.0;
                            label_info.Text = brigthness.ToString();
                            timer_clear_text.Enabled = true;
                        }
                        break;
                    }
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            this.Opacity = brigthness / 100.0;
            Win32.makeTransparent(this.Handle);
            label_info.Text = brigthness.ToString() + "\r\n\r\nCTRL+SHIFT+UP\r\nCTRL+SHIFT+DOWN";
            timer_clear_text.Enabled = true;
            gHook.hook();
            this.TopMost = true;
        }


        private void Form1_Resize(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }


        private void timer_clear_text_Tick(object sender, EventArgs e)
        {
            label_info.Text = "";
        }
    }
}
