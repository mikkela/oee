using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mikadocs.OEE.DataEntry
{
    public partial class TimeEntryUserControl : UserControl
    {
        public TimeEntryUserControl()
        {
            InitializeComponent();
            Value = DateTime.Now.TimeOfDay;
        }

        public TimeSpan Value
        {
            get { return new TimeSpan(Hours, Minutes, 0); }
            set {
                hoursTextBox.Text = value.Hours.ToString();
                minutesTextBox.Text = value.Minutes.ToString();
            }
        }

        private int Hours
        {
            get { return int.Parse(hoursTextBox.Text); }
        }

        private int Minutes
        {
            get { return int.Parse(minutesTextBox.Text); }
        }

        private void OnTextBoxKeyPressed(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void OnTextBoxEnter(object sender, EventArgs e)
        {
            ((TextBox)sender).SelectAll();
        }

        private void OnValidatingHour(object sender, CancelEventArgs e)
        {
            ClearErrorProvider();

            if (0 <= Hours &&
                Hours <= 23)
                return;

            NotifyOfInvalidHour();
            CancelEvent(e);
        }

        private void OnValidatingMinutes(object sender, CancelEventArgs e)
        {
            ClearErrorProvider();

            if (0 <= Minutes &&
                Minutes <= 59)
                return;

            NotifyOfInvalidMinutes();
            CancelEvent(e);
        }

        private void NotifyOfInvalidHour()
        {
            errorProvider.SetError(hoursTextBox, Strings.InvalidTime);
        }

        private void NotifyOfInvalidMinutes()
        {
            errorProvider.SetError(minutesTextBox, Strings.InvalidTime);
        }

        private void CancelEvent(CancelEventArgs args)
        {
            args.Cancel = true;
        }

        private void ClearErrorProvider()
        {
            errorProvider.Clear();
        }
    }
}
