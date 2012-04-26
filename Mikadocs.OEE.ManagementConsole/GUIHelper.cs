using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mikadocs.OEE.ManagementConsole
{
    static class GUIHelper
    {
        const int maximizeValue = 8;

        public static void MaximizeButton(Button currentButton)
        {
            try
            {
                Point currentLocation = new System.Drawing.Point(currentButton.Location.X, currentButton.Location.Y);

                currentLocation.X = currentLocation.X - (maximizeValue / 2);
                currentLocation.Y = currentLocation.Y - (maximizeValue / 2);
                currentButton.Location = currentLocation;
                currentButton.Width = currentButton.Width + maximizeValue;
                currentButton.Height = currentButton.Height + maximizeValue;

                currentButton.BringToFront();
            }
            catch (Exception) { }

        }

        public static void MinimizeButton(Button currentButton)
        {
            try
            {
                Point currentLocation = new System.Drawing.Point(currentButton.Location.X, currentButton.Location.Y);

                currentButton.Width = currentButton.Width - maximizeValue;
                currentButton.Height = currentButton.Height - maximizeValue;
                currentLocation.X = currentLocation.X + (maximizeValue / 2);
                currentLocation.Y = currentLocation.Y + (maximizeValue / 2);
                currentButton.Location = currentLocation;

                currentButton.BringToFront();
            }
            catch (Exception) { }
        }
    }
}
