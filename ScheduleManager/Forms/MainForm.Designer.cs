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
            this.afterAchievementLevel = new System.Windows.Forms.Label();
            this.foreAchievementLevel = new System.Windows.Forms.Label();
            this.createNewSucheduleButton = new System.Windows.Forms.Button();
            this.taskUpdateButton = new System.Windows.Forms.Button();
            this.alertLabel = new System.Windows.Forms.Label();
            this.afterCBL = new System.Windows.Forms.CheckedListBox();
            this.foreCBL = new System.Windows.Forms.CheckedListBox();
            this.refreshButton = new System.Windows.Forms.Button();
            this.oneDayCB = new System.Windows.Forms.ComboBox();
            this.afterLabel = new System.Windows.Forms.Label();
            this.foreLabel = new System.Windows.Forms.Label();
            this.allTaskTab = new System.Windows.Forms.TabPage();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.todayTaskTab.SuspendLayout();
            this.allTaskTab.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // todayTaskTab
            // 
            this.todayTaskTab.Controls.Add(this.afterAchievementLevel);
            this.todayTaskTab.Controls.Add(this.foreAchievementLevel);
            this.todayTaskTab.Controls.Add(this.createNewSucheduleButton);
            this.todayTaskTab.Controls.Add(this.taskUpdateButton);
            this.todayTaskTab.Controls.Add(this.alertLabel);
            this.todayTaskTab.Controls.Add(this.afterCBL);
            this.todayTaskTab.Controls.Add(this.foreCBL);
            this.todayTaskTab.Controls.Add(this.refreshButton);
            this.todayTaskTab.Controls.Add(this.oneDayCB);
            this.todayTaskTab.Controls.Add(this.afterLabel);
            this.todayTaskTab.Controls.Add(this.foreLabel);
            this.todayTaskTab.Location = new System.Drawing.Point(4, 22);
            this.todayTaskTab.Name = "todayTaskTab";
            this.todayTaskTab.Padding = new System.Windows.Forms.Padding(3);
            this.todayTaskTab.Size = new System.Drawing.Size(476, 446);
            this.todayTaskTab.TabIndex = 1;
            this.todayTaskTab.Text = "当日タスク";
            this.todayTaskTab.UseVisualStyleBackColor = true;
            // 
            // afterAchievementLevel
            // 
            this.afterAchievementLevel.AutoSize = true;
            this.afterAchievementLevel.Location = new System.Drawing.Point(341, 230);
            this.afterAchievementLevel.Name = "afterAchievementLevel";
            this.afterAchievementLevel.Size = new System.Drawing.Size(57, 12);
            this.afterAchievementLevel.TabIndex = 12;
            this.afterAchievementLevel.Text = "xx/xx xx%";
            // 
            // foreAchievementLevel
            // 
            this.foreAchievementLevel.AutoSize = true;
            this.foreAchievementLevel.Location = new System.Drawing.Point(341, 33);
            this.foreAchievementLevel.Name = "foreAchievementLevel";
            this.foreAchievementLevel.Size = new System.Drawing.Size(57, 12);
            this.foreAchievementLevel.TabIndex = 11;
            this.foreAchievementLevel.Text = "xx/xx xx%";
            // 
            // createNewSucheduleButton
            // 
            this.createNewSucheduleButton.Location = new System.Drawing.Point(11, 420);
            this.createNewSucheduleButton.Name = "createNewSucheduleButton";
            this.createNewSucheduleButton.Size = new System.Drawing.Size(75, 23);
            this.createNewSucheduleButton.TabIndex = 10;
            this.createNewSucheduleButton.Text = "####";
            this.createNewSucheduleButton.UseVisualStyleBackColor = true;
            this.createNewSucheduleButton.Click += new System.EventHandler(this.createNewSucheduleButton_Click);
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
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(393, 4);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 23);
            this.refreshButton.TabIndex = 5;
            this.refreshButton.Text = "表示";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // oneDayCB
            // 
            this.oneDayCB.FormattingEnabled = true;
            this.oneDayCB.Location = new System.Drawing.Point(266, 6);
            this.oneDayCB.Name = "oneDayCB";
            this.oneDayCB.Size = new System.Drawing.Size(121, 20);
            this.oneDayCB.TabIndex = 4;
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
            this.allTaskTab.Controls.Add(this.treeView1);
            this.allTaskTab.Location = new System.Drawing.Point(4, 22);
            this.allTaskTab.Name = "allTaskTab";
            this.allTaskTab.Padding = new System.Windows.Forms.Padding(3);
            this.allTaskTab.Size = new System.Drawing.Size(476, 446);
            this.allTaskTab.TabIndex = 0;
            this.allTaskTab.Text = "全タスク";
            this.allTaskTab.UseVisualStyleBackColor = true;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(3, 3);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(470, 440);
            this.treeView1.TabIndex = 0;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.todayTaskTab);
            this.tabControl.Controls.Add(this.allTaskTab);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(484, 472);
            this.tabControl.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 472);
            this.Controls.Add(this.tabControl);
            this.Name = "MainForm";
            this.Text = "ScheduleManager";
            this.todayTaskTab.ResumeLayout(false);
            this.todayTaskTab.PerformLayout();
            this.allTaskTab.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage todayTaskTab;
        private System.Windows.Forms.Label afterAchievementLevel;
        private System.Windows.Forms.Label foreAchievementLevel;
        private System.Windows.Forms.Button createNewSucheduleButton;
        private System.Windows.Forms.Button taskUpdateButton;
        private System.Windows.Forms.Label alertLabel;
        private System.Windows.Forms.CheckedListBox afterCBL;
        private System.Windows.Forms.CheckedListBox foreCBL;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.ComboBox oneDayCB;
        private System.Windows.Forms.Label afterLabel;
        private System.Windows.Forms.Label foreLabel;
        private System.Windows.Forms.TabPage allTaskTab;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TabControl tabControl;

    }
}

