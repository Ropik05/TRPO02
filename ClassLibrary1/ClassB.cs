using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class ClassB
    {
        public ClassA ClassA { get; }
        public ClassC ClassC { get; }

        public ClassB(ClassA classA, ClassC classC)
        {
            ClassA = classA;
            ClassC = classC;
        }
    }
}
