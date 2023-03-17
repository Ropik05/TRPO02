using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.Write("Введите имя создаваемого класса: ");
                switch (Console.ReadLine())
                {
                    case "ClassA": UI.Print(ClassCreator.ClassA()); break;
                    case "ClassB": UI.Print(ClassCreator.ClassB()); break;
                    case "Аудитория": UI.Print(ClassCreator.Аудитория()); break;
                    case "Дисциплина": UI.Print(ClassCreator.Дисциплина()); break;
                    case "Группа": UI.Print(ClassCreator.Группа()); break;
                    case "Студент": UI.Print(ClassCreator.Студент()); break;
                    default: Console.WriteLine("Этот класс не реализован"); break;
                }
            }
        }
    }
}
