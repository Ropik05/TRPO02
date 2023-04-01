using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    //Ссылка: https://docs.google.com/document/d/1JN0SjEeelhtpKzoJqkva5JRePiMCLzyYPcI0Je8m7qU/edit?usp=sharelink
    public class Var12Организация
    {
        public string Название { get; }
        public string ЮридическийАдрес { get; }
        public string ФактическийАдрес { get; }
        public Var9Сотрудник Руководитель { get; }

        public Var12Организация(string название, string юридическийАдрес, string фактическийАдрес, Var9Сотрудник руководитель)
        {
            Название = название;
            ЮридическийАдрес = юридическийАдрес;
            ФактическийАдрес = фактическийАдрес;
            Руководитель = руководитель;
        }
    }
}
