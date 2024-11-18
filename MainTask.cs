using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace long_bong_midterm.CustomClasses
{
    internal class MainTask
    {
        private string mainTaskName;
        private TimeOnly hour;
        private string type;
        private bool completed;
        private string note;
        private List<SubTask> subTask;

        public string MainTaskName { get => mainTaskName; set => mainTaskName = value; }
        public TimeOnly Hour { get => hour; set => hour = value; }
        public string Type { get => type; set => type = value; }
        public bool Completed { get => completed; set => completed = value; }
        public string Note { get => note; set => note = value; }
        internal List<SubTask> SubTask { get => subTask; set => subTask = value; }

        public MainTask()
        {
            mainTaskName = string.Empty;
            hour = TimeOnly.MinValue;
            type = string.Empty;
            completed = false;
            note = string.Empty;
            subTask = new List<SubTask>();
        }
        public MainTask(string mainTaskName, TimeOnly hour, string type, bool completed, string note)
        {
            this.mainTaskName = mainTaskName;
            this.hour = hour;
            this.type = type;
            this.completed = completed;
            this.note = note;
            subTask = new List<SubTask>();
        }
        public MainTask(MainTask mainTask)
        {
            mainTaskName = mainTask.mainTaskName;
            hour = mainTask.hour;
            type = mainTask.type;
            completed = mainTask.completed;
            note = mainTask.note;
            subTask = new List<SubTask>(mainTask.subTask);
        }
        public void readTextFile(string line)
        {
            string trimmedLine = line.Replace("\t", "");
            int tabCount = line.Length - trimmedLine.Length;
            if (tabCount == 1) 
            {
                string[] parts = line.Split(','); 
                if (parts.Length >= 4) 
                {
                    mainTaskName = parts[0].Trim(); 
                    hour = TimeOnly.Parse(parts[1].Trim()); 
                    type = parts[2].Trim(); 
                    completed = parts[3].Trim().ToLower() == "hoàn thành";
                    note = parts.Length > 4 ? parts[4].Trim() : string.Empty; 
                }
            }
            else if (tabCount == 2) 
            {
                SubTask currentSubTask = new SubTask(); 
                currentSubTask.readFromFile(line); 
                subTask.Add(currentSubTask);
            }
        }




        public void printTextFile(StreamWriter writer)
        {

            writer.WriteLine($"\t{mainTaskName}, {hour}, {type}, {(completed ? "hoàn thành" : "chưa hoàn thành")}, {note}");
            foreach (var sub in subTask)
            {
                sub.printTextFile(writer);
            }
        }

        public void checkSubTasksCompletion()
        {
            bool allCompleted = true;
            foreach (var sub in subTask)
            {
                if (!sub.Completed)
                {
                    allCompleted = false;
                    break;
                }
            }
            if (allCompleted)
            {
                completed = true;
            }
            else
            {
                completed = false;
            }
        }
        public void AddSubTask(SubTask sub)
        {
            subTask.Add(sub);
        }


    }
}
