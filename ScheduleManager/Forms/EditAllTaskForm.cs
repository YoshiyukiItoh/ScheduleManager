﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ScheduleManager.Forms
{
    public partial class EditAllTaskForm : Form
    {
        public EditAllTaskForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// キャンセルボタン。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
