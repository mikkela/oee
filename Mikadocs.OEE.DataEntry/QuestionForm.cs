using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mikadocs.OEE.DataEntry
{
    public partial class QuestionForm : Form
    {
        public QuestionForm()
        {
            InitializeComponent();            
        }

        public static DialogResult ShowQuestion(string header, string message)
        {
            using (QuestionForm f = new QuestionForm())
            {
                f.lblHeader.Text = header;
                f.txtMessage.Text = message;

                return f.ShowDialog();
            }
        }

        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            GUIHelper.MaximizeButton(sender as Button);
        }

        private void OnMouseUp(object sender, MouseEventArgs e)
        {
            GUIHelper.MinimizeButton(sender as Button);
        }
    }
}
