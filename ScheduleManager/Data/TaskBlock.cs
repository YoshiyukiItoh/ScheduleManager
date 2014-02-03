using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ScheduleManager
{
    public class TaskBlock : List<TaskElement>
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public TaskBlock()
        {
        }

        /// <summary>
        /// check済のタスク数を取得します。
        /// </summary>
        /// <returns></returns>
        public int getCheckedTaskCount()
        {
            int retCnt = 0;
            foreach (TaskElement taskElement in this)
            {
                if (taskElement.Task.IndexOf(Common.STATE_COMPLETE) >= 0)
                {
                    retCnt++;
                }
            }
            return retCnt;
        }
    }
}
