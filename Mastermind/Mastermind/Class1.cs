using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mastermind
{
    internal class Class1
    {
        public static class MessageBoxHelper
        {
            const string _defaultCaption = "Message";
            const MessageBoxButtons _defaultButtons = MessageBoxButtons.OK;

            public static void Show(string message, MessageBoxIcon icon)
            {
                MessageBox.Show(message, _defaultCaption, _defaultButtons, icon);
            }
        }
    }
}
