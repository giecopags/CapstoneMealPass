using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraEditors;
using System.Drawing;

namespace CapstoneMealPass.Helpers
{
    public class TextHelper
    {
        public static void AttachBehavior(TextEdit textEdit, string defaultText, bool isPassword = false)
        {
            textEdit.Text = defaultText;
            textEdit.ForeColor = Color.DarkGray;
            textEdit.Properties.UseSystemPasswordChar = false;

            textEdit.Enter += (s, e) =>
            {
                if (textEdit.Text == defaultText)
                {
                    textEdit.Text = "";
                    textEdit.ForeColor = Color.Black;

                    if (isPassword)
                        textEdit.Properties.UseSystemPasswordChar = true;
                }
            };

            textEdit.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(textEdit.Text))
                {
                    textEdit.Text = defaultText;
                    textEdit.ForeColor = Color.DarkGray;
                    if (isPassword)
                        textEdit.Properties.UseSystemPasswordChar = false;
                }
            };

            textEdit.EditValueChanged += (s, e) =>
            {
                if (textEdit.Text != defaultText)
                {
                    textEdit.ForeColor = Color.DarkGray;
                    if (isPassword)
                        textEdit.Properties.UseSystemPasswordChar = true;
                }
            };
        }

        public static void AttachPasswordBehavior(TextEdit textEdit, string placeholder, CheckEdit showCheck)
        {
            textEdit.Text = placeholder;
            textEdit.ForeColor = Color.DarkGray;
            textEdit.Properties.UseSystemPasswordChar = false;

            textEdit.Enter += (s, e) =>
            {
                if (textEdit.Text == placeholder)
                {
                    textEdit.Text = "";
                    textEdit.ForeColor = Color.DarkGray;

                    textEdit.Properties.UseSystemPasswordChar = !showCheck.Checked;
                }
            };

            textEdit.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(textEdit.Text))
                {
                    textEdit.Text = placeholder;
                    textEdit.ForeColor = Color.DarkGray;
                    textEdit.Properties.UseSystemPasswordChar = false;
                }
            };

            showCheck.CheckedChanged += (s, e) =>
            {
                if (textEdit.Text != placeholder)
                    textEdit.Properties.UseSystemPasswordChar = !showCheck.Checked;
            };
        }
    }
}
