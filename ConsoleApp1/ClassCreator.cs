using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ConsoleApp1
{
    static class ClassCreator
    {
        public static Var5_Студент Студент()
        {
            Console.WriteLine("Введите фамилия");
            string фамилия = Console.ReadLine();
            Console.WriteLine("Введите имя");
            string имя = Console.ReadLine();
            Console.WriteLine("Введите отчество");
            string отчество = Console.ReadLine();
            Console.WriteLine("Введите дату рождения в формате dd.mm.yyyy");
            string дата_Рождения = Console.ReadLine();
            while (!DateTime.TryParseExact(дата_Рождения, "dd.mm.yyyy", DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None, out DateTime дата) && дата_Рождения != "")
            {
                Console.WriteLine("Введите дату рождения в формате dd.mm.yyyy");
                дата_Рождения = Console.ReadLine();
            }
            if (дата_Рождения == "")
            {
                дата_Рождения = DateTime.Now.ToShortDateString();
            }
            return new Var5_Студент(фамилия, имя, отчество, Группа(), дата_Рождения);
        }
        public static Var4_Группа Группа()
        {
            while(true) 
            {

                try
                {


                    Console.WriteLine("Ввидите название группы");
                    string название = Console.ReadLine();
                    Console.WriteLine("Ввидите сокращение");
                    string сокращение = Console.ReadLine();
                    Console.WriteLine("Введите численность");
                    int численность = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ввидите год поступление");
                    int год_поступления = int.Parse(Console.ReadLine());
                    return new Var4_Группа(название, сокращение, численность, год_поступления, Сотрудники(), Специальность());
                }
                catch
                {
                    Console.WriteLine("Введена ошибка");
                }
            }

        }
        public static Var6_Специальность Специальность()
        {
            return new Var6_Специальность();
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
