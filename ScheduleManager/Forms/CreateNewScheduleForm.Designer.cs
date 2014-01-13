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
            this.createDateLabel = new System.Windows.Forms.Label();
            this.foreLabel = new System.Windows.Forms.Label();
            this.foreTB = new System.Windows.Forms.TextBox();
            this.afterLabel = new System.Windows.Forms.Label();
            this.afterTB = new System.Windows.Forms.TextBox();
            this.CreateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            // foreLabel
            // 
            this.foreLabel.AutoSize = true;
            this.foreLabel.Location = new System.Drawing.Point(15, 40);
            this.foreLabel.Name = "foreLabel";
            this.foreLabel.Size = new System.Drawing.Size(29, 12);
            this.foreLabel.TabIndex = 1;
            this.foreLabel.Text = "午前";
            // 
            // foreTB
            // 
            this.foreTB.Location = new System.Drawing.Point(15, 55);
            this.foreTB.Multiline = true;
            this.foreTB.Name = "foreTB";
            this.foreTB.Size = new System.Drawing.Size(435, 172);
            this.foreTB.TabIndex = 2;
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
            // afterTB
            // 
            this.afterTB.Location = new System.Drawing.Point(17, 250);
            this.afterTB.Multiline = true;
            this.afterTB.Name = "afterTB";
            this.afterTB.Size = new System.Drawing.Size(435, 172);
            this.afterTB.TabIndex = 4;
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(397, 437);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(75, 23);
            this.CreateButton.TabIndex = 5;
            this.CreateButton.Text = "作成";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // CreateNewScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 472);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.afterTB);
            this.Controls.Add(this.afterLabel);
            this.Controls.Add(this.foreTB);
            this.Controls.Add(this.foreLabel);
            this.Controls.Add(this.createDateLabel);
            this.Name = "CreateNewScheduleForm";
            this.Text = "CreateNewScheduleForm";
            this.Load += new System.EventHandler(this.CreateNewScheduleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label createDateLabel;
        private System.Windows.Forms.Label foreLabel;
        private System.Windows.Forms.TextBox foreTB;
        private System.Windows.Forms.Label afterLabel;
        private System.Windows.Forms.TextBox afterTB;
        private System.Windows.Forms.Button CreateButton;
    }
}