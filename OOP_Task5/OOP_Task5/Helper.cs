using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Task5
{
    class Helper
    {
        //method to get user's tasks
        public void EnterTaskWithData()
        {
            Console.WriteLine(Constants.enterTask);
            string inputTask = Console.ReadLine();
        }

        //method to get user's available days
        public void EnterAmountOfAvailableDays()
        {
            Console.WriteLine(Constants.enterAmountOfDays);
            string inputValue = Console.ReadLine();
        }

        //show amount of time to execute all user's tasks
        public void ShowTimeForAllTasks()
        { 

        }

        //show list of tasks by entered priority 
        public void ShowTasksByPriority()
        {

        }

       //show list of tasks which can be done in entered by user amount of days depending on priority
        public void ShowTasksPerDaysDependingOnPriority()
        {

        }
    }
}
