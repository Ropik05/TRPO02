using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    //Ссылка: https://docs.google.com/document/d/1qCEMkbMRvvHP361IFDeWgSpHfVRUp6BV67nrsjl3fSw/edit?usp=share_link
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
