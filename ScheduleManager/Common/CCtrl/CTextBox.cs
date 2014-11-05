using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ScheduleManager
{
    class CTextBox:TextBox
    {
        public CTextBox()
        {
            cstmComponent();
        }

        private void cstmComponent()
        {
            this.KeyDown += new KeyEventHandler(csTextBox_keyDown);
            this.ScrollBars = ScrollBars.Vertical;
            this.Multiline = true;
        }

        private void csTextBox_keyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.A && e.Control == true)
            {
                this.SelectAll();
            }
        }
    }
}
