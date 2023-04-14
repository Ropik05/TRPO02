using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    //Ссылка: https://docs.google.com/document/d/1FrtPd2tz85cDVhZCYXqL0wrByPjNbd6kUbjXzOzfLPc/edit?usp=sharelink
    public class Var5Студент
    {
        public string Фамилия { get; }
        public string Имя { get; }
        public string Отчество { get; }
        public string ДатаРождения { get; }
        public Var4Группа Группа { get; }
        public Var5Студент(string фамилия, string имя, string отчество, Var4Группа группа, string датаРождения)
        {
            Фамилия = фамилия;
            Имя = имя;
            Отчество = отчество;
            if (DateTime.TryParseExact(датаРождения, "dd.MM.yyyy", DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None, out DateTime DateOfBirth))
            {
                ДатаРождения = DateOfBirth.ToString("dd.MM.yyyy");
            }
            else ДатаРождения = DateTime.Now.ToShortDateString();
            Группа = группа;
        }
    }
}
