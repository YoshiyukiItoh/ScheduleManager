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
        private const string TXT_CREATE = "作成";
        private const string TXT_EDIT = "変更";
        private const string MESSAGE_CREATE = "の予定を作成します。";
        private const string MESSAGE_EDIT = "の予定を編集します。";

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
            updateCreateDateLabel(base.todayTask);
            // 予定項目更新
            if (base.todayTask == null)
            {
                return;
            }
            this.foreTB.Text = Common.TaskBlockToString(todayTask.ForeTaskBlock);
            this.afterTB.Text = Common.TaskBlockToString(todayTask.AfterTaskBlock);

        }

        /// <summary>
        /// 表示するメッセージを変更します。
        /// </summary>
        /// <param name="taskList">表示するタスクリスト</param>
        private void updateCreateDateLabel(TaskList taskList)
        {
            string displayLabel;
            string displayButtonText;
            // 表示テキストを初期化
            if (taskList == null)
            {
                displayLabel = base.todayDate + MESSAGE_CREATE;
                displayButtonText = TXT_CREATE;
            }
            else
            {
                displayLabel = base.todayDate + MESSAGE_EDIT;
                displayButtonText = TXT_EDIT;
            }
            this.createDateLabel.Text = displayLabel;
            this.CreateButton.Text = displayButtonText;
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            string foreTXT = foreTB.Text;
            string[] foreAryData = foreTXT.Split(new string[] { Common.LINE_SEPARATOR }, StringSplitOptions.RemoveEmptyEntries);
            string afterTXT = afterTB.Text;
            string[] afterAryData = afterTXT.Split(new string[] { Common.LINE_SEPARATOR }, StringSplitOptions.RemoveEmptyEntries);

            TaskBlock foreList = BlockToList(foreTB.Text);
            TaskBlock afterList = BlockToList(afterTB.Text);

            todayTask = new TaskList(foreList, afterList);

            FileConfig.writeTaskList(Path.Combine(new string[] { Common.TASKS_DIR, base.todayDate + Common.TXT_EXTENTION }), base.todayTask);

            this.Close();
        }

        private TaskBlock BlockToList(string strData)
        {
            string[] tasks = strData.Split(new string[] { Common.LINE_SEPARATOR }, StringSplitOptions.RemoveEmptyEntries);

            TaskBlock taskBlock = new TaskBlock();
            foreach (string task in tasks)
            {
                bool checkstate = task.IndexOf(Common.STATE_IMPERFECT) >= 0 ? false : true;
                taskBlock.Add(new TaskElement(task, checkstate));
            }
            return taskBlock;
        }
    }
}
