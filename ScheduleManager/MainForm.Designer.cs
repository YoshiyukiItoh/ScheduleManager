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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.allTask = new System.Windows.Forms.TabPage();
            this.todayTask = new System.Windows.Forms.TabPage();
            this.afterTextBox = new System.Windows.Forms.TextBox();
            this.afterLabel = new System.Windows.Forms.Label();
            this.foreTextBox = new System.Windows.Forms.TextBox();
            this.foreLabel = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.tabControl1.SuspendLayout();
            this.allTask.SuspendLayout();
            this.todayTask.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.allTask);
            this.tabControl1.Controls.Add(this.todayTask);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(554, 372);
            this.tabControl1.TabIndex = 0;
            // 
            // allTask
            // 
            this.allTask.Controls.Add(this.treeView1);
            this.allTask.Location = new System.Drawing.Point(4, 22);
            this.allTask.Name = "allTask";
            this.allTask.Padding = new System.Windows.Forms.Padding(3);
            this.allTask.Size = new System.Drawing.Size(546, 346);
            this.allTask.TabIndex = 0;
            this.allTask.Text = "全タスク";
            this.allTask.UseVisualStyleBackColor = true;
            // 
            // todayTask
            // 
            this.todayTask.Controls.Add(this.afterTextBox);
            this.todayTask.Controls.Add(this.afterLabel);
            this.todayTask.Controls.Add(this.foreTextBox);
            this.todayTask.Controls.Add(this.foreLabel);
            this.todayTask.Location = new System.Drawing.Point(4, 22);
            this.todayTask.Name = "todayTask";
            this.todayTask.Padding = new System.Windows.Forms.Padding(3);
            this.todayTask.Size = new System.Drawing.Size(546, 346);
            this.todayTask.TabIndex = 1;
            this.todayTask.Text = "今日のタスク";
            this.todayTask.UseVisualStyleBackColor = true;
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
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(3, 3);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(540, 340);
            this.treeView1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 372);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "ScheduleManager";
            this.tabControl1.ResumeLayout(false);
            this.allTask.ResumeLayout(false);
            this.todayTask.ResumeLayout(false);
            this.todayTask.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage allTask;
        private System.Windows.Forms.TabPage todayTask;
        private System.Windows.Forms.Label foreLabel;
        private System.Windows.Forms.TextBox foreTextBox;
        private System.Windows.Forms.TextBox afterTextBox;
        private System.Windows.Forms.Label afterLabel;
        private System.Windows.Forms.TreeView treeView1;
    }
}

