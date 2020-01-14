using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Task5
{
    class Task
    {

        private string _summary;
        private Priority _priority;
        private Difficulty _difficulty;

        //constructor
        public Task(string summary, Priority priority, Difficulty difficulty)
        {
            _summary = summary;
            _priority = priority;
            _difficulty = difficulty;
        }

        //property Summary
        public string TaskSummary
        {
            get
            {
                return _summary;
            }
            set
            {
                _summary = value;
            }            
        }

        //property Priority
        public Priority Priority
        {
            get
            {
                return _priority;
            }
            set
            {
                _priority = value;
            }
        }

        //property Difficulty
        public Difficulty Difficulty
        {
            get
            {
                return _difficulty;
            }
            set
            {
                _difficulty = value;
            }
        }

    }
}
