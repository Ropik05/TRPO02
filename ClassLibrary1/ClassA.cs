using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class ClassA
    {
        public string Name { get; }
        public string LastName { get; }

        public ClassA(string name, string lastName)
        {
            Name = name;
            LastName = lastName;
        }
    }
}
