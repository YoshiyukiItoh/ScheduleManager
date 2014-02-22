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
            logger.Info("MainForm起動");
            InitializeComponent();
            Init();
            createCalender();
        }

        /// <summary>
        /// 画面内要素の値設定を行います。
        /// </summary>
        private void Init()
        {
            // システム日付取得(yyyy-mm-dd)
            string today = Common.getSystemDate();
            base.todayDate = today;
            base.selectedDate = today;
            // 全タスクタブ情報更新
            SetAllTasksConfig();
            // 当日タブ情報更新
            SetTodayTaskConfig(today);
            updateDisplayItem();
            makeForeListView();
        }

        private void SetAllTasksConfig()
        {
            // 読み込みファイルパス作成
            AllTasksListBox.Items.Clear();
            string ALL_TASKS_FILEPATH = Path.Combine(new string[] {Common.TASKS_DIR, Common.ALL_TASK_FILE});

            if (File.Exists(ALL_TASKS_FILEPATH))
            {
                base.alltasks = FileConfig.readAllTask(ALL_TASKS_FILEPATH);
            }
            else
            {
                base.alltasks = null;
            }

            // 全タスク反映
            if (base.alltasks != null)
            {
                AllTasksListBox.Items.Clear();
                AllTasksListBox.Items.AddRange(base.alltasks);
            }
        }

        private void SetTodayTaskConfig(string today)
        {
            // 読み込みファイルパス作成
            string TODAY_TASK_FILEPATH = Path.Combine(new string[] { Common.TASKS_DIR, Common.TASK_FILES, today + Common.TXT_EXTENTION });

            if (File.Exists(TODAY_TASK_FILEPATH))
            {
                // ファイルが存在したら
                this.alertLabel.Visible = false;
                todayTask = FileConfig.readTaskList(TODAY_TASK_FILEPATH);
            }
            else
            {
                this.alertLabel.Visible = true;
                todayTask = new TaskList();
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

            Array.Sort(editDateList);
            // 要素を一時削除
            this.oneDayCB.Items.Clear();
            // プルダウンに日付一覧を追加
            this.oneDayCB.Items.AddRange(base.editDateList);
            if (editDateList.Length > 0)
            {
                // TODO 位置指定
                int index = 0;
                for (int i = 0; i < editDateList.Length; i++ )
                {
                    if (String.Equals(editDateList[i], base.selectedDate))
                    {
                        index = i;
                        break;
                    }
                }
                this.oneDayCB.SelectedIndex = index;
            }

            // 当日の予定読み込み、更新
            readTodayTaskList(today);
        }

        /// <summary>
        /// タスクの状態変更をします。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void taskUpdateButton_Click(object sender, EventArgs e)
        {
            // TODO 関数に抜き出す

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
            logger.Info("当日午前タスク更新");

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
            logger.Info("当日午前タスク更新");

            // 当日タスク更新
            updateTodayTaskList();
            // ファイル反映
            FileConfig.writeTaskList(Path.Combine(new string[] { Common.TASKS_DIR, Common.TASK_FILES, base.selectedDate + Common.TXT_EXTENTION }), base.todayTask);
            updateDisplayItem();
            logger.Info("当日タスクファイル更新 日付：" + base.selectedDate);
        }

        private void readTodayTaskList(string today)
        {
            // 当日の予定表示
            string readFilePath = Path.Combine(new string[] { Common.TASKS_DIR, Common.TASK_FILES, today + Common.TXT_EXTENTION });
            if (!File.Exists(readFilePath))
            {
                todayTask = new TaskList();
                updateTodayTaskList();
                updateDisplayItem();
                return;
            }
            TaskList taskList = FileConfig.readTaskList(readFilePath);

            // それぞれの予定取得
            TaskBlock foreList = taskList.ForeTaskBlock;
            TaskBlock afterList = taskList.AfterTaskBlock;

            // クラス変数に反映
            base.todayTask = new TaskList(foreList, afterList);

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
            TaskBlock foreList = base.todayTask.ForeTaskBlock;
            TaskBlock afterList = base.todayTask.AfterTaskBlock;

            // ListBoxに反映
            // 午前
            updateRowItems(foreList, ref foreCBL);
            // 午後
            updateRowItems(afterList, ref afterCBL);
            updateDisplayItem();
        }

        private void updateRowItems(TaskBlock taskBlock, ref CheckedListBox checkedListBox)
        {
            // リストボックス初期化
            checkedListBox.Items.Clear();
            if (taskBlock != null)
            {
                foreach (TaskElement ts in taskBlock)
                {
                    checkedListBox.Items.Add(ts.Task, ts.CheckState);
                }
            }
        }

        /// <summary>
        /// 当日タスクの作成画面を表示します。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createNewSucheduleButton_Click(object sender, EventArgs e)
        {
            CreateNewScheduleForm cnsf = new CreateNewScheduleForm(base.todayTask, base.selectedDate);
            cnsf.ShowDialog();
            readTodayTaskList(base.selectedDate);
        }

        private void updateDisplayItem()
        {
            if (base.todayTask.isBothEmpty())
            {
                this.alertLabel.Visible = true;
                this.createNewScheduleButton.Text = "新規作成";
            }
            else
            {
                this.alertLabel.Visible = false;
                this.createNewScheduleButton.Text = "編集";
            }
            // 当日タスク達成率更新
            rewriteCompleteLabel(todayTask.ForeTaskBlock, ref foreCompleteLavel);
            rewriteCompleteLabel(todayTask.AfterTaskBlock, ref afterCompleteLavel);
        }

        /// <summary>
        /// 達成率の更新を行います。
        /// </summary>
        /// <param name="taskBlock"></param>
        /// <param name="label"></param>
        private void rewriteCompleteLabel(TaskBlock taskBlock, ref Label label)
        {
            if (taskBlock != null && taskBlock.Count > 0)
            {
                int cntAllElement = taskBlock.Count();
                int checkedElement = taskBlock.getCheckedTaskCount();

                label.Text = String.Format("{0:D2}/{1:D2} {2,3}%", checkedElement, cntAllElement, checkedElement * 100 / cntAllElement);
                return;
            }

            label.Text = String.Format("{0:D2}/{1:D2} {2,3}%", 0, 0, 0);
        }

        /// <summary>
        /// コンボボックスの値が変更されたら、
        /// 対応する予定ファイルの再読み込みを行います。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void oneDayCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            base.selectedDate = (string)this.oneDayCB.SelectedItem;
            if (String.IsNullOrEmpty(selectedDate))
            {
                return;
            }
            readTodayTaskList(this.selectedDate);
        }

        /// <summary>
        /// 翌日の予定ファイルを作成します。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createNextDayScheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            base.selectedDate = Common.getNextDay();
            CreateNewScheduleForm cnsf = new CreateNewScheduleForm(base.todayTask, base.selectedDate);
            cnsf.ShowDialog();
            SetTodayTaskConfig(base.selectedDate);
        }

        /// <summary>
        /// 全タスクの更新処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void reloadButton_Click(object sender, EventArgs e)
        {
            SetAllTasksConfig();
        }

        /// <summary>
        /// 全タスクの編集処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditAllTaskButton_Click(object sender, EventArgs e)
        {
            EditAllTaskForm form = new EditAllTaskForm(base.alltasks);
            form.ShowDialog();
            SetAllTasksConfig();
        }

        // カレンダの作成処理
        private void createCalender()
        {
            // 曜日ラベル作成
            makeWeekLabel();
            // 左側のカレンダ情報作成
            base.leftCalInfo = new CalInfo();
            base.leftCalInfo.year = int.Parse(base.todayDate.Split('-')[0]);
            base.leftCalInfo.month = int.Parse(base.todayDate.Split('-')[1]);
            // 右側のカレンダ情報作成
            base.rightCalInfo = SetCalInfo(base.leftCalInfo, calCtl.next);
            // カレンダ作成
            makeCalender(base.rightCalInfo.year, base.rightCalInfo.month, ref this.rightGroupBox, ref base.rightCalender, ref base.leftWeekLabel);
            makeCalender(base.leftCalInfo.year, base.leftCalInfo.month, ref this.leftGroupBox, ref base.leftCalender, ref base.rightWeekLabel);
        }

        private void makeCalender(int year, int month, ref GroupBox groupBox, ref List<Control> lC, ref List<Label> ltB)
        {
            // 既存コントロール削除
            groupBox.Controls.Clear();

            groupBox.Text = String.Format("{0}年{1:D2}月", year, month);
            int w = 0;
            int e = 0;
            w = Common.week_of_day(year, month, 1);       /* 1日の曜日を求める */
            e = Common.month_last_day(year, month);       /* 月の最終日を求める */
            lC = new List<Control>();
            lC.AddRange(ltB.ToArray());

            for (int i = 1; i <= e; i++, w++)
            {
                TextBox tBox = new TextBox();
                tBox.Text = String.Format("{0:D2}", i);
                tBox.Location = new Point(7 + (w % 7) * 30, 30 + (w / 7) * 21);
                tBox.Size = new Size(17, 7);
                if (w % 7 == 0) tBox.ForeColor = Color.Red;
                else if (w % 7 == 6) tBox.ForeColor = Color.Blue;
                else tBox.ForeColor = Color.Black;
                lC.Add(tBox);
            }
            groupBox.Controls.AddRange(lC.ToArray());
        }

        /// <summary>
        /// カレンダ情報の作成を行います。
        /// </summary>
        /// <param name="year">計算ベースとする年</param>
        /// <param name="month">計算ベースとする月</param>
        /// <param name="prevNextFlg"></param>
        /// <param name="calInfo"></param>
        private CalInfo SetCalInfo(CalInfo calInfo, calCtl flg)
        {
            CalInfo retCalInfo = new CalInfo();
            int retmonth = 0;
            // 前月の場合
            if (flg == calCtl.prev)
            {
                retmonth = calInfo.month - 1;
                switch (retmonth)
                {
                    case 0:
                        retCalInfo.month = 12;
                        retCalInfo.year = calInfo.year - 1;
                        break;
                    default:
                        retCalInfo.month = retmonth;
                        retCalInfo.year = calInfo.year;
                        break;
                }
            }
            else
            {
                retmonth = calInfo.month + 1;
                switch (retmonth)
                {
                    case 13:
                        retCalInfo.month = 1;
                        retCalInfo.year = calInfo.year + 1;
                        break;
                    default:
                        retCalInfo.month = retmonth;
                        retCalInfo.year = calInfo.year;
                        break;
                }
            }
            return retCalInfo;
        }

        private void makeWeekLabel()
        {
            if (base.leftWeekLabel == null && base.rightWeekLabel == null)
            {
                base.leftWeekLabel = new List<Label>();
                base.rightWeekLabel = new List<Label>();
                for (int i = 0; i < 7; i++)
                {
                    Label leftWorkLabel = new Label();
                    Label rightWorkLabel = new Label();
                    leftWorkLabel.Size = new Size(17, 12);
                    leftWorkLabel.Text = "日";
                    leftWorkLabel.Location = new Point(i * 30 + 7, 15);
                    leftWorkLabel.Visible = true;
                    rightWorkLabel.Size = new Size(17, 12);
                    rightWorkLabel.Text = "日";
                    rightWorkLabel.Location = new Point(i * 30 + 7, 15);
                    rightWorkLabel.Visible = true;
                    switch (i)
                    {
                        case 0:
                            leftWorkLabel.Text = "日";
                            leftWorkLabel.ForeColor = Color.Red;
                            rightWorkLabel.Text = "日";
                            rightWorkLabel.ForeColor = Color.Red;
                            break;
                        case 1:
                            leftWorkLabel.Text = "月";
                            rightWorkLabel.Text = "月";
                            break;
                        case 2:
                            leftWorkLabel.Text = "火";
                            rightWorkLabel.Text = "火";
                            break;
                        case 3:
                            leftWorkLabel.Text = "水";
                            rightWorkLabel.Text = "水";
                            break;
                        case 4:
                            leftWorkLabel.Text = "木";
                            rightWorkLabel.Text = "木";
                            break;
                        case 5:
                            leftWorkLabel.Text = "金";
                            rightWorkLabel.Text = "金";
                            break;
                        case 6:
                            leftWorkLabel.Text = "土";
                            leftWorkLabel.ForeColor = Color.Blue;
                            rightWorkLabel.Text = "土";
                            rightWorkLabel.ForeColor = Color.Blue;
                            break;
                        default:
                            break;
                    }
                    base.leftWeekLabel.Add(leftWorkLabel);
                    base.rightWeekLabel.Add(rightWorkLabel);
                }
            }
        }

        /// <summary>
        /// TODO
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void foreAllCB_CheckedChanged(object sender, EventArgs e)
        {
            bool checkflg = foreAllCB.Checked;

            if (base.todayTask.ForeTaskBlock == null)
            {
                return;
            }

            for (int i = 0; i < base.todayTask.ForeTaskBlock.Count; i++)
            {
                if (checkflg) base.todayTask.ForeTaskBlock[i].CheckState = true;
                else
                {
                    if (base.todayTask.ForeTaskBlock[i].Task.IndexOf(Common.STATE_COMPLETE) < 0) base.todayTask.ForeTaskBlock[i].CheckState = false;
                }
            }

            updateRowItems(base.todayTask.ForeTaskBlock, ref foreCBL);
        }

        /// <summary>
        /// TODO
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void afterAllCB_CheckedChanged(object sender, EventArgs e)
        {
            bool checkflg = afterAllCB.Checked;

            if (base.todayTask.AfterTaskBlock == null)
            {
                return;
            }

            for (int i = 0; i < base.todayTask.AfterTaskBlock.Count; i++)
            {
                if (checkflg) base.todayTask.AfterTaskBlock[i].CheckState = true;
                else
                {
                    if (base.todayTask.AfterTaskBlock[i].Task.IndexOf(Common.STATE_COMPLETE) < 0) base.todayTask.AfterTaskBlock[i].CheckState = false;
                }
            }

            updateRowItems(base.todayTask.AfterTaskBlock, ref afterCBL);
        }

        private void updateAllCB(bool flg, ref TaskBlock tb)
        {
            if (tb == null)
            {
                return;
            }

            for (int i = 0; i < tb.Count; i++)
            {
                if (flg) tb[i].CheckState = true;
                else
                {
                    if (tb[i].Task.IndexOf(Common.STATE_COMPLETE) < 0) tb[i].CheckState = false;
                }
            }
        }

        private void PrevButton_Click(object sender, EventArgs e)
        {
            base.rightCalInfo = base.leftCalInfo;
            base.leftCalInfo = SetCalInfo(base.rightCalInfo, calCtl.prev);
            // カレンダ作成
            makeCalender(base.rightCalInfo.year, base.rightCalInfo.month, ref this.rightGroupBox, ref base.rightCalender, ref base.leftWeekLabel);
            makeCalender(base.leftCalInfo.year, base.leftCalInfo.month, ref this.leftGroupBox, ref base.leftCalender, ref base.rightWeekLabel);
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            base.leftCalInfo = base.rightCalInfo;
            base.rightCalInfo = SetCalInfo(base.leftCalInfo, calCtl.next);
            // カレンダ作成
            makeCalender(base.rightCalInfo.year, base.rightCalInfo.month, ref this.rightGroupBox, ref base.rightCalender, ref base.leftWeekLabel);
            makeCalender(base.leftCalInfo.year, base.leftCalInfo.month, ref this.leftGroupBox, ref base.leftCalender, ref base.rightWeekLabel);

        }

        private void makeForeListView()
        {
            if (todayTask != null)
            {
                if (todayTask.ForeTaskBlock == null)
                {
                    return;
                }
                foreach(TaskElement te in todayTask.ForeTaskBlock)
                {
                    string[] element = {te.Task, "", "", ""};
                    foreLV.Items.Add(new ListViewItem(element));
                }
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            toolStripStatusLabel_nowTime.Text = dt.ToShortDateString() + " " + dt.ToLongTimeString();
        }
    }
}
