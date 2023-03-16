using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Var3_Дисциплина
    {
        public string Название { get;}
        public string Сокращение { get;}

        public Var3_Дисциплина(string название, string сокращение)
        {
            Название = название;
            Сокращение = сокращение;
        }   
    }
}
