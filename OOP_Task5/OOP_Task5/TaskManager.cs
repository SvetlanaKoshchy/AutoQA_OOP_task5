using System;
using System.Collections.Generic;

namespace OOP_Task5
{
    public class TaskManager
    {
        private List<Task> TaskList = new List<Task>();
        private ValidationHelper validationHelper = new ValidationHelper();


        public void AddTask()
        {
            Task task = new Task(EnterSummary(), EnterPriority(), EnterDifficulty());
            TaskList.Add(task);
        }

        public void AddNewTask()
        {


            if (TaskList.Count == 0)
            {
                AddTask();
                AddNewTask();
            }
            Console.WriteLine(Constants.enterNewTask);
            string inputString = Console.ReadLine();

            if (validationHelper.IsYesOrNo(inputString))
            {
                AddTask();
                AddNewTask();
            }
            else
            {
                CountTaskTime();
                ShowTaskByPriority();
            }
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

            if (validationHelper.IsNumeric(difficultyInput) == true)
            {

                Difficulty difficulty = (Difficulty)Convert.ToInt32(difficultyInput);
                return difficulty;
            }
            else
            {
                return EnterDifficulty();
            }
            
        }

        public void CountTaskTime()
        {
            int totalTaskTime = 0;
            for (int i = 0; i < TaskList.Count; i++)
            {
                var task = TaskList[i];
                var difficulty = task.Difficulty;
                int variable = validationHelper.TimeFromDifficulty(difficulty);
                totalTaskTime += variable;
            }

            Console.WriteLine("TOTAL TIME FOR TASKS = {0} hours", totalTaskTime);
        }

        public void ShowTaskByPriority() //add check bo tasks forun by selected priority
        {
            var enteredPriority = EnterPriority();
            for (int i = 0; i < TaskList.Count; i++)
            {
                var task = TaskList[i];
                var taskPriority = task.Priority;

                if (enteredPriority == taskPriority)
                {
                    Console.WriteLine("SUMMARY of TASK BY SELECTED PRIOIRITY {0}: {1}", task.Priority, task.TaskSummary);
                }
                else
                {
                    Console.WriteLine("NO TASKS FOUND BY SELECTED PRIOIRITY {0}", enteredPriority);
                }

            }

        }

        public void ShowTaskPerDay()
        { 
        
        }
    }
}
