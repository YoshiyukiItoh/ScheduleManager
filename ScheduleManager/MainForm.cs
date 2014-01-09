using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ScheduleManager
{
    public partial class MainForm : BaseForm
    {
        public MainForm()
        {
            InitializeComponent();
            //string stCurrentDir = System.IO.Directory.GetCurrentDirectory();
            //foreTextBox.Text = FileConfig.readConfig(Path.Combine(stCurrentDir,"a.txt"));
            foreTextBox.Text = FileConfig.readConfig("a.txt", Common.FORE_TAG);
            foreCBL.Items.AddRange(FileConfig.readConfigAry("a.txt", Common.FORE_TAG));
            afterTextBox.Text = FileConfig.readConfig("a.txt", Common.AFTER_TAG);
            afterCBL.Items.AddRange(FileConfig.readConfigAry("a.txt", Common.AFTER_TAG));
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            this.textBox1.Text = e.Start.ToString() + Common.LINE_SEPARATOR + e.End.ToString();
        }
    }
}
