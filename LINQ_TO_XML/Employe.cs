using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_TO_XML
{
    enum EmployeTypes
    {
        Programmer = 0, 
        Editor,
        Deployer

    }
    class Employe
    {
        public string FirstName;
        public string LastName;
        public EmployeTypes EmployerType;
    }
}
