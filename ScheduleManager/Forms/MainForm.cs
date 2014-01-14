using System;
using System.Collections;
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

        /// <summary>
        /// 画面内要素の値設定を行います。
        /// </summary>
        private void Init()
        {
            // システム日付取得(yyyy-mm-dd)
            string today = Common.getSystemDate();
            base.todayDate = today;
            SetAllTasksConfig();
            SetTodayTaskConfig(today);
            updateDisplayItem();
            createDateLabel.Text = today + createDateLabel.Text;
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
            // 当日が配列に含まれなければ
            if (Array.IndexOf(taskFiles, today) < 0)
            {
                base.editDateList = new string[taskFiles.Length + 1];
                taskFiles.CopyTo(editDateList, 0);
                new string[] { today }.CopyTo(editDateList, taskFiles.Length);
            }
            else
            {
                base.editDateList = taskFiles;
            }
            //base.editDateList = taskFiles.Length == 0 ? new string[] {today} :  
            this.oneDayCB.Items.AddRange(base.editDateList);
            if (editDateList.Length > 0)
            {
                this.oneDayCB.SelectedIndex = editDateList.Length - 1;
            }

            // 当日の予定読み込み、更新
            readTodayTaskList(today);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void taskUpdateButton_Click(object sender, EventArgs e)
        {
            //List<TaskElement> foreTask = new List<TaskElement>();
            //CheckedListBox.ObjectCollection items = foreCBL.Items;
            //IEnumerator iEnum = items.GetEnumerator();
            //iEnum.Reset();
            //while (iEnum.MoveNext())
            //{
            //    foreTask.Add(new TaskElement((string)iEnum.Current));
            //}

            // 午前
            // チェック済要素配列
            CheckedListBox.CheckedIndexCollection foreCheckedIndices = foreCBL.CheckedIndices;
            for (int i = 0; i < foreCBL.Items.Count; i++)
            {

                // checkされている項目修正
                if (foreCheckedIndices.IndexOf(i) >= 0)
                {
                    base.todayTask.ForeTaskBlock[i].CheckState = true;
                    // 未完了"□"なら修正
                    if (base.todayTask.ForeTaskBlock[i].Task.IndexOf(Common.STATE_IMPERFECT) >= 0)
                    {
                        base.todayTask.ForeTaskBlock[i].Task
                            = base.todayTask.ForeTaskBlock[i].Task.Replace(Common.STATE_IMPERFECT, Common.STATE_COMPLETE);
                    }
                }
                // checkされていない項目修正
                else
                {
                    base.todayTask.ForeTaskBlock[i].CheckState = false;
                    // 完了"■"なら修正
                    if (base.todayTask.ForeTaskBlock[i].Task.IndexOf(Common.STATE_COMPLETE) >= 0)
                    {
                        base.todayTask.ForeTaskBlock[i].Task
                            = base.todayTask.ForeTaskBlock[i].Task.Replace(Common.STATE_COMPLETE, Common.STATE_IMPERFECT);
                    }
                }
            }

            // 午後
            // チェック済要素配列
            CheckedListBox.CheckedIndexCollection afterCheckedIndices = afterCBL.CheckedIndices;
            for (int i = 0; i < afterCBL.Items.Count; i++)
            {

                // checkされている項目修正
                if (afterCheckedIndices.IndexOf(i) >= 0)
                {
                    base.todayTask.AfterTaskBlock[i].CheckState = true;
                    // 未完了"□"なら修正
                    if (base.todayTask.AfterTaskBlock[i].Task.IndexOf(Common.STATE_IMPERFECT) >= 0)
                    {
                        base.todayTask.AfterTaskBlock[i].Task
                            = base.todayTask.AfterTaskBlock[i].Task.Replace(Common.STATE_IMPERFECT, Common.STATE_COMPLETE);
                    }
                }
                // checkされていない項目修正
                else
                {
                    base.todayTask.AfterTaskBlock[i].CheckState = false;
                    // 完了"■"なら修正
                    if (base.todayTask.AfterTaskBlock[i].Task.IndexOf(Common.STATE_COMPLETE) >= 0)
                    {
                        base.todayTask.AfterTaskBlock[i].Task
                            = base.todayTask.AfterTaskBlock[i].Task.Replace(Common.STATE_COMPLETE, Common.STATE_IMPERFECT);
                    }
                }
            }

            // 当日タスク更新
            updateTodayTaskList();
            // ファイル反映
            FileConfig.writeTaskList(Path.Combine(new string[] { Common.TASKS_DIR, base.todayDate + Common.TXT_EXTENTION }), base.todayTask);
            updateDisplayItem();
        }

        private void readTodayTaskList(string today)
        {
            // 当日の予定表示
            string readFilePath = Path.Combine(new string[] { Common.TASKS_DIR, today + Common.TXT_EXTENTION });
            if (!File.Exists(readFilePath))
            {
                return;
            }
            TaskList taskList = FileConfig.readTaskList(readFilePath);

            // それぞれの予定取得
            List<TaskElement> foreList = taskList.ForeTaskBlock;
            List<TaskElement> afterList = taskList.AfterTaskBlock;

            // クラス変数に反映
            base.todayTask = new TaskList(foreList, afterList);
            //base.todayTask.ForeTaskBlock = foreList;
            //base.todayTask.AfterTaskBlock = afterList;

            // ListBoxに反映
            // 午前
            foreCBL.Items.Clear();
            foreach (TaskElement ts in foreList)
            {
                foreCBL.Items.Add(ts.Task, ts.CheckState);
            }

            // 午後
            afterCBL.Items.Clear();
            foreach (TaskElement ts in afterList)
            {
                afterCBL.Items.Add(ts.Task, ts.CheckState);
            }
            updateDisplayItem();
        }

        private void updateTodayTaskList()
        {
            // それぞれの予定取得
            List<TaskElement> foreList = base.todayTask.ForeTaskBlock;
            List<TaskElement> afterList = base.todayTask.AfterTaskBlock;

            // ListBoxに反映
            // 午前
            // リストボックス初期化
            foreCBL.Items.Clear();
            foreach (TaskElement ts in foreList)
            {
                foreCBL.Items.Add(ts.Task, ts.CheckState);
            }

            // 午後
            // リストボックス初期化
            afterCBL.Items.Clear();
            foreach (TaskElement ts in afterList)
            {
                afterCBL.Items.Add(ts.Task, ts.CheckState);
            }
            updateDisplayItem();
        }

        /// <summary>
        /// 当日タスクの作成画面を表示します。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createNewSucheduleButton_Click(object sender, EventArgs e)
        {
            CreateNewScheduleForm cnsf = new CreateNewScheduleForm(base.todayTask, base.todayDate);
            cnsf.ShowDialog();
            readTodayTaskList(base.todayDate);
        }

        private void createNewScheduleButton_Click(object sender, EventArgs e)
        {
            string foreTXT = foreNoonTB.Text;
            string[] foreAryData = foreTXT.Split(new string[] { Common.LINE_SEPARATOR }, StringSplitOptions.None);
            string afterTXT = afterNoonTB.Text;
            string[] afterAryData = afterTXT.Split(new string[] { Common.LINE_SEPARATOR }, StringSplitOptions.None);

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

            foreNoonTB.Text = String.Empty;
            afterNoonTB.Text = String.Empty;
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            updateTodayTaskList();
        }

        private void updateDisplayItem()
        {
            if (base.todayTask == null)
            {
                this.alertLabel.Visible = true;
                this.createNewSucheduleButton.Text = "新規作成";
                this.afterAchievementLevel.Text = " 0/ 0   0%";
                this.foreAchievementLevel.Text = " 0/ 0   0%";
            }
            else
            {
                this.alertLabel.Visible = false;
                this.createNewSucheduleButton.Text = "編集";
                
                // 要素数カウント
                int cntAllFore = base.todayTask.ForeTaskBlock.Count;
                int cntAllAfter = base.todayTask.AfterTaskBlock.Count;
                // チェック数カウント
                int cntFore = base.todayTask.CountForeTaskLevel();
                int cntAfter = base.todayTask.CountAfterTaskLevel();

                this.foreAchievementLevel.Text = String.Format("{0:D2}/{1:D2} {2,3}%", cntFore, cntAllFore, cntFore * 100 / cntAllFore);
                this.afterAchievementLevel.Text = String.Format("{0:D2}/{1:D2} {2,3}%", cntAfter, cntAllAfter, cntAfter * 100 / cntAllAfter);
            }
        }
    }
}
