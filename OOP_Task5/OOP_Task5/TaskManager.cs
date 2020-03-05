using System;
using System.Collections.Generic;
using System.Linq;

namespace OOP_Task5
{
    public class TaskManager
    {
        private List<Task> TaskList = new List<Task>();
        private ValidationHelper validationHelper = new ValidationHelper();
               
        
        public void CreateEneredTask()
        {
            Task task = new Task(EnterSummary(), EnterPriority(), EnterDifficulty());
            TaskList.Add(task);
        }

        public void AddNewTask()
        {
            string inputString = "Y";
            while (validationHelper.IsYesOrNo(inputString) == true)
            {
                CreateEneredTask();

                Console.WriteLine(Constants.enterNewTask);
                inputString = Console.ReadLine();
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

                if (Enum.IsDefined(typeof(Priority), priority) == true)
                {
                    return priority;
                }
                else
                {
                    Console.WriteLine(Constants.errorTaskPriority);                    
                }
            }

            return EnterPriority();

        }

        public Difficulty EnterDifficulty()
        {
            Console.WriteLine(Constants.enterTaskDifficulty);
            string difficultyInput = Console.ReadLine();

            if (validationHelper.IsNumeric(difficultyInput) == true)
            {

                Difficulty difficulty = (Difficulty)Convert.ToInt32(difficultyInput);

                if (Enum.IsDefined(typeof(Difficulty), difficulty) == true)
                {
                    return difficulty;
                }
                else
                {
                    Console.WriteLine(Constants.errorTaskDifficulty);                    
                }
            }
          
            return EnterDifficulty();            

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

            Console.WriteLine(Constants.showTotalTimeForTasks, totalTaskTime);
        }


        public void ShowTaskByPriority()
        {
            Console.WriteLine(Constants.infoToShowByPriority);
            var enteredPriority = EnterPriority();            

            bool IfPriorityFinded = false;

            for (int i = 0; i < TaskList.Count; i++)
            {
                var task = TaskList[i];
                var taskPriority = task.Priority;


                if (enteredPriority == taskPriority)
                {
                    Console.WriteLine(Constants.showTaskByPriority, enteredPriority, task.TaskSummary, task.Priority, task.Difficulty);
                    IfPriorityFinded = true;
                }

            }

            if (IfPriorityFinded == false)
            {
                Console.WriteLine(Constants.noTasksByPriority, enteredPriority);  
            }
        }

        public void ShowTasksPerDay()
        {
            Console.WriteLine(Constants.enterAmountOfDays);
            string enteredDaysAmount = Console.ReadLine();

            if (validationHelper.IsNumeric(enteredDaysAmount) == true)
            {       
                int daysAmount = Convert.ToInt32(enteredDaysAmount);
                TaskList = TaskList.OrderBy(x => (int)(x.Priority)).ToList(); 
                int resultValue = 0;

                for (int i = 0; i < TaskList.Count; i++) 
                {
                    var task = TaskList[i];
                    if (resultValue + validationHelper.TimeFromDifficulty(task.Difficulty) <= daysAmount * Constants.workDayHours)
                    {
                        resultValue += validationHelper.TimeFromDifficulty(task.Difficulty);
                       
                        Console.WriteLine(Constants.showTasksByPriorityPerDay, task.TaskSummary, task.Priority, task.Difficulty);                         
                    }                
                                     
                }
            }
            else
            {
                Console.WriteLine(Constants.errorAmountOfDaysIsWrong);
                ShowTasksPerDay();
            }
        }
    }
}
