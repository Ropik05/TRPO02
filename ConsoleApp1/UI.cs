using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ConsoleApp1
{
    static class UI
    {
        public static void Print(Var5_Студент Студент)
        {
            Console.WriteLine($"Студент.Фамилия = {Студент.Фамилия}");
            Console.WriteLine($"Студент.Имя = {Студент.Имя}");
            Console.WriteLine($"Студент.Отчество = {Студент.Отчество}");
            Print(Студент.Группа);
            Console.WriteLine($"Студент.Дата_Рождения = {Студент.Дата_Рождения}");
        }
        public static void Print(Var4_Группа группа)
        {
            Console.WriteLine($"Группа.Название = {группа.Название_группы}");
            Console.WriteLine($"Группа.сокращение = {группа.Сокращение}");
            Console.WriteLine($"Группа.численность = {группа.Численность}");
            Console.WriteLine($"Группа.год поступление = {группа.Год_поступления}");
            Print(группа.Сотрудники);
            Print(группа.Специальность);
        }
        public static void Print(Var6_Специальность cпециальность)
        {

        }
        public static void Print(Var15_Оборудование оборудование)
        {

        }
        public static void Print(Var8_Смена смена)
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

        public static void Print(Var10_Должность должность)
        {
            Console.WriteLine($"Должность.Название = {должность.Название}");
            Console.WriteLine($"Должность.Оклад = {должность.Оклад}");
            Print(должность.подразделение);
        }
        public static void Print(Var11_Подразделение подразделение)
        {

        }

        public static void Print(Var7_Пара пара)
        {
            Console.WriteLine("Время начала пары = " + (пара.ЧасыНачалаПары < 10 ? "0" : "") + пара.ЧасыНачалаПары + ":" + (пара.МинутыНачалаПары < 10 ? "0" : "") + пара.МинутыНачалаПары);
            Console.WriteLine("Время начала пары = " + (пара.ЧасыКонцаПары < 10 ? "0" : "") + пара.ЧасыКонцаПары + ":" + (пара.МинутыКонцаПары < 10 ? "0" : "") + пара.МинутыКонцаПары);
            Console.WriteLine("Время начала пары = " + (пара.ЧасыНачалаПерерыва < 10 ? "0" : "") + пара.ЧасыНачалаПерерыва + ":" + (пара.МинутыНачалаПерерыва < 10 ? "0" : "") + пара.МинутыНачалаПерерыва);
            Console.WriteLine("Время начала пары = " + (пара.ЧасыКонцаПерерыва < 10 ? "0" : "") + пара.ЧасыКонцаПерерыва + ":" + (пара.МинутыКонцаПерерыва < 10 ? "0" : "") + пара.МинутыКонцаПерерыва);
            Print(пара.Смена);
        }
    }
}
