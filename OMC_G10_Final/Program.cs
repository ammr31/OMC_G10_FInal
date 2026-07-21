using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace OMC_G10_Final
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.AddMessageFilter(new GlobalKeyFilter());
            Application.Run(new StartScreen());
        }
    }

    public class GlobalKeyFilter : IMessageFilter
    {
        private const int WM_KEYDOWN = 0x0100;

        public bool PreFilterMessage(ref Message m)
        {
            if (m.Msg == WM_KEYDOWN)
            {
                Keys key = (Keys)m.WParam.ToInt32();
                if (key == Keys.Oemtilde)
                {
                    Control? focused = Control.FromHandle(GetFocus());
                    if (focused is TextBox || focused is ComboBox)
                        return false; // let typing "n" work normally in text fields

                    NotificationManager.Show();
                }
            }
            return false;
        }

        [DllImport("user32.dll")]
        private static extern IntPtr GetFocus();
    }
}