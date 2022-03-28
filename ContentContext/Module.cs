using System.Collections.Generic;
using Projeto.SharedContext;

namespace Projeto.ContentContext
{
    public class Module : Base
    {
        public Module()
        {
            //start object not to throw exception
            Lectures = new List<Lecture>();
        }
        public int Order { get; set; }
        public string Title { get; set; }
        public IList<Lecture> Lectures { get; set; }
    }
}