using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ScheduleManager
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            log4net.ILog logger
                = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
            try
            {
                if (!DuplicateCheck.ShowPrevProcess())
                {
                    logger.Info("アプリケーション起動");
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new MainForm());
                }
                else
                {
                    return;
                }
            }
            catch (Exception e)
            {
                logger.Error(e.Message);
            }
        }
    }
}
