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
        public static Var15_Оборудование Оборудование()
        {
            return new Var15_Оборудование();
        }
        public static Var9_Сотрудники Сотрудники()
        {
            return new Var_9Сотрудники();
        }
        public static Var2_Аудитория Аудитория()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine($"Введите название аудитории: ");
                    int название_Аудитории = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Введите кол-во мест в  аудитории: ");
                    int количество_Мест = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Введите кол-во окон в аудитории: ");
                    int количество_Окон = int.Parse(Console.ReadLine());
                    return new Var2_Аудитория(название_Аудитории, Сотрудники(), количество_Мест, количество_Окон, Оборудование());
                }
                catch
                {
                    Console.WriteLine("Введенв ошибка");
                }
            }
        }
    }

    internal class Var_9Сотрудники : Var9_Сотрудники
    {
    }
}
