using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ScheduleManager
{
    public class BaseForm : Form
    {
        // 当日タスク格納変数
        protected TaskList todayTask;

        // 全タスク格納変数
        protected string[] alltasks;
        // アプリの起動日付
        protected string todayDate;
        // 選択日付
        protected string selectedDate;
        // 編集する日付一覧
        protected string[] editDateList;
        // 表示する左カレンダデータ
        protected TextBox[] leftCalender;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public BaseForm()
        {
        }

        /// <summary>
        /// 選択日付が日付一覧に含まれるかどうかチェックします。
        /// </summary>
        /// <returns>true : 含まれる/false : 含まれない</returns>
        public bool isRangeOfEditDateList()
        {
            bool ret = false;
            foreach (string date in editDateList)
            {
                if (String.Equals(date, selectedDate))
                {
                    ret = true;
                }
            }
            return ret;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // BaseForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Name = "BaseForm";
            this.ResumeLayout(false);

        }
    }
}
