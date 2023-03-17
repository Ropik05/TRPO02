using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
   public class Var4_Группа
    {
       public string Название_группы { get; }
        public string Сокращение { get; }
        public int Численность { get; }
        public int Год_поступления { get; }
        public Var9_Сотрудники Сотрудники { get; }
        public Var6_Специальность Специальность { get; }
        public Var4_Группа(string название_группы, string сокращение, int численность, int год_поступления, Var9_Сотрудники сотрудники, Var6_Специальность специальность)
        {
            Название_группы = название_группы;
            Сокращение = сокращение;
            Численность = численность;
            Год_поступления = год_поступления;
            Сотрудники = сотрудники;
            Специальность = специальность;
        }
    }
    
}
