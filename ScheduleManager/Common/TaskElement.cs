using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ScheduleManager
{
    public class TaskElement
    {
        private string  task;
        private bool checkState;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="task">タスクの1行</param>
        public TaskElement(string task)
        {
            this.task = task;
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="task">タスクの1行</param>
        /// <param name="checkState">■:true、□:false</param>
        public TaskElement(string task, bool checkState)
        {
            this.task = task;
            this.checkState = checkState;
        }

        /// <summary>
        /// taskプロパティ
        /// </summary>
        public string Task
        {
            set { this.task = value; }
            get { return task; }
        }

        /// <summary>
        /// checkStateプロパティ
        /// </summary>
        public bool CheckState
        {
            set { this.checkState = value; }
            get { return checkState; }
        }
    }
}
