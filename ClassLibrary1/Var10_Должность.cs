using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
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
