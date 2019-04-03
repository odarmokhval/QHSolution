using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHomeTasksQH_OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            SkillPath skillPath = new SkillPath("SkP1", "some description here");
            skillPath.id = 15;
            Console.WriteLine($"Skill path title: '{skillPath.title}' and Skill path description: '{skillPath.description}' and id: {skillPath.id}");

            Asset asset = new Asset("asset1", "some description for asset");
            asset.id = 108;
            Console.WriteLine($"asset title: '{asset.title}' and asset description: '{asset.description}' and id: {asset.id}");
            Console.ReadKey();
        }

        class SkillPath {
            public int id { get; set; }
            public bool isPublished { get; set; }
            public bool isApplicationSpecific { get; set; }
            public string imageURL { get; set; }
            public string title { get; set; }
            public string description { get; set; } 

            public SkillPath(string title, string description)
            {
                this.title = title;
                this.description = description;
            }
        }

        class Asset
        {
            public int id { get; set; }
            public bool isPublished { get; set; }
            public string imageURL { get; set; }
            public string tipic { get; set; }
            public string category { get; set; }
            public string title { get; set; }
            public string description { get; set; }

            public Asset(string title, string description)
            {
                this.title = title;
                this.description = description;
            }
        }
    }
}
