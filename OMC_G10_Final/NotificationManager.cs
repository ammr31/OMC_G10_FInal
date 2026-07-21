using System;
using System.Drawing;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace OMC_G10_Final
{
    public static class NotificationManager
    {
        private static NotificationBar? _bar;
        private static Timer? _hideTimer;

        public static void Show()
        {
            Form? target = Form.ActiveForm;
            if (target == null) return;

            if (_bar == null || _bar.IsDisposed || _bar.Parent != target)
            {
                _bar?.Parent?.Controls.Remove(_bar);

                _bar = new NotificationBar
                {
                    Dock = DockStyle.None,           // important: no docking
                    Anchor = AnchorStyles.Top         // stays put relative to top on resize
                };

                target.Controls.Add(_bar);
                _bar.BringToFront();
            }

            PositionTopCenter(_bar, target);
            _bar.Visible = true;

            _hideTimer?.Stop();
            _hideTimer = new Timer { Interval = 3000 };
            _hideTimer.Tick += (s, e) =>
            {
                if (_bar != null) _bar.Visible = false;
                _hideTimer?.Stop();
            };
            _hideTimer.Start();
        }

        private static void PositionTopCenter(NotificationBar bar, Form target)
        {
            int x = (target.ClientSize.Width - bar.Width) / 2;
            int y = 10;
            bar.Location = new Point(x, y);
        }
    }
}