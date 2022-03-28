using System.Collections.Generic;
using Projeto.ContentContext.Enums;

namespace Projeto.ContentContext
{
    public class Course : Content
    {
        public Course(string title, string url) : base(title, url)
        {
            //start object not to throw exception
            Modules = new List<Module>();
        }
        public string Tag { get; set; }
        public IList<Module> Modules { get; set; }
        public int DurationInMinutes { get; set; }
        public EContentLevel Level { get; set; }
    }
}