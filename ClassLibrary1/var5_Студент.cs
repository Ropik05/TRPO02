using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
   public class var5_Студент
    {
        public string Фамилия { get; }
        public string Имя { get; }
        public string Отчество { get; }
        public string Дата_Рождения { get;  }
        public Var4_Группа Группа { get; }
        public var5_Студент(string фамилия, string имя, string отчество, Var4_Группа группа, string дата_Рождения)
        {
            Фамилия = фамилия;
            Имя = имя;
            Отчество = отчество;
            Дата_Рождения = дата_Рождения;
            Группа = группа;
        }
    }
}
