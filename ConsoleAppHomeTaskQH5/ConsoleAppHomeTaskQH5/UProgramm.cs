using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHomeTaskQH5
{
    class UProgramm
    {
        public string Name { get; set; }

        public List<Degree> Degrees { get; set; }      
        
        public UProgramm(string name)
        {
            Name = name;
        }

        public void displayData()
        {
            Console.WriteLine("Programm name: {0}", Name);
        }
    }
}
