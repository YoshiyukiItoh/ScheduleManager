using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ScheduleManager
{
    public class FileConfigWriter
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        private FileConfigWriter()
        {
        }

        /// <summary>
        /// 当日タスクを書き込みます。
        /// </summary>
        /// <param name="filePath">ファイルパス</param>
        /// <param name="taskConfig">当日タスク</param>
        /// <param name="encoding">エンコーディング</param>
        public static void writeTodayConfig(string filePath, TaskList taskConfig, Encoding encoding)
        {
            string FORE_START_TAG = String.Concat(new string[] { Common.ANGLE_BRACKET_BEGIN, Common.FORE_TAG, Common.ANGLE_BRACKET_END });
            string FORE_END_TAG = String.Concat(new string[] { Common.ANGLE_BRACKET_BEGIN, Common.SLASH, Common.FORE_TAG, Common.ANGLE_BRACKET_END });
            string AFTER_START_TAG = String.Concat(new string[] { Common.ANGLE_BRACKET_BEGIN, Common.AFTER_TAG, Common.ANGLE_BRACKET_END });
            string AFTER_END_TAG = String.Concat(new string[] { Common.ANGLE_BRACKET_BEGIN, Common.SLASH, Common.AFTER_TAG, Common.ANGLE_BRACKET_END });

            StreamWriter sWriter = new StreamWriter(filePath, false, encoding);

            // 午前書き込み
            sWriter.Write(FORE_START_TAG + Common.LINE_SEPARATOR);
            foreach(TaskElement te in taskConfig.ForeTaskBlock)
            {
                sWriter.Write(te.Task + Common.LINE_SEPARATOR);
            }
            sWriter.Write(FORE_END_TAG + Common.LINE_SEPARATOR);

            // 午後書き込み
            sWriter.Write(AFTER_START_TAG + Common.LINE_SEPARATOR);
            foreach (TaskElement te in taskConfig.AfterTaskBlock)
            {
                sWriter.Write(te.Task + Common.LINE_SEPARATOR);
            }
            sWriter.Write(AFTER_END_TAG + Common.LINE_SEPARATOR);

            sWriter.Close();
        }

        /// <summary>
        /// 全タスクを書き込みます。
        /// </summary>
        /// <param name="filePath">ファイルパス</param>
        /// <param name="alltask">全タスク</param>
        /// <param name="encoding">エンコーディング</param>
        public static void writeAllConfig(string filePath, string[] alltask, Encoding encoding)
        {
            StreamWriter sWriter = new StreamWriter(filePath, false, encoding);

            // TODO 内容書き込み
            foreach(string task in alltask)
            {
                sWriter.Write(task + Common.LINE_SEPARATOR);
            }

            sWriter.Close();
        }
    }
}
