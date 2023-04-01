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
        public static Var12Организация Организация()
        {
            while (true)
            {

                try
                {
                    Console.WriteLine("Ввeдите название организации.");
                    string название = Console.ReadLine();

                    Console.WriteLine("Введите юридический адрес организации.");
                    string юридическийадрес = Console.ReadLine();

                    Console.WriteLine("Введите фактический адрес организации.");
                    string фактическийадрес = Console.ReadLine();

                    return new Var12Организация(название, юридическийадрес, фактическийадрес, Сотрудники());
                }
                catch
                {
                    Console.WriteLine("Введена ошибка!");
                }
            }
        }
        public static Var5Студент Студент()
        {
            Console.WriteLine("Введите фамилия");
            string фамилия = Console.ReadLine();
            Console.WriteLine("Введите имя");
            string имя = Console.ReadLine();
            Console.WriteLine("Введите отчество");
            string отчество = Console.ReadLine();
            Console.WriteLine("Введите дату рождения в формате dd.mm.yyyy");
            string датаРождения = Console.ReadLine();
            while (!DateTime.TryParseExact(датаРождения, "dd.mm.yyyy", DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None, out DateTime дата) && датаРождения != "")
            {
                Console.WriteLine("Введите дату рождения в формате dd.mm.yyyy");
                датаРождения = Console.ReadLine();
            }
            if (датаРождения == "")
            {
                датаРождения = DateTime.Now.ToShortDateString();
            }
            return new Var5Студент(фамилия, имя, отчество, Группа(), датаРождения);
        }
        public static Var4Группа Группа()
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
                    int годпоступления = int.Parse(Console.ReadLine());
                    return new Var4Группа(название, сокращение, численность, годпоступления, Сотрудники(), Специальность());
                }
                catch
                {
                    Console.WriteLine("Введенны неверные данные");
                }
            }

        }
        public static Var6Специальность Специальность()
        {
            return new Var6Специальность();
        }
        public static Var3Дисциплина Дисциплина()
        {
            Console.Write("Введите название: ");
            string название = Console.ReadLine();
            Console.Write("Введите сокращение: ");
            string сокращение = Console.ReadLine();
            return new Var3Дисциплина(название,сокращение);
        }
        public static Var15Оборудование Оборудование()
        {
            return new Var15Оборудование();
        }
        public static Var8Смена Смена()
        {
            Console.Write("Введите название: ");
            string название = Console.ReadLine();
            return new Var8Смена(название);
        }
        public static Var9Сотрудники Сотрудники()
        {
            return new Var9Сотрудники();
        }

        public static Var10Должность Должность()
        {
            Console.Write("Введите название: ");
            string название = Console.ReadLine();
            Console.Write("Введите оклад: ");
            decimal оклад = Convert.ToDecimal(Console.ReadLine());
            return new Var10Должность(название, оклад, Подразделение());
        }
        public static Var11Подразделение Подразделение()
        {
            Console.Write("Введите название подразделения ");
            string названиеподразделения = Console.ReadLine();
            return new Var11Подразделение(названиеподразделения, Сотрудники(), Организация());
        }


        public static Var2Аудитория Аудитория()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine($"Введите название аудитории: ");
                    int названиеАудитории = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Введите кол-во мест в  аудитории: ");
                    int количествоМест = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Введите кол-во окон в аудитории: ");
                    int количествоОкон = int.Parse(Console.ReadLine());
                    return new Var2Аудитория(названиеАудитории, Сотрудники(), количествоМест, количествоОкон, Оборудование());
                }
                catch
                {
                    Console.WriteLine("Введенв ошибка");
                }
            }
        }
        public static Var7Пара Пара()
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
            return new Var7Пара(ЧасыНачалаПары, МинутыНачалаПары, ЧасыКонцаПары, МинутыКонцаПары,
                ЧасыНачалаПерерыва, МинутыНачалаПерерыва, ЧасыКонцаПерерыва, МинутыКонцаПерерыва, Смена());
        }
    }
}
