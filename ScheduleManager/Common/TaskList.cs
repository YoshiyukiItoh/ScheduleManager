﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ScheduleManager
{
    public class TaskList
    {
        // 午前タスク格納変数
        private List<TaskState> foreTaskBlock;
        // 午後タスク格納変数
        private List<TaskState> afterTaskBlock;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="foreTaskBlock">午前タスク</param>
        /// <param name="afterTaskBlock">午後タスク</param>
        public TaskList(List<TaskState> foreTaskBlock, List<TaskState> afterTaskBlock)
        {
            this.foreTaskBlock = foreTaskBlock;
            this.afterTaskBlock = afterTaskBlock;
        }

        /// <summary>
        /// foreTaskBlockプロパティ
        /// </summary>
        public List<TaskState> ForeTaskBlock
        {
            set { foreTaskBlock = value; }
            get { return foreTaskBlock; }
        }

        /// <summary>
        /// afterTaskBlockプロパティ
        /// </summary>
        public List<TaskState> AfterTaskBlock
        {
            set { afterTaskBlock = value; }
            get { return afterTaskBlock; }
        }

        /// <summary>
        /// 指定位置のタスク状態を更新します。
        /// </summary>
        /// <param name="pos"></param>
        /// <param name="state"></param>
        public void EditForeTaskState(int pos, bool state)
        {
            string before_str = state ? Common.STATE_IMPERFECT : Common.STATE_COMPLETE;
            string replace_str = state ? Common.STATE_COMPLETE : Common.STATE_IMPERFECT;
            foreTaskBlock[pos].CheckState = state;
            foreTaskBlock[pos].Task = foreTaskBlock[pos].Task.Replace(before_str, replace_str);
        }
    }
}
