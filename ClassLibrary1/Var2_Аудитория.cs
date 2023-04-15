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
            public Var9Сотрудник ОтветственныйСотрудники { get; }
            public byte КоличествоПосадочныхМест { get; }
            public byte КоличествоОкон { get; }
        public List<Var15Оборудование> Оборудования { get; }

        public Var2Аудитория(string название, Var9Сотрудник сотрудники, byte количествоМест, byte количествоОкон, List<Var15Оборудование> оборудование)
            {
                Название = название;
                ОтветственныйСотрудники = сотрудники;
                КоличествоПосадочныхМест = количествоМест;
                КоличествоОкон = количествоОкон;
                Оборудования = оборудование;
            }
    }
}
