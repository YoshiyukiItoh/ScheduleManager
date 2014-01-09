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
        public static string readConfig(string filePath, string tag)
        {
            return FileConfigReader.readConfig(filePath, tag, Encoding.UTF8);
        }
    }
}
