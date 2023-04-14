using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    //Ссылка: https://docs.google.com/document/d/1dhWsZqo-d1x4uk0y45lDVnu4H91wRvpRWKJ0lfCizxY/edit?usp=sharelink
    public class Var9Сотрудник
    {
        public string Фамилия { get; }
        public string Имя { get; }
        public string Отчество { get; }
        public Var10Должность Должность { get; }
        public Var9Сотрудник(string фамилия, string имя, string отчество, Var10Должность должность)
        {
            Фамилия = фамилия;
            Имя = имя;
            Отчество = отчество;
            Должность = должность;
        }


    }
}
