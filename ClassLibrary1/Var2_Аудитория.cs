using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    //Ссылка: https://docs.google.com/document/d/10XwtkjNB6-lRehWP_7qbgWC1nn_oIpa28ezyPXX3B28/edit?usp=share_link
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
