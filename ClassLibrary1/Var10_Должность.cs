using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    //Ссылка: https://docs.google.com/document/d/1yBWzXRuxmOQiPQs9TyNx8tNgq6nWF42Sjn-mgT_-5nY/edit?usp=share_link
    public class Var10_Должность
    {
        public string Название { get; }
        public string Оклад { get; }
        public Var11_Подразделение подразделение { get; }
        public Var10_Должность(string название, string оклад, Var11_Подразделение подразделение)
        {
            Название = название;
            Оклад = оклад;
            this.подразделение = подразделение;
        }
    }

}
