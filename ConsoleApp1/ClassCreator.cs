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
                    string юридическийАдрес = Console.ReadLine();

                    Console.WriteLine("Введите фактический адрес организации.");
                    string фактическийАдрес = Console.ReadLine();

                    return new Var12Организация(название, юридическийАдрес, фактическийАдрес, Сотрудник());
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
            while (!DateTime.TryParseExact(датаРождения, "dd.mm.yyyy", DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None, out _) && датаРождения != "")
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
            while (true)
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
                    return new Var4Группа(название, сокращение, численность, годпоступления, Сотрудник(), Специальность());
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
            return new Var3Дисциплина(название, сокращение);
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
        public static Var9Сотрудник Сотрудник()
        {
            Console.Write("Введите фамилию: ");
            string фамилия = Console.ReadLine();
            Console.Write("Введите имя: ");
            string имя = Console.ReadLine();
            Console.Write("Введите отчество: ");
            string отчество = Console.ReadLine();
            return new Var9Сотрудник(фамилия, имя, отчество, Должность());
        }

        public static Var10Должность Должность()
        {
            Console.Write("Введите название: ");
            string название = Console.ReadLine();
            while (true)
            {
                try
                {
                    Console.Write("Введите оклад: ");
                    decimal оклад = decimal.Parse(Console.ReadLine());
                    return new Var10Должность(название, оклад, Подразделение());
                }
                catch
                {
                    Console.WriteLine("Неверно введён оклад");
                }
            }
        }
        public static Var11Подразделение Подразделение()
        {
            Console.WriteLine("Введите название подразделения ");
            string название = Console.ReadLine();
            return new Var11Подразделение(название, Сотрудник(), Организация());
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
                    List<Var15Оборудование> оборудование = new List<Var15Оборудование>();
                    for (int i = 0; i < 5; i++)
                    {
                        оборудование.Add(new Var15Оборудование() { });
                    }
                    return new Var2Аудитория(названиеАудитории, Сотрудник(), количествоМест, количествоОкон, оборудование);
                }
                catch
                {
                    Console.WriteLine("Введенв ошибка");
                }
            }
        }
        public static Var7Пара Пара()
        {
            {
                Console.WriteLine($"Введите время начала пары в формате (HH:mm): ");
                string ВремяНачала = Console.ReadLine();
                Console.WriteLine($"Введите время окончания пары в формате (HH:mm): ");
                string ВремяОкончания = Console.ReadLine();
                Console.WriteLine($"Введите время начала перерыва в формате (HH:mm): ");
                string ВремяНачалаПерерыва = Console.ReadLine();
                Console.WriteLine($"Введите время окончания перерыва в формате (HH:mm): ");
                string ВремяОкончанияПерерыва = Console.ReadLine();
                if (!((ВремяНачала != "") && (TimeSpan.TryParse(ВремяНачала, out TimeSpan StartTimePara))))
                {
                    StartTimePara = DateTime.Now.TimeOfDay;
                }
                if (!((ВремяОкончания != "") && (TimeSpan.TryParse(ВремяОкончания, out TimeSpan EndTimePara))))
                {
                    EndTimePara = DateTime.Now.TimeOfDay;
                }
                if (!((ВремяНачалаПерерыва != "") && (TimeSpan.TryParse(ВремяНачалаПерерыва, out TimeSpan StartTimePereriv))))
                {
                    StartTimePereriv = DateTime.Now.TimeOfDay;
                }
                if (!((ВремяОкончанияПерерыва != "") && (TimeSpan.TryParse(ВремяОкончанияПерерыва, out TimeSpan EndTimePereriv))))
                {
                    EndTimePereriv = DateTime.Now.TimeOfDay;
                }
                return new Var7Пара(StartTimePara, EndTimePara, StartTimePereriv, EndTimePereriv, Смена());
            }
        }
    }
}
