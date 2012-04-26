using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mikadocs.OEE.DataEntry
{
    static class GUIHelper
    {
        const int MaximizeValue = 24;

        public static void MaximizeButton(Button currentButton)
        {
            try
            {
                Point currentLocation = new System.Drawing.Point(currentButton.Location.X, currentButton.Location.Y);

                currentLocation.X = currentLocation.X - (MaximizeValue / 2);
                currentLocation.Y = currentLocation.Y - (MaximizeValue / 2);
                currentButton.Location = currentLocation;
                currentButton.Width = currentButton.Width + MaximizeValue;
                currentButton.Height = currentButton.Height + MaximizeValue;

                currentButton.BringToFront();
            }
            catch (Exception) { }

        }

        public static void MinimizeButton(Button currentButton)
        {
            try
            {
                Point currentLocation = new System.Drawing.Point(currentButton.Location.X, currentButton.Location.Y);

                currentButton.Width = currentButton.Width - MaximizeValue;
                currentButton.Height = currentButton.Height - MaximizeValue;
                currentLocation.X = currentLocation.X + (MaximizeValue / 2);
                currentLocation.Y = currentLocation.Y + (MaximizeValue / 2);
                currentButton.Location = currentLocation;

                currentButton.BringToFront();
            }
            catch (Exception) { }
        }
    }
}
