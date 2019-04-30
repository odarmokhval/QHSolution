using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHomeTaskQH5
{
    class Degree
    {
        public string Name { get; private set; }

        public List<Course> Courses { get; set; }

        public Degree(string name)
        {
            Name = name;
        }
    }
}
