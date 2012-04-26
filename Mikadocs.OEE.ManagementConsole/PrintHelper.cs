using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Mikadocs.OEE.ManagementConsole
{
    class PrintHelper
    {
        private int y;
        private Graphics g;
        private Rectangle bounds;

        public PrintHelper(Graphics g, Rectangle bounds)
        {
            this.g = g;
            this.bounds = bounds;
            y = bounds.Y;
        }

        public int Y
        {
            get { return y; }
        }

        public void DrawValues(IEnumerable<Pair<string, string>> values)
        {
            using (Font f = CreateFont())
            {
                int x = bounds.Left;
                List<Pair<String, String>> list = new List<Pair<string, string>>(values);
                int step = bounds.Width / list.Count;
                foreach (Pair<string, string> value in list)
                {
                    int length = (int)g.MeasureString(value.Second, f).Width + 10;

                    g.DrawString(value.First, f, Brushes.DarkGray, x, y);
                    g.DrawString(value.Second, f, Brushes.DarkGray, x + step - length, y);

                    x += step;
                }

                y += f.Height + 5;
            }
        }
       
        private Font CreateFont()
        {
            return new Font(FontFamily.GenericSansSerif, 14, FontStyle.Bold);
        }
    }
}
