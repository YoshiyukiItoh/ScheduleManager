namespace ScheduleManager
{
    partial class CreateNewScheduleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cancelButton = new System.Windows.Forms.Button();
            this.createButton = new System.Windows.Forms.Button();
            this.afterTB = new System.Windows.Forms.TextBox();
            this.afterLabel = new System.Windows.Forms.Label();
            this.foreTB = new System.Windows.Forms.TextBox();
            this.foreLabel = new System.Windows.Forms.Label();
            this.createDateLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(397, 437);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "キャンセル";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // createButton
            // 
            this.createButton.Enabled = false;
            this.createButton.Location = new System.Drawing.Point(310, 437);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(75, 23);
            this.createButton.TabIndex = 5;
            this.createButton.Text = "作成";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // afterTB
            // 
            this.afterTB.Location = new System.Drawing.Point(17, 250);
            this.afterTB.Multiline = true;
            this.afterTB.Name = "afterTB";
            this.afterTB.Size = new System.Drawing.Size(435, 172);
            this.afterTB.TabIndex = 4;
            this.afterTB.TextChanged += new System.EventHandler(this.afterTB_TextChanged);
            // 
            // afterLabel
            // 
            this.afterLabel.AutoSize = true;
            this.afterLabel.Location = new System.Drawing.Point(17, 234);
            this.afterLabel.Name = "afterLabel";
            this.afterLabel.Size = new System.Drawing.Size(29, 12);
            this.afterLabel.TabIndex = 3;
            this.afterLabel.Text = "午後";
            // 
            // foreTB
            // 
            this.foreTB.Location = new System.Drawing.Point(15, 55);
            this.foreTB.Multiline = true;
            this.foreTB.Name = "foreTB";
            this.foreTB.Size = new System.Drawing.Size(435, 172);
            this.foreTB.TabIndex = 2;
            this.foreTB.TextChanged += new System.EventHandler(this.foreTB_TextChanged);
            // 
            // foreLabel
            // 
            this.foreLabel.AutoSize = true;
            this.foreLabel.Location = new System.Drawing.Point(15, 40);
            this.foreLabel.Name = "foreLabel";
            this.foreLabel.Size = new System.Drawing.Size(29, 12);
            this.foreLabel.TabIndex = 1;
            this.foreLabel.Text = "午前";
            // 
            // createDateLabel
            // 
            this.createDateLabel.AutoSize = true;
            this.createDateLabel.Location = new System.Drawing.Point(13, 13);
            this.createDateLabel.Name = "createDateLabel";
            this.createDateLabel.Size = new System.Drawing.Size(108, 12);
            this.createDateLabel.TabIndex = 0;
            this.createDateLabel.Text = "の予定を作成します。";
            // 
            // CreateNewScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 472);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.afterTB);
            this.Controls.Add(this.afterLabel);
            this.Controls.Add(this.foreTB);
            this.Controls.Add(this.foreLabel);
            this.Controls.Add(this.createDateLabel);
            this.Name = "CreateNewScheduleForm";
            this.Text = "CreateNewSchedule";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label createDateLabel;
        private System.Windows.Forms.Label foreLabel;
        private System.Windows.Forms.TextBox foreTB;
        private System.Windows.Forms.Label afterLabel;
        private System.Windows.Forms.TextBox afterTB;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button cancelButton;
    }
}