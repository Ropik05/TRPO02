using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ConsoleApp1
{
    static class UI
    {
        public static void Print(ClassA classA)
        {
            Console.WriteLine($"ClassA.Name={classA.Name}");
            Console.WriteLine($"ClassA.LastName={classA.LastName}");
        }

        public static void Print(ClassB classB)
        {
            Print(classB.ClassA);
            Print(classB.ClassC);
        }

        public static void Print(ClassC classC)
        {

        }
        public static void Print(Var3_Дисциплина Дисциплина)
        {
            Console.WriteLine($"Var3_Дисциплина Название = {Дисциплина.Название}");
            Console.WriteLine($"Var3_Дисциплина Сокращение = {Дисциплина.Сокращение}");
        }
    }
}
