using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    //Ссылка: https://docs.google.com/document/d/1JN0SjEeelhtpKzoJqkva5JRePiMCLzyYPcI0Je8m7qU/edit?usp=share_link
    public class Var12_Организация
    {
        public string Название { get; }
        public string Юридический_адрес { get; }
        public string Фактический_адрес { get; }
        public Var9_Сотрудники Руководитель { get; }

        public Var12_Организация(string название, string юридический_адрес, string фактический_адрес, Var9_Сотрудники руководитель)
        {
            Название = название;
            Юридический_адрес = юридический_адрес;
            Фактический_адрес = фактический_адрес;
            Руководитель = руководитель;
        }
    }
}
