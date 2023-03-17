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
        public static Var12_Организация Организация()
        {
            while (true)
            {

                try
                {
                    Console.WriteLine("Ввeдите название организации.");
                    string название = Console.ReadLine();

                    Console.WriteLine("Введите юридический адрес организации.");
                    string юридический_адрес = Console.ReadLine();

                    Console.WriteLine("Введите фактический адрес организации.");
                    string фактический_адрес = Console.ReadLine();

                    return new Var12_Организация(название, юридический_адрес, фактический_адрес, Сотрудники());
                }
                catch
                {
                    Console.WriteLine("Введена ошибка!");
                }
            }
        }
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
        public static Var8_Смена Смена()
        {
            Console.Write("Введите название: ");
            string название = Console.ReadLine();
            return new Var8_Смена(название);
        }
        public static Var9_Сотрудники Сотрудники()
        {
            return new Var_9Сотрудники();
        }

        public static Var10_Должность Должность()
        {
            Console.Write("Введите название: ");
            string название = Console.ReadLine();
            Console.Write("Введите оклад: ");
            string оклад = Console.ReadLine();
            return new Var10_Должность(название, оклад, Подразделение());
        }
        public static Var11_Подразделение Подразделение()
        {
            return new Var11_Подразделение();
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
        public static Var7_Пара Пара()
        {
            Console.WriteLine($"Введите часы начала пары: ");
            if (int.TryParse(Console.ReadLine(), out int ЧасыНачалаПары))
            {
                if (ЧасыНачалаПары < 0 || ЧасыНачалаПары >= 23)
                {
                    Console.WriteLine($"Неверно введено время, установлено текущее");
                    ЧасыНачалаПары = DateTime.Now.Hour;
                }
            }
            else
            {
                Console.WriteLine($"Неверно введено время, установлено текущее");
                ЧасыНачалаПары = DateTime.Now.Hour;
            }
            Console.WriteLine($"Введите минуты начала пары: ");
            if (int.TryParse(Console.ReadLine(), out int МинутыНачалаПары))
            {
                if (МинутыНачалаПары < 0 || МинутыНачалаПары >= 59)
                {
                    Console.WriteLine($"Неверно введено время, установлено текущее");
                    МинутыНачалаПары = DateTime.Now.Minute;
                }
            }
            else
            {
                Console.WriteLine($"Неверно введено время, установлено текущее");
                МинутыНачалаПары = DateTime.Now.Minute;
            }
            Console.WriteLine($"Введите часы окончания пары: ");
            if (int.TryParse(Console.ReadLine(), out int ЧасыКонцаПары))
            {
                if (ЧасыКонцаПары < 0 || ЧасыКонцаПары >= 23)
                {
                    Console.WriteLine($"Неверно введено время, установлено текущее");
                    ЧасыКонцаПары = DateTime.Now.Hour;
                }
            }
            else
            {
                Console.WriteLine($"Неверно введено время, установлено текущее");
                ЧасыКонцаПары = DateTime.Now.Hour;
            }
            Console.WriteLine($"Введите минуты окончания пары: ");
            if (int.TryParse(Console.ReadLine(), out int МинутыКонцаПары))
            {
                if (МинутыКонцаПары < 0 || МинутыКонцаПары >= 59)
                {
                    Console.WriteLine($"Неверно введено время, установлено текущее");
                    МинутыКонцаПары = DateTime.Now.Minute;
                }
            }
            else
            {
                Console.WriteLine($"Неверно введено время, установлено текущее");
                МинутыКонцаПары = DateTime.Now.Minute;
            }
            Console.WriteLine($"Введите часы начала перерыва: ");
            if (int.TryParse(Console.ReadLine(), out int ЧасыНачалаПерерыва))
            {
                if (ЧасыНачалаПерерыва < 0 || ЧасыНачалаПерерыва >= 23)
                {
                    Console.WriteLine($"Неверно введено время, установлено текущее");
                    ЧасыНачалаПерерыва = DateTime.Now.Hour;
                }
            }
            else
            {
                Console.WriteLine($"Неверно введено время, установлено текущее");
                ЧасыНачалаПерерыва = DateTime.Now.Hour;
            }
            Console.WriteLine($"Введите минуты начала перерыва: ");
            if (int.TryParse(Console.ReadLine(), out int МинутыНачалаПерерыва))
            {
                if (МинутыНачалаПерерыва < 0 || МинутыНачалаПерерыва >= 59)
                {
                    Console.WriteLine($"Неверно введено время, установлено текущее");
                    МинутыНачалаПерерыва = DateTime.Now.Minute;
                }
            }
            else
            {
                Console.WriteLine($"Неверно введено время, установлено текущее");
                МинутыНачалаПерерыва = DateTime.Now.Minute;
            }
            Console.WriteLine($"Введите часы окончания перерыва: ");
            if (int.TryParse(Console.ReadLine(), out int ЧасыКонцаПерерыва))
            {
                if (ЧасыКонцаПерерыва < 0 || ЧасыКонцаПерерыва >= 23)
                {
                    Console.WriteLine($"Неверно введено время, установлено текущее");
                    ЧасыКонцаПерерыва = DateTime.Now.Hour;
                }
            }
            else
            {
                Console.WriteLine($"Неверно введено время, установлено текущее");
                ЧасыКонцаПерерыва = DateTime.Now.Hour;
            }
            Console.WriteLine($"Введите минуты окончания перерыва: ");
            if (int.TryParse(Console.ReadLine(), out int МинутыКонцаПерерыва))
            {
                if (МинутыКонцаПерерыва < 0 || МинутыКонцаПерерыва >= 59)
                {
                    Console.WriteLine($"Неверно введено время, установлено текущее");
                    МинутыКонцаПерерыва = DateTime.Now.Minute;
                }
            }
            else
            {
                Console.WriteLine($"Неверно введено время, установлено текущее");
                МинутыКонцаПерерыва = DateTime.Now.Minute;
            }
            return new Var7_Пара(ЧасыНачалаПары, МинутыНачалаПары, ЧасыКонцаПары, МинутыКонцаПары,
                ЧасыНачалаПерерыва, МинутыНачалаПерерыва, ЧасыКонцаПерерыва, МинутыКонцаПерерыва, Смена());
        }
    }

    internal class Var_9Сотрудники : Var9_Сотрудники
    {
    }
}
