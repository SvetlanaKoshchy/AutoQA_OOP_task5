using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Task5
{
    static class Constants
    {
        public const int workDay = 8; //work day length in hours;
        
        public const string enterTaskSummary = "Please, enter summary for task:";
        public const string enterTaskPriority = "Please, enter task priority, where 1 - High, 2 - Medium, 3 - Low:";
        public const string errorTaskPriorityIsWrong = "Enetered priority value is wrong. Please, try again.";

        public const string enterTaskDifficulty = "Please, enter task difficulty, 1 - Hard, 2 - Medium , 3 - Easy:";
        public const string errorTaskDifficultyIsWrong = "Enetered difficulty value is wrong.Please, try again.";

        public const string enterNewTask = "Enter Y if you want to enter new task. Ente N if not.";

        public const string enterAmountOfDays = "Please, enter amount of days:";
        public const string errorAmountOfDaysIsWrong = "Entered amount of days is wrong. Please, enter correct amount of days again.";
    }
}
