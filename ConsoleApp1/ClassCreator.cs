using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ConsoleApp1
{
    static class ClassCreator
    {
        public static ClassA ClassA()
        {
            Console.Write($"Введите имя: ");
            string name = Console.ReadLine();
            Console.Write($"Введите второе имя: ");
            string lastName = Console.ReadLine();
            return new ClassA(name, lastName);
        }

        public static ClassB ClassB()
        {
            return new ClassB(ClassA(), ClassC());
        }

        public static ClassC ClassC()
        {
            return new ClassC();
        }
        public static Var3_Дисциплина Дисциплина()
        {
            Console.Write("Введите название: ");
            string название = Console.ReadLine();
            Console.Write("Введите сокращение: ");
            string сокращение = Console.ReadLine();
            return new Var3_Дисциплина(название,сокращение);
        }
    }
}
