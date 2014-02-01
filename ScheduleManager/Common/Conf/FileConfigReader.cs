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
            if (!File.Exists(filePath))
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
        /// 指定したファイルの全内容を読み込む。
        /// </summary>
        /// <param name="filePath">ファイルパス</param>
        /// <param name="encoding">読み込みエンコーディング</param>
        /// <returns>ファイル内容</returns>
        public static string[] readConfigAry(string filePath, Encoding encoding)
        {

            List<string> retList = new List<string>();

            // ファイルの読み込み処理
            StreamReader sReader = new StreamReader(filePath, encoding);
            while (sReader.Peek() >= 0)
            {
                string strBuf = sReader.ReadLine();
                retList.Add(strBuf);
            }

            // streamのクローズ
            sReader.Close();

            return retList.Count == 0 ? null : retList.ToArray();
        }

        /// <summary>
        /// 指定したファイルの内容を読み込む。
        /// </summary>
        /// <param name="filePath">ファイルパス</param>
        /// <param name="encoding">読み込みエンコーディング</param>
        /// <returns>ファイル内容</returns>
        public static string readConfig(string filePath, string tag, Encoding encoding)
        {
            bool readFlg = false;
            string START_TAG = String.Concat(new string[] {Common.ANGLE_BRACKET_BEGIN,tag,Common.ANGLE_BRACKET_END});
            string END_TAG = String.Concat(new string[] {Common.ANGLE_BRACKET_BEGIN,Common.SLASH,tag,Common.ANGLE_BRACKET_END});

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
                // 終了タグ判定
                if (String.Equals(strBuf, END_TAG))
                {
                    break;
                }
                // 読み込みフラグチェック
                if (readFlg)
                {
                    retStr.Append(strBuf);
                    retStr.Append(Common.LINE_SEPARATOR);
                }
                // 開始タグ判定
                if (String.Equals(strBuf,START_TAG))
                {
                    readFlg = !readFlg;
                }
            }

            // streamのクローズ
            sReader.Close();

            return retStr.ToString();
        }

        public static TaskList readTodayTask(string filePath, Encoding encoding)
        {
            bool foreReadFlg = false;
            bool afterReadFlg = false;
            string FORE_START_TAG = String.Concat(new string[] { Common.ANGLE_BRACKET_BEGIN, Common.FORE_TAG, Common.ANGLE_BRACKET_END });
            string FORE_END_TAG = String.Concat(new string[] { Common.ANGLE_BRACKET_BEGIN, Common.SLASH, Common.FORE_TAG, Common.ANGLE_BRACKET_END });
            string AFTER_START_TAG = String.Concat(new string[] { Common.ANGLE_BRACKET_BEGIN, Common.AFTER_TAG, Common.ANGLE_BRACKET_END });
            string AFTER_END_TAG = String.Concat(new string[] { Common.ANGLE_BRACKET_BEGIN, Common.SLASH, Common.AFTER_TAG, Common.ANGLE_BRACKET_END });

            // 返却変数
            TaskBlock foreTask = new TaskBlock();
            TaskBlock afterTask = new TaskBlock();

            // ファイルの読み込み処理
            StreamReader sReader = new StreamReader(filePath, encoding);
            while (sReader.Peek() >= 0)
            {
                string strBuf = sReader.ReadLine();
                // 午前
                // 終了タグ判定
                if (String.Equals(strBuf, FORE_END_TAG))
                {
                    foreReadFlg = false;
                    continue;
                }
                // 読み込みフラグチェック
                if (foreReadFlg)
                {
                    bool checkState = strBuf.IndexOf(Common.STATE_IMPERFECT) >= 0 ? false : true;
                    foreTask.Add(new TaskElement(strBuf,checkState));
                }
                // 開始タグ判定
                if (String.Equals(strBuf, FORE_START_TAG))
                {
                    foreReadFlg = true;
                    continue;
                }

                // 午後
                // 終了タグ判定
                if (String.Equals(strBuf, AFTER_END_TAG))
                {
                    afterReadFlg = false;
                    continue;
                }
                // 読み込みフラグチェック
                if (afterReadFlg)
                {
                    bool checkState = strBuf.IndexOf(Common.STATE_IMPERFECT) >= 0 ? false : true;
                    afterTask.Add(new TaskElement(strBuf, checkState));
                }
                // 開始タグ判定
                if (String.Equals(strBuf, AFTER_START_TAG))
                {
                    afterReadFlg = true;
                    continue;
                }
            }
            // streamのクローズ
            sReader.Close();
            return new TaskList(foreTask,afterTask);
        }
    }
}
