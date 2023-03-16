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
        public static Оборудование Оборудование()
        {
            return new Оборудование();
        }
        public static Сотрудники Сотрудники()
        {
            return new Сотрудники();
        }
         public static Аудитория Аудитория()
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
                    return new Аудитория(название_Аудитории, Сотрудники(), количество_Мест, количество_Окон, Оборудование());
                }
                catch
                {
                    Console.WriteLine("Введенв ошибка");
                }
            }
        }
    }
}
