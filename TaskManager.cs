using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace long_bong_midterm.CustomClasses
{
    internal class TaskManager
    {
        private DateTime date; // Ngày của TaskManager
        private List<MainTask> mainTasks; // Danh sách các MainTask

        // Thuộc tính truy cập
        public DateTime Date { get => date; set => date = value; }
        internal List<MainTask> MainTasks { get => mainTasks; set => mainTasks = value; }

        // Constructor không tham số
        public TaskManager()
        {
            date = DateTime.Now.Date; // Mặc định là ngày hiện tại
            mainTasks = new List<MainTask>();
        }

        // Constructor có tham số
        public TaskManager(DateTime date)
        {
            this.date = date.Date;
            mainTasks = new List<MainTask>();
        }

        // Constructor đầy đủ
        public TaskManager(DateTime date, List<MainTask> mainTasks)
        {
            this.date = date.Date;
            this.mainTasks = mainTasks ?? new List<MainTask>();
        }

        // Phương thức thêm MainTask vào danh sách
        public void AddTask(MainTask task)
        {
            mainTasks.Add(task);
        }

        public void readTextFile(string line)
        {
            string trimmedLine = line.Replace("\t", "");
            int tabCount = line.Length - trimmedLine.Length; 
            if (tabCount == 0)
            {
                DateTime taskDate;
                if (DateTime.TryParseExact(line, "dd/MM/yyyy", null, DateTimeStyles.None, out taskDate))
                {
                    date = taskDate; 
                }
            }
            else if (tabCount == 1)
            {
                MainTask newMainTask = new MainTask();
                newMainTask.readTextFile(line); 
                mainTasks.Add(newMainTask);
            }
            else if (tabCount == 2)
            {
                if (mainTasks.Count > 0)
                {
                    mainTasks.Last().readTextFile(line);
                }
            }
        }




        public void printTextFile(StreamWriter writer)
        {
            writer.WriteLine($"{date.ToShortDateString()}");

            foreach (var task in mainTasks)
            {
                task.printTextFile(writer); 
            }
        }
    }
}
