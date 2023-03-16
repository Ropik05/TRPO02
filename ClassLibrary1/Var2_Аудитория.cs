using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Var2_Аудитория
    {

            public int Название_Аудитории { get; }
            public Var9_Сотрудники Сотрудники { get; }
            public int Количество_Мест { get; }
            public int Количество_Окон { get; }
            public Var15_Оборудование Оборудование { get; }

            public Var2_Аудитория(int название_Аудитории, Var9_Сотрудники сотрудники, int количество_Мест, int количество_Окон, Var15_Оборудование оборудование)
            {
                Название_Аудитории = название_Аудитории;
                Сотрудники = сотрудники;
                Количество_Мест = количество_Мест;
                Количество_Окон = количество_Окон;
                Оборудование = оборудование;
            }
    }
}
