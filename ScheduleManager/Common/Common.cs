using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ScheduleManager
{
    public static class Common
    {
        // 改行文字
        public const string LINE_SEPARATOR = "\r\n";
        // 記号"<"
        public const string ANGLE_BRACKET_BEGIN = "<";
        // 記号">"
        public const string ANGLE_BRACKET_END = ">";
        // 記号"/"
        public const string SLASH = "/";
        // 午前tag
        public const string FORE_TAG = "foreNoon";
        // 午後tag
        public const string AFTER_TAG = "afterNoon";
        // 設定ファイル　ディレクトリ名
        public const string TASKS_DIR = "tasks";
        // 全タスク保存xmlファイル名
        public const string ALL_TASK_FILE = "all_tasks.xml";
        // 当日タスクファイル拡張子
        public const string TXT_EXTENTION = ".txt";
        // タスク完了状態
        public const string STATE_COMPLETE = "■";
        // タスク未完了状態
        public const string STATE_IMPERFECT = "□";

        /// <summary>
        /// システム日付を取得します。
        /// </summary>
        /// <returns>日付(yyyy-mm-dd)</returns>
        public static string getSystemDate()
        {
            return DateTime.Today.ToString().Substring(0, 10).Replace("/", "-");
        }

        /// <summary>
        /// 全タスクファイル名を除くタスクファイル名の一覧を返却します。
        /// </summary>
        /// <returns>タスクファイル名の一覧</returns>
        public static string[] getTaskFiles()
        {
            string[] files = Directory.GetFiles(Common.TASKS_DIR, "*", SearchOption.AllDirectories);
            Array.Sort(files);
            List<string> fileList = new List<string>(files);
            fileList.RemoveAll(checkLine);

            files = fileList.ToArray();
            // ディレクトリ名削除
            for (int i = 0; i < files.Length; i++)
            {
                files[i] = files[i].Substring(6,10);
            }

            return files;
        }

        private static bool checkLine(string str)
        {
            return str == Common.ALL_TASK_FILE;
        }

        public static string TaskBlockToString(TaskBlock taskBlock)
        {
            StringBuilder sb = new StringBuilder();
            foreach(TaskElement taskElement in taskBlock)
            {
                sb.Append(taskElement.Task + Common.LINE_SEPARATOR);
            }
            return sb.ToString();
        }
    }
}
