using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ScheduleManager
{
    public partial class CreateNewScheduleForm : BaseForm
    {
        public CreateNewScheduleForm(TaskList taskList, string today)
        {
            InitializeComponent();
            base.todayTask = taskList;
            base.todayDate = today;
            Init();
        }

        /// <summary>
        /// 画面表示時に初期化を行います。
        /// </summary>
        private void Init()
        {
            // 表示テキストを初期化
            this.createDateLabel.Text = base.todayDate + this.createDateLabel.Text;
            // 予定項目更新
            if (base.todayTask == null)
            {
                return;
            }
            this.foreTB.Text = Common.TaskBlockToString(todayTask.ForeTaskBlock);
            this.afterTB.Text = Common.TaskBlockToString(todayTask.AfterTaskBlock);

        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            //string fore = foreTB.Text;
            string foreTXT = foreTB.Text;
            string[] foreAryData = foreTXT.Split(new string[] { Common.LINE_SEPARATOR }, StringSplitOptions.RemoveEmptyEntries);
            string afterTXT = afterTB.Text;
            string[] afterAryData = afterTXT.Split(new string[] { Common.LINE_SEPARATOR }, StringSplitOptions.RemoveEmptyEntries);

            List<TaskElement> foreList = new List<TaskElement>();
            foreach (string foreData in foreAryData)
            {
                bool checkstate = foreData.IndexOf(Common.STATE_IMPERFECT) >= 0 ? false : true;
                foreList.Add(new TaskElement(foreData, checkstate));
            }

            List<TaskElement> afterList = new List<TaskElement>();
            foreach (string afterData in afterAryData)
            {
                bool checkstate = afterData.IndexOf(Common.STATE_IMPERFECT) >= 0 ? false : true;
                afterList.Add(new TaskElement(afterData, checkstate));
            }

            todayTask = new TaskList(foreList, afterList);

            FileConfig.writeTaskList(Path.Combine(new string[] { Common.TASKS_DIR, base.todayDate + Common.TXT_EXTENTION }), base.todayTask);

            this.Close();
        }
    }
}
