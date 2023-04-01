using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    //Ссылка: https://docs.google.com/document/d/1qZEaADy71rJCOuNSTpyhh-f-NhSL2a6DCm88EgFO20o/edit?usp=sharelink
    public class Var4Группа
    {
       public string Названиегруппы { get; }
        public string Сокращение { get; }
        public int Численность { get; }
        public int Годпоступления { get; }
        public Var9Сотрудники Сотрудники { get; }
        public Var6Специальность Специальность { get; }
        public Var4Группа(string названиегруппы, string сокращение, int численность, int годпоступления, Var9Сотрудники сотрудники, Var6Специальность специальность)
        {
            Названиегруппы = названиегруппы;
            Сокращение = сокращение;
            Численность = численность;
            Годпоступления = годпоступления;
            Сотрудники = сотрудники;
            Специальность = специальность;
        }
    }
    
}
