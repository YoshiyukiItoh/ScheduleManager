using System;
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
    public partial class EditAllTaskForm : BaseForm
    {
        public EditAllTaskForm(string[] alltasks)
        {
            InitializeComponent();
            base.alltasks = alltasks;
            if (base.alltasks ==null)
            {
                return;
            }
            init();
        }

        /// <summary>
        /// allTaskTBへ内容の反映を行います。
        /// </summary>
        private void init()
        {
            this.allTaskTB.Text = Common.StringAryToString(base.alltasks);
        }

        /// <summary>
        /// alltasks.txtを更新します。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void updateButton_Click(object sender, EventArgs e)
        {
            // テキストボックスから値を取得する。
            string[] tasks = this.allTaskTB.Text.Split(new string[] { Common.LINE_SEPARATOR }, StringSplitOptions.None);
            string ALL_TASKS_FILEPATH = Path.Combine(new string[] { Common.TASKS_DIR, Common.ALL_TASK_FILE });
            // ファイルに書き込む。
            FileConfig.writeAllTask(ALL_TASKS_FILEPATH, tasks);
            this.Close();
        }

        /// <summary>
        /// キャンセルボタン。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
