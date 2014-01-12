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
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            // システム日付取得(yyyy-mm-dd)
            string today = Common.getSystemDate();

            SetAllTasksConfig();
            SetTodayTaskConfig(today);
        }

        private void SetAllTasksConfig()
        {
            // 読み込みファイルパス作成
            string ALL_TASKS_FILEPATH = Path.Combine(new string[] {Common.TASKS_DIR, Common.ALL_TASK_FILE});
        }

        private void SetTodayTaskConfig(string today)
        {
            // 読み込みファイルパス作成
            string TODAY_TASK_FILEPATH = Path.Combine(new string[] {Common.TASKS_DIR, today + Common.TXT_EXTENTION});

            if (File.Exists(TODAY_TASK_FILEPATH))
            {
                // ファイルが存在したら
                this.alertLabel.Visible = false;
                todayTask = FileConfig.readTaskList(TODAY_TASK_FILEPATH);
            }
            else
            {
                this.alertLabel.Visible = true;
            }

            // タスクファイル名一覧取得
            string[] taskFiles = Common.getTaskFiles();
            this.oneDayCB.Items.AddRange(taskFiles);
            if (taskFiles.Length > 0)
            {
                this.oneDayCB.SelectedIndex = taskFiles.Length - 1;
            }

            // 当日の予定表示
            TaskList taskList = FileConfig.readTaskList(Path.Combine(new string[] {Common.TASKS_DIR, today + Common.TXT_EXTENTION}));

            // それぞれの予定取得
            List<TaskState> foreList = taskList.ForeTaskBlock;
            List<TaskState> afterList = taskList.AfterTaskBlock;

            // ListBoxに反映
            // 午前
            foreach (TaskState ts in foreList)
            {
                foreCBL.Items.Add(ts.Task, ts.CheckState);
            }

            // 午後
            foreach (TaskState ts in afterList)
            {
               afterCBL.Items.Add(ts.Task, ts.CheckState);
            }
        }
    }
}
