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
        public static void Print(Var12Организация организация)
        {
            Console.WriteLine($"организация.Название = {организация.Название}");
            Console.WriteLine($"организация.ЮридическийАдрес = {организация.ЮридическийАдрес}");
            Console.WriteLine($"организация.ФактическийАдрес= {организация.ФактическийАдрес}");
            Print(организация.Руководитель);
        }

        public static void Print(Var5Студент Студент)
        {
            Console.WriteLine($"Студент.Фамилия = {Студент.Фамилия}");
            Console.WriteLine($"Студент.Имя = {Студент.Имя}");
            Console.WriteLine($"Студент.Отчество = {Студент.Отчество}");
            Print(Студент.Группа);
            Console.WriteLine($"Студент.ДатаРождения = {Студент.ДатаРождения}");
        }
        public static void Print(Var4Группа группа)
        {
            Console.WriteLine($"Группа.Название = {группа.Название}");
            Console.WriteLine($"Группа.сокращение = {группа.Сокращение}");
            Console.WriteLine($"Группа.численность = {группа.Численность}");
            Console.WriteLine($"Группа.год поступление = {группа.ГодПоступления}");
            Print(группа.КлассныйРуководитель);
            Print(группа.Специальность);
        }
        public static void Print(Var6Специальность cпециальность)
        {

        }
        public static void Print(Var15Оборудование оборудование)
        {

        }
        public static void Print(Var8Смена смена)
        {
            Console.WriteLine($"Var8Смена Название = {смена.Название}");
        }
        public static void Print(Var9Сотрудник сотрудники)
        {

        }
        public static void Print(Var3Дисциплина Дисциплина)
        {
            Console.WriteLine($"Var3Дисциплина Название = {Дисциплина.Название}");
            Console.WriteLine($"Var3Дисциплина Сокращение = {Дисциплина.Сокращение}");
        }
        public static void Print(Var2Аудитория аудитория)
        {
            Console.WriteLine($"Аудитория.НазваниеАудитории={аудитория.НазваниеАудитории}");
            Print(аудитория.Сотрудники);
            Console.WriteLine($"Аудитория.КоличествоМест={аудитория.КоличествоМест}");
            Console.WriteLine($"Аудитория.КоличествоОкон={аудитория.КоличествоОкон}");
            foreach (Var15Оборудование оборудование in аудитория.Оборудование)
            {
                Print(оборудование);
            }
        }

        public static void Print(Var10Должность должность)
        {
            Console.WriteLine($"Должность.Название = {должность.Название}");
            Console.WriteLine($"Должность.Оклад = {должность.Оклад}");
            Print(должность.Подразделение);
        }
        public static void Print(Var11Подразделение подразделение)
        {
            Console.WriteLine($"Подразделение.Название = {подразделение.Название}");
            Print(подразделение.Руководитель);
            Print(подразделение.Организация);
        }

        public static void Print(Var7Пара пара)
        {
            Console.WriteLine($"пара.ВремяНачалаПары = {пара.ВремяНачалаПары:HH:mm}");
            Console.WriteLine($"пара.ВремяОкончанияПары = {пара.ВремяОкончанияПары:HH:mm}");
            Console.WriteLine($"пара.ВремяНачалаПерерыва = {пара.ВремяНачалаПерерыва:HH:mm}");
            Console.WriteLine($"пара.ВремяОкончанияПерерыва = {пара.ВремяОкончанияПерерыва:HH:mm}");
            Print(пара.Смена);
        }
    }
}
