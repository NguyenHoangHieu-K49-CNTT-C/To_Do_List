using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace long_bong_midterm.CustomClasses
{
    internal class SubTask
    {
        private string subTaskName;
        private TimeOnly hour;
        private bool completed;
        private string note;

        public string SubTaskName { get => subTaskName; set => subTaskName = value; }
        public TimeOnly Hour { get => hour; set => hour = value; }
        public bool Completed { get => completed; set => completed = value; }
        public string Note { get => note; set => note = value; }

        public SubTask()
        {
            subTaskName = string.Empty;
            hour = TimeOnly.MinValue;
            completed = false;
            note = string.Empty;
        }
        public SubTask(string subTaskName, TimeOnly hour, bool completed, string note)
        {
            this.subTaskName = subTaskName;
            this.hour = hour;
            this.completed = completed;
            this.note = note;
        }
        public SubTask(SubTask subTask)
        {
            subTaskName = subTask.subTaskName;
            hour = subTask.hour;
            completed = subTask.completed;
            note = subTask.note;
        }

        public void readFromFile(string line)
        {
            string[] parts = line.Split(',');
            if (parts.Length >= 3) 
            {
                subTaskName = parts[0].Trim();                              
                if (TimeOnly.TryParse(parts[1].Trim(), out TimeOnly parsedHour))
                    hour = parsedHour; 
                else
                    hour = TimeOnly.MinValue;
                completed = parts[2].Trim().ToLower() == "hoàn thành";
                note = parts.Length > 3 ? parts[3].Trim() : string.Empty;
            }
        }

        public void printTextFile(StreamWriter writer)
        {
            writer.WriteLine($"\t\t{subTaskName}, {hour}, {(completed ? "hoàn thành" : "chưa hoàn thành")}, {note}");
        }
    }
}
