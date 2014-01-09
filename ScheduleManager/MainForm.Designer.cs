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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.CalenderTab = new System.Windows.Forms.TabPage();
            this.afterCBL = new System.Windows.Forms.CheckedListBox();
            this.foreCBL = new System.Windows.Forms.CheckedListBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.allTaskTab = new System.Windows.Forms.TabPage();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.todayTaskTab = new System.Windows.Forms.TabPage();
            this.afterTextBox = new System.Windows.Forms.TextBox();
            this.afterLabel = new System.Windows.Forms.Label();
            this.foreTextBox = new System.Windows.Forms.TextBox();
            this.foreLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabControl.SuspendLayout();
            this.CalenderTab.SuspendLayout();
            this.allTaskTab.SuspendLayout();
            this.todayTaskTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.CalenderTab);
            this.tabControl.Controls.Add(this.allTaskTab);
            this.tabControl.Controls.Add(this.todayTaskTab);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(714, 642);
            this.tabControl.TabIndex = 0;
            // 
            // CalenderTab
            // 
            this.CalenderTab.Controls.Add(this.textBox1);
            this.CalenderTab.Controls.Add(this.afterCBL);
            this.CalenderTab.Controls.Add(this.foreCBL);
            this.CalenderTab.Controls.Add(this.monthCalendar1);
            this.CalenderTab.Location = new System.Drawing.Point(4, 22);
            this.CalenderTab.Name = "CalenderTab";
            this.CalenderTab.Padding = new System.Windows.Forms.Padding(3);
            this.CalenderTab.Size = new System.Drawing.Size(706, 616);
            this.CalenderTab.TabIndex = 2;
            this.CalenderTab.Text = "カレンダー";
            this.CalenderTab.UseVisualStyleBackColor = true;
            // 
            // afterCBL
            // 
            this.afterCBL.FormattingEnabled = true;
            this.afterCBL.Location = new System.Drawing.Point(312, 258);
            this.afterCBL.Name = "afterCBL";
            this.afterCBL.Size = new System.Drawing.Size(260, 340);
            this.afterCBL.TabIndex = 2;
            // 
            // foreCBL
            // 
            this.foreCBL.FormattingEnabled = true;
            this.foreCBL.Location = new System.Drawing.Point(26, 258);
            this.foreCBL.Name = "foreCBL";
            this.foreCBL.Size = new System.Drawing.Size(260, 340);
            this.foreCBL.TabIndex = 1;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(2, 1);
            this.monthCalendar1.Location = new System.Drawing.Point(14, 12);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // allTaskTab
            // 
            this.allTaskTab.Controls.Add(this.treeView1);
            this.allTaskTab.Location = new System.Drawing.Point(4, 22);
            this.allTaskTab.Name = "allTaskTab";
            this.allTaskTab.Padding = new System.Windows.Forms.Padding(3);
            this.allTaskTab.Size = new System.Drawing.Size(706, 616);
            this.allTaskTab.TabIndex = 0;
            this.allTaskTab.Text = "全タスク";
            this.allTaskTab.UseVisualStyleBackColor = true;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(3, 3);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(700, 610);
            this.treeView1.TabIndex = 0;
            // 
            // todayTaskTab
            // 
            this.todayTaskTab.Controls.Add(this.afterTextBox);
            this.todayTaskTab.Controls.Add(this.afterLabel);
            this.todayTaskTab.Controls.Add(this.foreTextBox);
            this.todayTaskTab.Controls.Add(this.foreLabel);
            this.todayTaskTab.Location = new System.Drawing.Point(4, 22);
            this.todayTaskTab.Name = "todayTaskTab";
            this.todayTaskTab.Padding = new System.Windows.Forms.Padding(3);
            this.todayTaskTab.Size = new System.Drawing.Size(706, 616);
            this.todayTaskTab.TabIndex = 1;
            this.todayTaskTab.Text = "今日のタスク";
            this.todayTaskTab.UseVisualStyleBackColor = true;
            // 
            // afterTextBox
            // 
            this.afterTextBox.Location = new System.Drawing.Point(278, 22);
            this.afterTextBox.Multiline = true;
            this.afterTextBox.Name = "afterTextBox";
            this.afterTextBox.ReadOnly = true;
            this.afterTextBox.Size = new System.Drawing.Size(260, 290);
            this.afterTextBox.TabIndex = 3;
            // 
            // afterLabel
            // 
            this.afterLabel.AutoSize = true;
            this.afterLabel.Location = new System.Drawing.Point(276, 7);
            this.afterLabel.Name = "afterLabel";
            this.afterLabel.Size = new System.Drawing.Size(29, 12);
            this.afterLabel.TabIndex = 2;
            this.afterLabel.Text = "午後";
            // 
            // foreTextBox
            // 
            this.foreTextBox.Location = new System.Drawing.Point(6, 22);
            this.foreTextBox.Multiline = true;
            this.foreTextBox.Name = "foreTextBox";
            this.foreTextBox.ReadOnly = true;
            this.foreTextBox.Size = new System.Drawing.Size(260, 290);
            this.foreTextBox.TabIndex = 1;
            // 
            // foreLabel
            // 
            this.foreLabel.AutoSize = true;
            this.foreLabel.Location = new System.Drawing.Point(9, 7);
            this.foreLabel.Name = "foreLabel";
            this.foreLabel.Size = new System.Drawing.Size(29, 12);
            this.foreLabel.TabIndex = 0;
            this.foreLabel.Text = "午前";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(440, 213);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(238, 39);
            this.textBox1.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 642);
            this.Controls.Add(this.tabControl);
            this.Name = "MainForm";
            this.Text = "ScheduleManager";
            this.tabControl.ResumeLayout(false);
            this.CalenderTab.ResumeLayout(false);
            this.CalenderTab.PerformLayout();
            this.allTaskTab.ResumeLayout(false);
            this.todayTaskTab.ResumeLayout(false);
            this.todayTaskTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage allTaskTab;
        private System.Windows.Forms.TabPage todayTaskTab;
        private System.Windows.Forms.Label foreLabel;
        private System.Windows.Forms.TextBox foreTextBox;
        private System.Windows.Forms.TextBox afterTextBox;
        private System.Windows.Forms.Label afterLabel;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TabPage CalenderTab;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.CheckedListBox afterCBL;
        private System.Windows.Forms.CheckedListBox foreCBL;
        private System.Windows.Forms.TextBox textBox1;
    }
}

