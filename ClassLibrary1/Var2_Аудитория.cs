using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    //Ссылка: https://docs.google.com/document/d/10XwtkjNB6-lRehWP7qbgWC1nnoIpa28ezyPXX3B28/edit?usp=sharelink
    public class Var2Аудитория
    {

            public int НазваниеАудитории { get; }
            public Var9Сотрудник Сотрудники { get; }
            public int КоличествоМест { get; }
            public int КоличествоОкон { get; }
        public List<Var15Оборудование> Оборудование { get; }

        public Var2Аудитория(int названиеАудитории, Var9Сотрудник сотрудники, int количествоМест, int количествоОкон, List<Var15Оборудование> оборудование)
            {
                НазваниеАудитории = названиеАудитории;
                Сотрудники = сотрудники;
                КоличествоМест = количествоМест;
                КоличествоОкон = количествоОкон;
                Оборудование = оборудование;
            }
    }
}
