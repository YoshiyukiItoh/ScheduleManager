namespace ScheduleManager
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
            this.todayTaskTab = new System.Windows.Forms.TabPage();
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
            this.AllTasksListBox = new System.Windows.Forms.ListBox();
            this.reloadButton = new System.Windows.Forms.Button();
            this.AllTaskLabel = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.createNextDayScheduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditAllTaskButton = new System.Windows.Forms.Button();
            this.todayTaskTab.SuspendLayout();
            this.allTaskTab.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // todayTaskTab
            // 
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
            this.afterCBL.Location = new System.Drawing.Point(11, 245);
            this.afterCBL.Name = "afterCBL";
            this.afterCBL.Size = new System.Drawing.Size(435, 172);
            this.afterCBL.TabIndex = 7;
            // 
            // foreCBL
            // 
            this.foreCBL.FormattingEnabled = true;
            this.foreCBL.Location = new System.Drawing.Point(11, 47);
            this.foreCBL.Name = "foreCBL";
            this.foreCBL.Size = new System.Drawing.Size(435, 172);
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
            this.afterLabel.Location = new System.Drawing.Point(9, 230);
            this.afterLabel.Name = "afterLabel";
            this.afterLabel.Size = new System.Drawing.Size(29, 12);
            this.afterLabel.TabIndex = 2;
            this.afterLabel.Text = "午後";
            // 
            // foreLabel
            // 
            this.foreLabel.AutoSize = true;
            this.foreLabel.Location = new System.Drawing.Point(8, 31);
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
            this.tabControl.Controls.Add(this.todayTaskTab);
            this.tabControl.Controls.Add(this.allTaskTab);
            this.tabControl.Location = new System.Drawing.Point(0, 22);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(484, 482);
            this.tabControl.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(-7, -2);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(96, 26);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 502);
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
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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

    }
}

