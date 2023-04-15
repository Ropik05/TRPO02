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

            public string Название { get; }
            public Var9Сотрудник Сотрудники { get; }
            public uint КоличествоМест { get; }
            public uint КоличествоОкон { get; }
        public List<Var15Оборудование> Оборудования { get; }

        public Var2Аудитория(string название, Var9Сотрудник сотрудники, uint количествоМест, uint количествоОкон, List<Var15Оборудование> оборудование)
            {
                Название = название;
                Сотрудники = сотрудники;
                КоличествоМест = количествоМест;
                КоличествоОкон = количествоОкон;
                Оборудования = оборудование;
            }
    }
}
