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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //string stCurrentDir = System.IO.Directory.GetCurrentDirectory();
            //foreTextBox.Text = FileConfig.readConfig(Path.Combine(stCurrentDir,"a.txt"));
            foreTextBox.Text = FileConfig.readConfig("a.txt", Common.FORE_TAG);
            afterTextBox.Text = FileConfig.readConfig("a.txt", Common.AFTER_TAG);
        }
    }
}
