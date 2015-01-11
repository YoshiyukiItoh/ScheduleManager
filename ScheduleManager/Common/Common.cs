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
        // 各タスクファイル格納ディレクトリ
        public const string TASK_FILES = "taskfiles";
        // 全タスクファイル名
        public const string ALL_TASK_FILE = "all_tasks.txt";
        // 全タスク保存xmlファイル名
        //public const string ALL_TASK_FILE = "all_tasks.xml";
        // 当日タスクファイル拡張子
        public const string TXT_EXTENTION = ".txt";
        // タスク完了状態
        public const string STATE_COMPLETE = "■";
        // タスク未完了状態
        public const string STATE_IMPERFECT = "□";
        // date format
        public const string DATE_FORMAT = "yyyy-MM-dd";

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
            createWorkDir();
            string[] files = Directory.GetFiles(
                                        Path.Combine(new string[] { Common.TASKS_DIR, Common.TASK_FILES }),
                                        "*",
                                        SearchOption.AllDirectories);
            Array.Sort(files);
            List<string> fileList = new List<string>(files);
            fileList.RemoveAll(checkLine);

            files = fileList.ToArray();
            // ディレクトリ名削除
            for (int i = 0; i < files.Length; i++)
            {
                int len = files[i].Length;
                files[i] = files[i].Substring(16, 10);
            }

            return files;
        }

        private static bool checkLine(string str)
        {
            return str == Common.ALL_TASK_FILE;
        }

        /// <summary>
        /// TaskBlockからstringの文字列を取得する。
        /// </summary>
        /// <param name="taskBlock">予定</param>
        /// <returns></returns>
        public static string TaskBlockToString(TaskBlock taskBlock)
        {
            if (taskBlock == null)
            {
                return String.Empty;
            }
            StringBuilder sb = new StringBuilder();
            foreach (TaskElement taskElement in taskBlock)
            {
                sb.Append(taskElement.Task + Common.LINE_SEPARATOR);
            }
            return sb.ToString();
        }

        public static string StringAryToString(string[] stringAry)
        {
            StringBuilder sb = new StringBuilder();
            foreach (string str in stringAry)
            {
                sb.Append(str + Common.LINE_SEPARATOR);
            }
            return sb.ToString();
        }

        /// <summary>
        /// 翌営業日を取得します。
        /// </summary>
        /// <returns>翌営業日(yyyy-mm-dd)</returns>
        public static string getNextDay()
        {
            // 当日日付取得
            DateTime toDay = DateTime.Today;
            DateTime nextDay;
            HolidayChecker.HolidayInfo holidayInfo;

            do
            {
                nextDay = toDay.AddDays(1);
                holidayInfo = HolidayChecker.Holiday(nextDay);
            } while (holidayInfo.holiday != HolidayChecker.HolidayInfo.HOLIDAY.WEEKDAY);

            return nextDay.ToString().Substring(0, 10).Replace("/", "-");
        }

        /// <summary>
        /// 曜日を求める。
        /// </summary>
        /// <param name="y">西暦年</param>
        /// <param name="m">月</param>
        /// <param name="d">日</param>
        /// <returns>0=日 1=月 2=火 3=水 4=木 5=金 6=土</returns>
        public static int week_of_day(int y, int m, int d)
        {
            if (m == 1)
            {
                y = y - 1;
                m = 13;
            }
            else if (m == 2)
            {
                y = y - 1;
                m = 14;
            }
            return (5 * y / 4 - y / 100 + y / 400 + (26 * m + 16) / 10 + d) % 7;
        }

        /// <summary>
        /// 月の最終日を求める。
        /// </summary>
        /// <param name="y">西暦年</param>
        /// <param name="m">月</param>
        /// <returns>月の最終日</returns>
        public static int month_last_day(int y, int m)
        {
            int d = 0;
            int[] last = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            if (m == 2)
            {
                d = last[m - 1] + is_leap_year(y);    /* 閏年なら+1 */
            }
            else if (m >= 1 && m <= 12)
            {
                d = last[m - 1];
            }

            return d;
        }

        /// <summary>
        /// うるう年判定
        /// </summary>
        /// <param name="y">西暦年</param>
        /// <returns>1:閏年　0:閏年以外</returns>
        private static int is_leap_year(int y)
        {
            int rc = 0;

            if (y % 4 == 0 && (y % 100 != 0 || y % 400 == 0))
            {
                rc = 1;
            }

            return rc;
        }

        /// <summary>
        /// 作業ディレクトリの作成をする
        /// </summary>
        private static void createWorkDir()
        {
            string workPath = Path.Combine(new string[] { Common.TASKS_DIR, Common.TASK_FILES });
            if (!File.Exists(workPath))
            {
                Directory.CreateDirectory(workPath);
            }
        }
    }
}
