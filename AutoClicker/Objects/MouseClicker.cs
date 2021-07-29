using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AutoClicker.Objects
{
    public class MouseClicker
    {
        #region API
        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;

        [StructLayout(LayoutKind.Sequential)]
        public struct POINT
        {
            public int X;
            public int Y;

            public static implicit operator Point(POINT point)
            {
                return new Point(point.X, point.Y);
            }
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
        private static extern void mouse_event(long dwFlags, long dx, long dy, long cButtons, long dwExtraInfo);
        [DllImport("user32.dll")]
        public static extern bool GetCursorPos(out POINT lpPoint);
        #endregion
        public void Click(bool leftMouse, bool rightMouse)
        {
            if (!leftMouse && !rightMouse)
                return;
            Point cursorPosition = GetCursorPosition();
            long mouseDown = (leftMouse ? MOUSEEVENTF_LEFTDOWN : 0) | (rightMouse ? MOUSEEVENTF_RIGHTDOWN : 0),
                mouseUp = (leftMouse ? MOUSEEVENTF_LEFTUP : 0) | (rightMouse ? MOUSEEVENTF_RIGHTUP : 0);

            mouse_event(mouseDown, cursorPosition.X, cursorPosition.Y, 0, 0);
            mouse_event(mouseUp, cursorPosition.X, cursorPosition.Y, 0, 0);
        }
        public Point GetCursorPosition()
        {
            POINT lpPoint;
            GetCursorPos(out lpPoint);
            return lpPoint;
        }
    }
}
