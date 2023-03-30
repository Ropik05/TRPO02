using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Var11_Подразделение
    {
        public string Название_подразделения { get; }
        public string Руководитель { get; }
        public Var9_Сотрудники Сотрудники { get; }
        public Var12_Организация Организация { get; }
        public Var11_Подразделение(string название_подразделения, Var9_Сотрудники сотрудники, Var12_Организация организация)
        {
            Название_подразделения = название_подразделения;
            Организация = организация;
            Сотрудники = сотрудники;
        }
    }
}
