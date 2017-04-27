// Decompiled with JetBrains decompiler
// Type: ClickingApplication.Program
// Assembly: ClickingApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A3C8704B-24CE-43AF-86EC-AF00CE641DC1
// Assembly location: D:\ClickingApp\ClickingApplication.exe

using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace ClickingApplication
{
    internal class Program
    {
        public const int MOUSEEVENTF_LEFTDOWN = 2;
        public const int MOUSEEVENTF_LEFTUP = 4;

        public static Point Position { get; set; }

        [DllImport("user32.dll")]
        private static extern bool SetCursorPos(int x, int y);

        [DllImport("user32.dll")]
        public static extern void mouse_event(int dwFlags, int cButtons, int dwExtraInfo);

        private static void Main(string[] args)
        {
            Program.Position = Cursor.Position;
            do
            {
                Program.LeftMouseClick(Program.Position);
                Thread.Sleep(5);
            }
            while (!(Cursor.Position != Program.Position));
        }

        public static void LeftMouseClick(Point Position)
        {
            Program.mouse_event(2, 0, 0);
            Program.mouse_event(4, 0, 0);
        }
    }
}
