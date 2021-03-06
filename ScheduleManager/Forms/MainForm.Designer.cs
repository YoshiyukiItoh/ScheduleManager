﻿namespace ScheduleManager
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.todayTaskTab = new System.Windows.Forms.TabPage();
            this.afterAllCB = new System.Windows.Forms.CheckBox();
            this.foreAllCB = new System.Windows.Forms.CheckBox();
            this.afterCompleteLavel = new System.Windows.Forms.Label();
            this.foreCompleteLavel = new System.Windows.Forms.Label();
            this.createNewScheduleButton = new System.Windows.Forms.Button();
            this.taskUpdateButton = new System.Windows.Forms.Button();
            this.alertLabel = new System.Windows.Forms.Label();
            this.afterCBL = new System.Windows.Forms.CheckedListBox();
            this.foreCBL = new System.Windows.Forms.CheckedListBox();
            this.oneDayCB = new System.Windows.Forms.ComboBox();
            this.afterLabel = new System.Windows.Forms.Label();
            this.foreLabel = new System.Windows.Forms.Label();
            this.allTaskTab = new System.Windows.Forms.TabPage();
            this.EditAllTaskButton = new System.Windows.Forms.Button();
            this.AllTasksListBox = new System.Windows.Forms.ListBox();
            this.reloadButton = new System.Windows.Forms.Button();
            this.AllTaskLabel = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.CalViewTab = new System.Windows.Forms.TabPage();
            this.nextButton = new System.Windows.Forms.Button();
            this.rightGroupBox = new System.Windows.Forms.GroupBox();
            this.Sat2Label = new System.Windows.Forms.Label();
            this.Fri2Label = new System.Windows.Forms.Label();
            this.Thu2Label = new System.Windows.Forms.Label();
            this.Wed2Label = new System.Windows.Forms.Label();
            this.Tue2Label = new System.Windows.Forms.Label();
            this.Mon2Label = new System.Windows.Forms.Label();
            this.Sun2Label = new System.Windows.Forms.Label();
            this.PrevButton = new System.Windows.Forms.Button();
            this.leftGroupBox = new System.Windows.Forms.GroupBox();
            this.Sat1Label = new System.Windows.Forms.Label();
            this.Fri1Label = new System.Windows.Forms.Label();
            this.Thu1Label = new System.Windows.Forms.Label();
            this.Wed1Label = new System.Windows.Forms.Label();
            this.Tue1Label = new System.Windows.Forms.Label();
            this.Mon1Label = new System.Windows.Forms.Label();
            this.Sun1Label = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.foreLV = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.createNextDayScheduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_nowTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.表示HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DispFileDirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.todayTaskTab.SuspendLayout();
            this.allTaskTab.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.CalViewTab.SuspendLayout();
            this.rightGroupBox.SuspendLayout();
            this.leftGroupBox.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // todayTaskTab
            // 
            this.todayTaskTab.Controls.Add(this.afterAllCB);
            this.todayTaskTab.Controls.Add(this.foreAllCB);
            this.todayTaskTab.Controls.Add(this.afterCompleteLavel);
            this.todayTaskTab.Controls.Add(this.foreCompleteLavel);
            this.todayTaskTab.Controls.Add(this.createNewScheduleButton);
            this.todayTaskTab.Controls.Add(this.taskUpdateButton);
            this.todayTaskTab.Controls.Add(this.alertLabel);
            this.todayTaskTab.Controls.Add(this.afterCBL);
            this.todayTaskTab.Controls.Add(this.foreCBL);
            this.todayTaskTab.Controls.Add(this.oneDayCB);
            this.todayTaskTab.Controls.Add(this.afterLabel);
            this.todayTaskTab.Controls.Add(this.foreLabel);
            this.todayTaskTab.Location = new System.Drawing.Point(4, 22);
            this.todayTaskTab.Name = "todayTaskTab";
            this.todayTaskTab.Padding = new System.Windows.Forms.Padding(3);
            this.todayTaskTab.Size = new System.Drawing.Size(476, 456);
            this.todayTaskTab.TabIndex = 1;
            this.todayTaskTab.Text = "当日タスク";
            this.todayTaskTab.UseVisualStyleBackColor = true;
            // 
            // afterAllCB
            // 
            this.afterAllCB.AutoSize = true;
            this.afterAllCB.Location = new System.Drawing.Point(3, 230);
            this.afterAllCB.Name = "afterAllCB";
            this.afterAllCB.Size = new System.Drawing.Size(15, 14);
            this.afterAllCB.TabIndex = 14;
            this.afterAllCB.UseVisualStyleBackColor = true;
            this.afterAllCB.CheckedChanged += new System.EventHandler(this.afterAllCB_CheckedChanged);
            // 
            // foreAllCB
            // 
            this.foreAllCB.AutoSize = true;
            this.foreAllCB.Location = new System.Drawing.Point(3, 33);
            this.foreAllCB.Name = "foreAllCB";
            this.foreAllCB.Size = new System.Drawing.Size(15, 14);
            this.foreAllCB.TabIndex = 13;
            this.foreAllCB.UseVisualStyleBackColor = true;
            this.foreAllCB.CheckedChanged += new System.EventHandler(this.foreAllCB_CheckedChanged);
            // 
            // afterCompleteLavel
            // 
            this.afterCompleteLavel.AutoSize = true;
            this.afterCompleteLavel.Location = new System.Drawing.Point(341, 230);
            this.afterCompleteLavel.Name = "afterCompleteLavel";
            this.afterCompleteLavel.Size = new System.Drawing.Size(57, 12);
            this.afterCompleteLavel.TabIndex = 12;
            this.afterCompleteLavel.Text = "xx/xx xx%";
            // 
            // foreCompleteLavel
            // 
            this.foreCompleteLavel.AutoSize = true;
            this.foreCompleteLavel.Location = new System.Drawing.Point(341, 33);
            this.foreCompleteLavel.Name = "foreCompleteLavel";
            this.foreCompleteLavel.Size = new System.Drawing.Size(57, 12);
            this.foreCompleteLavel.TabIndex = 11;
            this.foreCompleteLavel.Text = "xx/xx xx%";
            // 
            // createNewScheduleButton
            // 
            this.createNewScheduleButton.Location = new System.Drawing.Point(11, 420);
            this.createNewScheduleButton.Name = "createNewScheduleButton";
            this.createNewScheduleButton.Size = new System.Drawing.Size(75, 23);
            this.createNewScheduleButton.TabIndex = 10;
            this.createNewScheduleButton.Text = "####";
            this.createNewScheduleButton.UseVisualStyleBackColor = true;
            this.createNewScheduleButton.Click += new System.EventHandler(this.createNewSucheduleButton_Click);
            // 
            // taskUpdateButton
            // 
            this.taskUpdateButton.Location = new System.Drawing.Point(393, 420);
            this.taskUpdateButton.Name = "taskUpdateButton";
            this.taskUpdateButton.Size = new System.Drawing.Size(75, 23);
            this.taskUpdateButton.TabIndex = 9;
            this.taskUpdateButton.Text = "更新";
            this.taskUpdateButton.UseVisualStyleBackColor = true;
            this.taskUpdateButton.Click += new System.EventHandler(this.taskUpdateButton_Click);
            // 
            // alertLabel
            // 
            this.alertLabel.AutoSize = true;
            this.alertLabel.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.alertLabel.ForeColor = System.Drawing.Color.Red;
            this.alertLabel.Location = new System.Drawing.Point(9, 9);
            this.alertLabel.Name = "alertLabel";
            this.alertLabel.Size = new System.Drawing.Size(153, 12);
            this.alertLabel.TabIndex = 8;
            this.alertLabel.Text = "タスクが作成されていません。";
            // 
            // afterCBL
            // 
            this.afterCBL.FormattingEnabled = true;
            this.afterCBL.Location = new System.Drawing.Point(20, 245);
            this.afterCBL.Name = "afterCBL";
            this.afterCBL.Size = new System.Drawing.Size(434, 172);
            this.afterCBL.TabIndex = 7;
            // 
            // foreCBL
            // 
            this.foreCBL.CheckOnClick = true;
            this.foreCBL.FormattingEnabled = true;
            this.foreCBL.Location = new System.Drawing.Point(20, 47);
            this.foreCBL.Name = "foreCBL";
            this.foreCBL.Size = new System.Drawing.Size(434, 172);
            this.foreCBL.TabIndex = 6;
            // 
            // oneDayCB
            // 
            this.oneDayCB.FormattingEnabled = true;
            this.oneDayCB.Location = new System.Drawing.Point(347, 6);
            this.oneDayCB.Name = "oneDayCB";
            this.oneDayCB.Size = new System.Drawing.Size(121, 20);
            this.oneDayCB.TabIndex = 4;
            this.oneDayCB.SelectedIndexChanged += new System.EventHandler(this.oneDayCB_SelectedIndexChanged);
            // 
            // afterLabel
            // 
            this.afterLabel.AutoSize = true;
            this.afterLabel.Location = new System.Drawing.Point(18, 230);
            this.afterLabel.Name = "afterLabel";
            this.afterLabel.Size = new System.Drawing.Size(29, 12);
            this.afterLabel.TabIndex = 2;
            this.afterLabel.Text = "午後";
            // 
            // foreLabel
            // 
            this.foreLabel.AutoSize = true;
            this.foreLabel.Location = new System.Drawing.Point(18, 33);
            this.foreLabel.Name = "foreLabel";
            this.foreLabel.Size = new System.Drawing.Size(29, 12);
            this.foreLabel.TabIndex = 0;
            this.foreLabel.Text = "午前";
            // 
            // allTaskTab
            // 
            this.allTaskTab.Controls.Add(this.EditAllTaskButton);
            this.allTaskTab.Controls.Add(this.AllTasksListBox);
            this.allTaskTab.Controls.Add(this.reloadButton);
            this.allTaskTab.Controls.Add(this.AllTaskLabel);
            this.allTaskTab.Location = new System.Drawing.Point(4, 22);
            this.allTaskTab.Name = "allTaskTab";
            this.allTaskTab.Padding = new System.Windows.Forms.Padding(3);
            this.allTaskTab.Size = new System.Drawing.Size(476, 456);
            this.allTaskTab.TabIndex = 0;
            this.allTaskTab.Text = "全タスク";
            this.allTaskTab.UseVisualStyleBackColor = true;
            // 
            // EditAllTaskButton
            // 
            this.EditAllTaskButton.Location = new System.Drawing.Point(8, 428);
            this.EditAllTaskButton.Name = "EditAllTaskButton";
            this.EditAllTaskButton.Size = new System.Drawing.Size(75, 23);
            this.EditAllTaskButton.TabIndex = 4;
            this.EditAllTaskButton.Text = "編集";
            this.EditAllTaskButton.UseVisualStyleBackColor = true;
            this.EditAllTaskButton.Click += new System.EventHandler(this.EditAllTaskButton_Click);
            // 
            // AllTasksListBox
            // 
            this.AllTasksListBox.FormattingEnabled = true;
            this.AllTasksListBox.ItemHeight = 12;
            this.AllTasksListBox.Location = new System.Drawing.Point(8, 22);
            this.AllTasksListBox.Name = "AllTasksListBox";
            this.AllTasksListBox.Size = new System.Drawing.Size(462, 400);
            this.AllTasksListBox.TabIndex = 3;
            // 
            // reloadButton
            // 
            this.reloadButton.Location = new System.Drawing.Point(393, 427);
            this.reloadButton.Name = "reloadButton";
            this.reloadButton.Size = new System.Drawing.Size(75, 23);
            this.reloadButton.TabIndex = 2;
            this.reloadButton.Text = "更新";
            this.reloadButton.UseVisualStyleBackColor = true;
            this.reloadButton.Click += new System.EventHandler(this.reloadButton_Click);
            // 
            // AllTaskLabel
            // 
            this.AllTaskLabel.AutoSize = true;
            this.AllTaskLabel.Location = new System.Drawing.Point(9, 7);
            this.AllTaskLabel.Name = "AllTaskLabel";
            this.AllTaskLabel.Size = new System.Drawing.Size(42, 12);
            this.AllTaskLabel.TabIndex = 1;
            this.AllTaskLabel.Text = "全タスク";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.allTaskTab);
            this.tabControl.Controls.Add(this.todayTaskTab);
            this.tabControl.Controls.Add(this.CalViewTab);
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Location = new System.Drawing.Point(0, 22);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(484, 482);
            this.tabControl.TabIndex = 0;
            // 
            // CalViewTab
            // 
            this.CalViewTab.Controls.Add(this.nextButton);
            this.CalViewTab.Controls.Add(this.rightGroupBox);
            this.CalViewTab.Controls.Add(this.PrevButton);
            this.CalViewTab.Controls.Add(this.leftGroupBox);
            this.CalViewTab.Location = new System.Drawing.Point(4, 22);
            this.CalViewTab.Name = "CalViewTab";
            this.CalViewTab.Padding = new System.Windows.Forms.Padding(3);
            this.CalViewTab.Size = new System.Drawing.Size(476, 456);
            this.CalViewTab.TabIndex = 2;
            this.CalViewTab.Text = "カレンダ";
            this.CalViewTab.UseVisualStyleBackColor = true;
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(408, 183);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(49, 23);
            this.nextButton.TabIndex = 2;
            this.nextButton.Text = "＞";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // rightGroupBox
            // 
            this.rightGroupBox.Controls.Add(this.Sat2Label);
            this.rightGroupBox.Controls.Add(this.Fri2Label);
            this.rightGroupBox.Controls.Add(this.Thu2Label);
            this.rightGroupBox.Controls.Add(this.Wed2Label);
            this.rightGroupBox.Controls.Add(this.Tue2Label);
            this.rightGroupBox.Controls.Add(this.Mon2Label);
            this.rightGroupBox.Controls.Add(this.Sun2Label);
            this.rightGroupBox.Location = new System.Drawing.Point(247, 17);
            this.rightGroupBox.Name = "rightGroupBox";
            this.rightGroupBox.Size = new System.Drawing.Size(210, 160);
            this.rightGroupBox.TabIndex = 1;
            this.rightGroupBox.TabStop = false;
            this.rightGroupBox.Text = "xxxx年xx月";
            // 
            // Sat2Label
            // 
            this.Sat2Label.AutoSize = true;
            this.Sat2Label.ForeColor = System.Drawing.Color.Blue;
            this.Sat2Label.Location = new System.Drawing.Point(187, 15);
            this.Sat2Label.Name = "Sat2Label";
            this.Sat2Label.Size = new System.Drawing.Size(17, 12);
            this.Sat2Label.TabIndex = 12;
            this.Sat2Label.Text = "土";
            // 
            // Fri2Label
            // 
            this.Fri2Label.AutoSize = true;
            this.Fri2Label.ForeColor = System.Drawing.Color.Black;
            this.Fri2Label.Location = new System.Drawing.Point(157, 15);
            this.Fri2Label.Name = "Fri2Label";
            this.Fri2Label.Size = new System.Drawing.Size(17, 12);
            this.Fri2Label.TabIndex = 11;
            this.Fri2Label.Text = "金";
            // 
            // Thu2Label
            // 
            this.Thu2Label.AutoSize = true;
            this.Thu2Label.ForeColor = System.Drawing.Color.Black;
            this.Thu2Label.Location = new System.Drawing.Point(127, 15);
            this.Thu2Label.Name = "Thu2Label";
            this.Thu2Label.Size = new System.Drawing.Size(17, 12);
            this.Thu2Label.TabIndex = 10;
            this.Thu2Label.Text = "木";
            // 
            // Wed2Label
            // 
            this.Wed2Label.AutoSize = true;
            this.Wed2Label.ForeColor = System.Drawing.Color.Black;
            this.Wed2Label.Location = new System.Drawing.Point(97, 15);
            this.Wed2Label.Name = "Wed2Label";
            this.Wed2Label.Size = new System.Drawing.Size(17, 12);
            this.Wed2Label.TabIndex = 9;
            this.Wed2Label.Text = "水";
            // 
            // Tue2Label
            // 
            this.Tue2Label.AutoSize = true;
            this.Tue2Label.ForeColor = System.Drawing.Color.Black;
            this.Tue2Label.Location = new System.Drawing.Point(67, 15);
            this.Tue2Label.Name = "Tue2Label";
            this.Tue2Label.Size = new System.Drawing.Size(17, 12);
            this.Tue2Label.TabIndex = 8;
            this.Tue2Label.Text = "火";
            // 
            // Mon2Label
            // 
            this.Mon2Label.AutoSize = true;
            this.Mon2Label.ForeColor = System.Drawing.Color.Black;
            this.Mon2Label.Location = new System.Drawing.Point(37, 15);
            this.Mon2Label.Name = "Mon2Label";
            this.Mon2Label.Size = new System.Drawing.Size(17, 12);
            this.Mon2Label.TabIndex = 7;
            this.Mon2Label.Text = "月";
            // 
            // Sun2Label
            // 
            this.Sun2Label.AutoSize = true;
            this.Sun2Label.ForeColor = System.Drawing.Color.Red;
            this.Sun2Label.Location = new System.Drawing.Point(7, 15);
            this.Sun2Label.Name = "Sun2Label";
            this.Sun2Label.Size = new System.Drawing.Size(17, 12);
            this.Sun2Label.TabIndex = 1;
            this.Sun2Label.Text = "日";
            // 
            // PrevButton
            // 
            this.PrevButton.Location = new System.Drawing.Point(17, 182);
            this.PrevButton.Name = "PrevButton";
            this.PrevButton.Size = new System.Drawing.Size(49, 23);
            this.PrevButton.TabIndex = 0;
            this.PrevButton.Text = "＜";
            this.PrevButton.UseVisualStyleBackColor = true;
            this.PrevButton.Click += new System.EventHandler(this.PrevButton_Click);
            // 
            // leftGroupBox
            // 
            this.leftGroupBox.Controls.Add(this.Sat1Label);
            this.leftGroupBox.Controls.Add(this.Fri1Label);
            this.leftGroupBox.Controls.Add(this.Thu1Label);
            this.leftGroupBox.Controls.Add(this.Wed1Label);
            this.leftGroupBox.Controls.Add(this.Tue1Label);
            this.leftGroupBox.Controls.Add(this.Mon1Label);
            this.leftGroupBox.Controls.Add(this.Sun1Label);
            this.leftGroupBox.Location = new System.Drawing.Point(17, 16);
            this.leftGroupBox.Name = "leftGroupBox";
            this.leftGroupBox.Size = new System.Drawing.Size(210, 160);
            this.leftGroupBox.TabIndex = 0;
            this.leftGroupBox.TabStop = false;
            this.leftGroupBox.Text = "xxxx年xx月";
            // 
            // Sat1Label
            // 
            this.Sat1Label.AutoSize = true;
            this.Sat1Label.ForeColor = System.Drawing.Color.Blue;
            this.Sat1Label.Location = new System.Drawing.Point(187, 15);
            this.Sat1Label.Name = "Sat1Label";
            this.Sat1Label.Size = new System.Drawing.Size(17, 12);
            this.Sat1Label.TabIndex = 6;
            this.Sat1Label.Text = "土";
            // 
            // Fri1Label
            // 
            this.Fri1Label.AutoSize = true;
            this.Fri1Label.ForeColor = System.Drawing.Color.Black;
            this.Fri1Label.Location = new System.Drawing.Point(157, 15);
            this.Fri1Label.Name = "Fri1Label";
            this.Fri1Label.Size = new System.Drawing.Size(17, 12);
            this.Fri1Label.TabIndex = 5;
            this.Fri1Label.Text = "金";
            // 
            // Thu1Label
            // 
            this.Thu1Label.AutoSize = true;
            this.Thu1Label.ForeColor = System.Drawing.Color.Black;
            this.Thu1Label.Location = new System.Drawing.Point(127, 15);
            this.Thu1Label.Name = "Thu1Label";
            this.Thu1Label.Size = new System.Drawing.Size(17, 12);
            this.Thu1Label.TabIndex = 4;
            this.Thu1Label.Text = "木";
            // 
            // Wed1Label
            // 
            this.Wed1Label.AutoSize = true;
            this.Wed1Label.ForeColor = System.Drawing.Color.Black;
            this.Wed1Label.Location = new System.Drawing.Point(97, 15);
            this.Wed1Label.Name = "Wed1Label";
            this.Wed1Label.Size = new System.Drawing.Size(17, 12);
            this.Wed1Label.TabIndex = 3;
            this.Wed1Label.Text = "水";
            // 
            // Tue1Label
            // 
            this.Tue1Label.AutoSize = true;
            this.Tue1Label.ForeColor = System.Drawing.Color.Black;
            this.Tue1Label.Location = new System.Drawing.Point(67, 15);
            this.Tue1Label.Name = "Tue1Label";
            this.Tue1Label.Size = new System.Drawing.Size(17, 12);
            this.Tue1Label.TabIndex = 2;
            this.Tue1Label.Text = "火";
            // 
            // Mon1Label
            // 
            this.Mon1Label.AutoSize = true;
            this.Mon1Label.ForeColor = System.Drawing.Color.Black;
            this.Mon1Label.Location = new System.Drawing.Point(37, 15);
            this.Mon1Label.Name = "Mon1Label";
            this.Mon1Label.Size = new System.Drawing.Size(17, 12);
            this.Mon1Label.TabIndex = 1;
            this.Mon1Label.Text = "月";
            // 
            // Sun1Label
            // 
            this.Sun1Label.AutoSize = true;
            this.Sun1Label.ForeColor = System.Drawing.Color.Red;
            this.Sun1Label.Location = new System.Drawing.Point(7, 15);
            this.Sun1Label.Name = "Sun1Label";
            this.Sun1Label.Size = new System.Drawing.Size(17, 12);
            this.Sun1Label.TabIndex = 0;
            this.Sun1Label.Text = "日";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.foreLV);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(476, 456);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "当日タスクNew";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // foreLV
            // 
            this.foreLV.CheckBoxes = true;
            this.foreLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.foreLV.GridLines = true;
            this.foreLV.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.foreLV.LabelEdit = true;
            this.foreLV.Location = new System.Drawing.Point(8, 35);
            this.foreLV.Name = "foreLV";
            this.foreLV.Size = new System.Drawing.Size(460, 167);
            this.foreLV.TabIndex = 0;
            this.foreLV.UseCompatibleStateImageBehavior = false;
            this.foreLV.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "項目";
            this.columnHeader1.Width = 260;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "進捗";
            this.columnHeader2.Width = 55;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "期限";
            this.columnHeader3.Width = 70;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "終了時間";
            this.columnHeader4.Width = 70;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.表示HToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(-7, -2);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(251, 26);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createNextDayScheduleToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(88, 22);
            this.toolStripMenuItem1.Text = "メニュー(M)";
            // 
            // createNextDayScheduleToolStripMenuItem
            // 
            this.createNextDayScheduleToolStripMenuItem.Name = "createNextDayScheduleToolStripMenuItem";
            this.createNextDayScheduleToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.createNextDayScheduleToolStripMenuItem.Text = "翌日のスケジュール作成";
            this.createNextDayScheduleToolStripMenuItem.Click += new System.EventHandler(this.createNextDayScheduleToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_nowTime});
            this.statusStrip.Location = new System.Drawing.Point(0, 505);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(484, 23);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_nowTime
            // 
            this.toolStripStatusLabel_nowTime.Name = "toolStripStatusLabel_nowTime";
            this.toolStripStatusLabel_nowTime.Size = new System.Drawing.Size(98, 18);
            this.toolStripStatusLabel_nowTime.Text = "xx/xx xx:xx:xx";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // 表示HToolStripMenuItem
            // 
            this.表示HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DispFileDirToolStripMenuItem});
            this.表示HToolStripMenuItem.Name = "表示HToolStripMenuItem";
            this.表示HToolStripMenuItem.Size = new System.Drawing.Size(63, 22);
            this.表示HToolStripMenuItem.Text = "表示(H)";
            // 
            // DispFileDirToolStripMenuItem
            // 
            this.DispFileDirToolStripMenuItem.Name = "DispFileDirToolStripMenuItem";
            this.DispFileDirToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.DispFileDirToolStripMenuItem.Text = "予定ファイルの場所";
            this.DispFileDirToolStripMenuItem.Click += new System.EventHandler(this.DispFileDirToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 528);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "ScheduleManager";
            this.todayTaskTab.ResumeLayout(false);
            this.todayTaskTab.PerformLayout();
            this.allTaskTab.ResumeLayout(false);
            this.allTaskTab.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.CalViewTab.ResumeLayout(false);
            this.rightGroupBox.ResumeLayout(false);
            this.rightGroupBox.PerformLayout();
            this.leftGroupBox.ResumeLayout(false);
            this.leftGroupBox.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabPage todayTaskTab;
        private System.Windows.Forms.Label afterCompleteLavel;
        private System.Windows.Forms.Label foreCompleteLavel;
        private System.Windows.Forms.Button createNewScheduleButton;
        private System.Windows.Forms.Button taskUpdateButton;
        private System.Windows.Forms.Label alertLabel;
        private System.Windows.Forms.CheckedListBox afterCBL;
        private System.Windows.Forms.CheckedListBox foreCBL;
        private System.Windows.Forms.ComboBox oneDayCB;
        private System.Windows.Forms.Label afterLabel;
        private System.Windows.Forms.Label foreLabel;
        private System.Windows.Forms.TabPage allTaskTab;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem createNextDayScheduleToolStripMenuItem;
        private System.Windows.Forms.Label AllTaskLabel;
        private System.Windows.Forms.Button reloadButton;
        private System.Windows.Forms.ListBox AllTasksListBox;
        private System.Windows.Forms.Button EditAllTaskButton;
        private System.Windows.Forms.TabPage CalViewTab;
        private System.Windows.Forms.GroupBox rightGroupBox;
        private System.Windows.Forms.Button PrevButton;
        private System.Windows.Forms.GroupBox leftGroupBox;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Label Sat1Label;
        private System.Windows.Forms.Label Fri1Label;
        private System.Windows.Forms.Label Thu1Label;
        private System.Windows.Forms.Label Wed1Label;
        private System.Windows.Forms.Label Tue1Label;
        private System.Windows.Forms.Label Mon1Label;
        private System.Windows.Forms.Label Sun1Label;
        private System.Windows.Forms.CheckBox foreAllCB;
        private System.Windows.Forms.CheckBox afterAllCB;
        private System.Windows.Forms.Label Sat2Label;
        private System.Windows.Forms.Label Fri2Label;
        private System.Windows.Forms.Label Thu2Label;
        private System.Windows.Forms.Label Wed2Label;
        private System.Windows.Forms.Label Tue2Label;
        private System.Windows.Forms.Label Mon2Label;
        private System.Windows.Forms.Label Sun2Label;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListView foreLV;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_nowTime;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ToolStripMenuItem 表示HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DispFileDirToolStripMenuItem;

    }
}

