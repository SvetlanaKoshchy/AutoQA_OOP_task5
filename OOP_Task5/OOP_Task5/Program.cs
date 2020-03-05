using System;

namespace OOP_Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            TaskManager task = new TaskManager();
            //task.AddTask();
            task.AddNewTask2();

            task.CountTaskTime();
            task.ShowTaskByPriority();
            task.ShowTasksPerDay();
            

        }
    }
}
