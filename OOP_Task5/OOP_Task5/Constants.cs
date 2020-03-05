using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Task5
{
    static class Constants
    {
        public const int workDayHours = 8; //work day length in hours;
        public const int highHoursDifficulty = 4;
        public const int mediumHoursDifficulty = 2;
        public const int easyHoursDifficulty = 1;

        public const string enterTaskSummary = "Please, enter SUMMARY for task:";

        public const string enterTaskPriority = "Please, enter task PRIORITY, where 1 - High, 2 - Medium, 3 - Low:";
        public const string errorTaskPriority = "PRIORITY for enetered value does NOT exist. Enter PRIORITY value again.";
        public const string showTaskByPriority = "Task by selcted PRIOIRITY {0}: Summary: {1}, Priority: {2}, Difficulty: {3}";
        public const string noTasksByPriority = "There are no tasks founded by selected PRIOIRITY {0}";

        public const string enterTaskDifficulty = "Please, enter task DIFFICULTY, 1 - Hard, 2 - Medium , 3 - Easy:";
        public const string errorTaskDifficulty = "DIFFICULTY for enetered value does NOT exist. Enter DIFFICULTY value again.";

        public const string showTotalTimeForTasks = "TOTAL TIME FOR TASKS = {0} hours";

        public const string errorWrongSummary = "Summary can not be null or empty.";
        public const string errorValueIsWrong = "Enetered value is wrong. Please, try again.";

        public const string enterNewTask = "Enter Y if you want to enter new task. Press any key if not.";

        public const string enterAmountOfDays = "Please, enter amount of days:";
        public const string errorAmountOfDaysIsWrong = "Entered amount of days is wrong. Please, enter correct amount of days again.";

        public const string showTasksByPriorityPerDay = "Task to execute by priority: {0}, {1}, {2}";


    }
}
