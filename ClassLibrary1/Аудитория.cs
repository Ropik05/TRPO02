using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Аудитория
    {
        public int Название_Аудитории { get; }
        public Сотрудники Сотрудники { get; }
        public int Количество_Мест { get; }
        public int Количество_Окон { get; }
        public Оборудование Оборудование { get; }

        public Аудитория(int название_Аудитории, Сотрудники сотрудники, int количество_Мест, int количество_Окон, Оборудование оборудование)
        {
            Название_Аудитории = название_Аудитории;
            Сотрудники = сотрудники;
            Количество_Мест = количество_Мест;
            Количество_Окон = количество_Окон;
            Оборудование = оборудование;
        }
    }
}
