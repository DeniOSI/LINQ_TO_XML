using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LINQ_TO_XML
{
    class ProgramHandler
    {
       public void Display(XElement xlm)
        {
            Console.WriteLine("=====================================");
            Console.WriteLine($"Name - {(string)xlm.Element("FirstName")}, Family - {(string)xlm.Element("LastName")}");
            Console.WriteLine($"Type - {(string)xlm.Attribute("type")}");
            Console.WriteLine($"Experience - {(string)xlm.Attribute("experience")}");
            Console.WriteLine("======================================");
        }
    }
    class EditorHandler
    {
        public void Display(XElement xlm)
        {
            Console.WriteLine("=====================================");
            Console.WriteLine($"Name - {(string)xlm.Element("FirstName")}, Family - {(string)xlm.Element("LastName")}");
            Console.WriteLine($"Type - {(string)xlm.Attribute("type")}");
            Console.WriteLine("======================================");
        }
    }
}
