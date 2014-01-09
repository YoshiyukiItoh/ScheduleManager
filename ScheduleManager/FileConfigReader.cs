using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ScheduleManager
{
    public class FileConfigReader
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        private FileConfigReader()
        {
        }

        /// <summary>
        /// 指定したファイルの内容を読み込む。
        /// </summary>
        /// <param name="filePath">ファイルパス</param>
        /// <param name="encoding">読み込みエンコーディング</param>
        /// <returns>ファイル内容</returns>
        public static List<string> readConfigList(string filePath, Encoding encoding)
        {
            List<string> retList = new List<string>();
            // ファイルの存在チェック
            if (File.Exists(filePath))
            {
                throw new FileNotFoundException();
            }
            // ファイルの読み込み処理
            StreamReader sReader = new StreamReader(filePath,encoding);
            while(sReader.Peek() >= 0)
            {
                string strBuf = sReader.ReadLine();
                retList.Add(strBuf);
            }

            // streamのクローズ
            sReader.Close();

            return retList;
        }

        /// <summary>
        /// 指定したファイルの内容を読み込む。
        /// </summary>
        /// <param name="filePath">ファイルパス</param>
        /// <param name="encoding">読み込みエンコーディング</param>
        /// <returns>ファイル内容</returns>
        public static string readConfig(string filePath, Encoding encoding)
        {
            StringBuilder retStr = new StringBuilder();
            // ファイルの存在チェック
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException();
            }
            // ファイルの読み込み処理
            StreamReader sReader = new StreamReader(filePath, encoding);
            while (sReader.Peek() >= 0)
            {
                string strBuf = sReader.ReadLine();
                retStr.Append(strBuf);
                retStr.Append(Common.lineSeparater);
            }

            // streamのクローズ
            sReader.Close();

            return retStr.ToString();
        }
    }
}
