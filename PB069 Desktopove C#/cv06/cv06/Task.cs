using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv06
{
    public class Task
    {
        public string Name { get; private set; }
        public TaskPriority Priority { get; set; }
        public bool Complete { get; set; }
        public DateTime Deadline { get; set; }

        public Task(string name)
        {
            this.Name = name;
        }

        public override string ToString()
        {
            return String.Format("{0}, Priority : {1}, Completed : {2}, Deadline : {3:dd/MMMM/yyyy}", 
                                 Name, Priority, ((Complete) ? "Yes" : "No"),
                                 Deadline);
        }
    }

    public enum TaskPriority
    {
        Low,
        Medium,
        High
    }
}
