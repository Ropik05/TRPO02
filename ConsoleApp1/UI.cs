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
        public static void Print(Var6_Специальность специальность)
        {

        }

        public static void Print(ClassB classB)
        {
            Print(classB.ClassA);
            Print(classB.ClassC);
        }

        public static void Print(ClassC classC)
        {

        }
        public static void Print(Var15_Оборудование оборудование)
        {

        }
        public static void Print(Var9_Сотрудники сотрудники)
        {

        }
        public static void Print(Var3_Дисциплина Дисциплина)
        {
            Console.WriteLine($"Var3_Дисциплина Название = {Дисциплина.Название}");
            Console.WriteLine($"Var3_Дисциплина Сокращение = {Дисциплина.Сокращение}");
        }
        public static void Print(Var2_Аудитория аудитория)
        {
            Console.WriteLine($"Аудитория.Название_Аудитории={аудитория.Название_Аудитории}");
            Print(аудитория.Сотрудники);
            Console.WriteLine($"Аудитория.Количество_Мест={аудитория.Количество_Мест}");
            Console.WriteLine($"Аудитория.Количество_Окон={аудитория.Количество_Окон}");
            Print(аудитория.Оборудование);
        }
    }
}
