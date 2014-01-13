using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ScheduleManager
{
    public partial class CreateNewScheduleForm : BaseForm
    {
        public CreateNewScheduleForm()
        {
            InitializeComponent();
            this.createDateLabel.Text = base.today + this.createDateLabel.Text;
        }

        private void CreateNewScheduleForm_Load(object sender, EventArgs e)
        {
            //this.createDateLabel.Text = base.today + this.createDateLabel.Text;
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            string fore = foreTB.Text;
        }
    }
}
