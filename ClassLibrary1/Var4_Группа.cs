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
       public string Название { get; }
        public string Сокращение { get; }
        public int Численность { get; }
        public int ГодПоступления { get; }
        public Var9Сотрудник КлассныйРуководитель { get; }
        public Var6Специальность Специальность { get; }
        public Var4Группа(string названиеГруппы, string сокращение, int численность, int годПоступления, Var9Сотрудник классныйРуководитель, Var6Специальность специальность)
        {
            Название = названиеГруппы;
            Сокращение = сокращение;
            Численность = численность;
            ГодПоступления = годПоступления;
            КлассныйРуководитель = классныйРуководитель;
            Специальность = специальность;
        }
    }
    
}
