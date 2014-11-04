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

        private bool foreTBEmpty = false;
        private bool afterTBEmpty = false;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="taskList">タスクリスト</param>
        /// <param name="today">編集日付</param>
        public CreateNewScheduleForm(TaskList taskList, string today)
        {
            InitializeComponent();
            base.todayTask = taskList;
            base.todayDate = today;
            Init();
        }

        ///// <summary>
        ///// デストラクタ
        ///// </summary>
        //~CreateNewScheduleForm()
        //{
        //    if (todayTask != null)
        //    {
        //        if (todayTask.ForeTaskBlock != null)
        //        {
        //            base.todayTask.ForeTaskBlock.Clear();
        //        }
        //        if (todayTask.AfterTaskBlock != null)
        //        {
        //            base.todayTask.AfterTaskBlock.Clear();
        //        }
        //    }
        //}

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
            string title;
            // 表示テキストを初期化
            if (taskList.ForeTaskBlock == null && taskList.AfterTaskBlock == null)
            {
                displayLabel = base.todayDate + MESSAGE_CREATE;
                displayButtonText = TXT_CREATE;
                title = "CreateSchedule";
            }
            else
            {
                displayLabel = base.todayDate + MESSAGE_EDIT;
                displayButtonText = TXT_EDIT;
                title = "EditSchedule";
            }
            this.createDateLabel.Text = displayLabel;
            this.createButton.Text = displayButtonText;
            this.Text = title;
        }

        /// <summary>
        /// 予定の新規作成を行います。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createButton_Click(object sender, EventArgs e)
        {
            TaskBlock foreList = BlockToList(foreTB.Text);
            TaskBlock afterList = BlockToList(afterTB.Text);

            todayTask = new TaskList(foreList, afterList);

            if (!todayTask.isBothElementZero())
            {
                FileConfig.writeTaskList(Path.Combine(new string[] { Common.TASKS_DIR, Common.TASK_FILES, base.todayDate + Common.TXT_EXTENTION }), base.todayTask);
            }
            this.Close();
        }

        /// <summary>
        /// stringの文字列を1行ごとにTaskBlockに格納していきます。
        /// </summary>
        /// <param name="strData"></param>
        /// <returns></returns>
        private TaskBlock BlockToList(string strData)
        {
            string[] tasks = strData.Split(new string[] { Common.LINE_SEPARATOR }, StringSplitOptions.RemoveEmptyEntries);

            TaskBlock taskBlock = new TaskBlock();
            foreach (string task in tasks)
            {
                if (task.Replace(" ", "").Replace("　", "") == "") continue;
                bool checkstate = task.IndexOf(Common.STATE_IMPERFECT) >= 0 ? false : true;
                taskBlock.Add(new TaskElement(task, checkstate));
            }
            return taskBlock;
        }

        /// <summary>
        /// テキストボックスの入力チェックを行います。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void foreTB_TextChanged(object sender, EventArgs e)
        {
            int foreLength = foreTB.Text.Length;
            this.foreTBEmpty = foreLength > 0 ? true : false;
            CreateButtonControl();
        }

        /// <summary>
        /// テキストボックスの入力チェックを行います。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void afterTB_TextChanged(object sender, EventArgs e)
        {
            int afterLength = afterTB.Text.Length;
            this.afterTBEmpty = afterLength > 0 ? true : false;
            CreateButtonControl();
        }

        /// <summary>
        /// 新規作成ボタンの制御
        /// </summary>
        private void CreateButtonControl()
        {
            this.createButton.Enabled = this.foreTBEmpty || this.afterTBEmpty;
        }

        /// <summary>
        /// キャンセルボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
