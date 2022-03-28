using System.Collections.Generic;
using Projeto.NotificationContext;

namespace Projeto.ContentContext
{
    public class Career : Content
    {
        public Career(string title, string url) : base(title, url)
        {
            //start object not to throw exception
            Items = new List<CareerItem>();
        }
        public int Courses { get; set; }
        public IList<CareerItem> Items { get; set; }
        public int TotalCourses => Items.Count; //Expression body
    }
}