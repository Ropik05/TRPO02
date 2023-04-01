using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    //Ссылка: https://docs.google.com/document/d/1yBWzXRuxmOQiPQs9TyNx8tNgq6nWF42Sjn-mgT-5nY/edit?usp=sharelink
    public class Var10Должность
    {
        public string Название { get; }
        public decimal Оклад { get; }
        public Var11Подразделение Подразделение { get; }
        public Var10Должность(string название, decimal оклад, Var11Подразделение подразделение)
        {
            Название = название;
            Оклад = оклад;
            Подразделение = подразделение;
        }
    }

}
