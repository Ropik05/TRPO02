using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Должность
    {
        public string Название { get; }
        public string Оклад { get; }
        public Подразделение подразделение { get; }
        public Должность(string название, string оклад, Подразделение подразделение)
        {
            Название = название;
            Оклад = оклад;
            this.подразделение = подразделение;
        }
    }
}
