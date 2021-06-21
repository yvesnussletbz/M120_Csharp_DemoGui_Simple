using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCDemoM120.Models
{
    public class WorkLogEntry
    {
        public DateTime StartDate { get; set; } = DateTime.Now;
        public String StartTime { get; set; } = DateTime.Now.AddHours(-1).ToString("HH:mm");
        public DateTime EndDate { get; set; } = DateTime.Now;
        public String EndTime { get; set; } = DateTime.Now.ToString("HH:mm");
        public String Subject { get; set; }
        public String SelectedProject { get; set; }

        public List<String> Projects = new List<string> {"Project 1 - Meeting", "Project 1 - Implement", "Design Project: Meeting", "Design Project: Wireframe", "WorkLog Project: Implement", "WorkLog Project: Database" };
    }
}
