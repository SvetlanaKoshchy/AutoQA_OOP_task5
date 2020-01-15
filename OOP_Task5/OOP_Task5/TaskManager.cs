using System;
using System.Collections.Generic;

namespace OOP_Task5
{
    public class TaskManager
    {
        private List<Task> TaskList = new List<Task>();
        //private static ValidationHelper validationHelper;

        ValidationHelper validationHelper = new ValidationHelper();


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

            string inputString = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(inputString))
            {
                Console.WriteLine(Constants.errorWrongSummary);
                
                return EnterSummary();
            }
            else
            {
                return inputString;
            }
        }

        public Priority EnterPriority()
        {
            Console.WriteLine(Constants.enterTaskPriority);

            string priorityInput = Console.ReadLine();
           
            if (validationHelper.IsNumeric(priorityInput) == true)
            {
                Priority priority = (Priority)Convert.ToInt32(priorityInput);
                return priority;
            }
            else
            {
                return EnterPriority();
            }
          
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
