using System;
using System.Collections.Generic;

namespace OOP_Task5
{
    public class TaskManager
    {
        private List<Task> TaskList = new List<Task>();

        //public void EnterNewTasks()
        //{
        //    Console.WriteLine(Constants.enterNewTask);
        //    string value = Console.ReadLine();
        //    if (value = )
            
        //}

        public void AddTask()
        {
            Task task = new Task(EnterSummary(), EnterPriority(), EnterDifficulty());
            TaskList.Add(task);
        }

        public string EnterSummary()
        {           

            Console.WriteLine(Constants.enterTaskSummary);
            string summary = Console.ReadLine();
            return summary;
        }

        public Priority EnterPriority()
        {
            Console.WriteLine(Constants.enterTaskPriority);
            string priorityInput = Console.ReadLine();
            Priority priority = (Priority)Convert.ToInt32(priorityInput);
            return priority;

        }

        public Difficulty EnterDifficulty()
        {
            Console.WriteLine(Constants.enterTaskDifficulty);
            string difficultyInput = Console.ReadLine();
            Difficulty difficulty = (Difficulty)Convert.ToInt32(difficultyInput);
            return difficulty;
        }

    }
}
