using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using log4net;

namespace ScheduleManager
{
    public enum calCtl
    {
        prev = 0,
        next
    }

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
        protected List<Label> leftWeekLabel;
        protected List<Label> rightWeekLabel;
        // 表示する左カレンダデータ
        protected List<Control> leftCalender;
        protected CalInfo leftCalInfo;
        // 表示する右カレンダデータ
        protected List<Control> rightCalender;
        protected CalInfo rightCalInfo;

        protected ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public class CalInfo
        {
            public int year { get; set; }
            public int month { get; set; }
        }

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
