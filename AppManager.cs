using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using long_bong_midterm.CustomClasses;

namespace long_bong_midterm.CustomClasses
{
    internal class AppManager
    {
        private List<TaskManager> all;

        internal List<TaskManager> All { get => all; set => all = value; }

        public AppManager()
        {
            all = new List<TaskManager>();
        }
        public AppManager(DateTime date)
        {
            all = new List<TaskManager>();
            TaskManager taskManager = new TaskManager(date);
            all.Add(taskManager);
        }
        public AppManager(List<TaskManager> all)
        {
            this.all = all ?? new List<TaskManager>();
        }


        public void readTextFile()
        {
            string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string filePath = Path.Combine(currentDirectory, "tasks.txt");

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                TaskManager currentManager = null; 
                while ((line = reader.ReadLine()) != null)
                {
                    string trimmedLine = line.Replace("\t", "");
                    int tabCount = line.Length - trimmedLine.Length; 
                    if (tabCount == 0)
                    {
                        currentManager = new TaskManager();
                        currentManager.readTextFile(line);
                        all.Add(currentManager);
                    }
                    else
                    {
                        all.Last().readTextFile(line); 
                    }
                }
            }
        }

        public void printTextFile()
        {
            string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string filePath = Path.Combine(currentDirectory, "tasks.txt");
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var day in all)
                {
                    day.printTextFile(writer);
                }
            }

        }
        public void PopulateListView(ListView listView, string listType)
        {
            listView.Items.Clear(); 
            foreach (var taskManager in all)
            {
                foreach (var mainTask in taskManager.MainTasks)
                {
                    if (listType=="All"||mainTask.Type==listType )
                    {
                        ListViewItem item = new ListViewItem(taskManager.Date.ToString("dd/MM/yyyy")); 
                        item.SubItems.Add(mainTask.MainTaskName);
                        item.SubItems.Add(mainTask.Hour.ToString());
                        item.SubItems.Add(mainTask.Note);
                        item.SubItems.Add(mainTask.Type);
                        string completionStatus = mainTask.Completed ? "Completed" : "Pending";
                        item.SubItems.Add(completionStatus);
                        if (mainTask.Completed)
                        {
                            item.ForeColor = System.Drawing.Color.Gray; 
                        }
                        listView.Items.Add(item);
                    }
                }
            }
            MoveCompletedTasksToBottom(listView);
        }

        private void MoveCompletedTasksToBottom(ListView listView)
        {
            List<ListViewItem> completedTasks = new List<ListViewItem>();

            foreach (ListViewItem item in listView.Items)
            {
                if (item.SubItems.Count > 5 && item.SubItems[5].Text == "Completed")
                {
                    completedTasks.Add(item);
                }
            }

            foreach (ListViewItem item in completedTasks)
            {
                listView.Items.Remove(item);
            }

            foreach (ListViewItem item in completedTasks)
            {
                listView.Items.Add(item);
            }
        }
    }
}
