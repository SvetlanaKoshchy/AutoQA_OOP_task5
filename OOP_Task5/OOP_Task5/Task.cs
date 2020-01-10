using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Task5
{
    class Task
    {
        private int _taskId;
        private int _priority;
        private int _complexity;
        private string _taskDescription;

        //property taskId
        public int TaskId
        {
            get
            {
                return _taskId;
            }
            set
            {
                _taskId = value;

            }


        }

    }
}
