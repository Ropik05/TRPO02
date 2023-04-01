using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    //Ссылка: https://docs.google.com/document/d/1XUtn0QpVUQmailvo24lJ3XjJT5NP0SPjzivPOF1N9A/edit?usp=sharelink
    public class Var11Подразделение
    {
        public string Названиеподразделения { get; }
        public string Руководитель { get; }
        public Var9Сотрудники Сотрудники { get; }
        public Var12Организация Организация { get; }
        public Var11Подразделение(string названиеподразделения, Var9Сотрудники сотрудники, Var12Организация организация)
        {
            Названиеподразделения = названиеподразделения;
            Организация = организация;
            Сотрудники = сотрудники;
        }
    }
}
