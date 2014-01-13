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
        // protected 
        // アプリの起動日付
        protected string today;
        // 編集する日付一覧
        protected string[] editDateList;

        public BaseForm()
        {
        }
    }
}
