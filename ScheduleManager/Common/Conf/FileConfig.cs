using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ScheduleManager
{
    public class FileConfig
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        private FileConfig()
        {
        }

        /// <summary>
        /// 指定したファイルをUTF8エンコードで読み込む
        /// </summary>
        /// <param name="filePath">ファイルパス</param>
        /// <returns>List ファイル内容</returns>
        public static TaskList readTaskList(string filePath)
        {
            return FileConfigReader.readTodayTask(filePath, new UTF8Encoding(false));
        }

        /// <summary>
        /// 指定したtaskListをUTF-8エンコードで書き込む
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="taskList"></param>
        public static void writeTaskList(string filePath, TaskList taskList)
        {
            FileConfigWriter.writeConfig(filePath, taskList, new UTF8Encoding(false));
        }
    }
}
