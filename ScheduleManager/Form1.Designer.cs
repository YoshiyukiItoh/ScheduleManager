namespace ScheduleManager
{
    partial class Form1
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.afterTextBox = new System.Windows.Forms.TextBox();
            this.afterLabel = new System.Windows.Forms.Label();
            this.foreTextBox = new System.Windows.Forms.TextBox();
            this.foreLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(554, 372);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(546, 346);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "全タスク";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.afterTextBox);
            this.tabPage2.Controls.Add(this.afterLabel);
            this.tabPage2.Controls.Add(this.foreTextBox);
            this.tabPage2.Controls.Add(this.foreLabel);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(546, 346);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "今日のタスク";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // afterTextBox
            // 
            this.afterTextBox.Location = new System.Drawing.Point(278, 22);
            this.afterTextBox.Multiline = true;
            this.afterTextBox.Name = "afterTextBox";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 372);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "ScheduleManager";
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label foreLabel;
        private System.Windows.Forms.TextBox foreTextBox;
        private System.Windows.Forms.TextBox afterTextBox;
        private System.Windows.Forms.Label afterLabel;
    }
}

