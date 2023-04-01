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
        public string Юридическийадрес { get; }
        public string Фактическийадрес { get; }
        public Var9Сотрудник Руководитель { get; }

        public Var12Организация(string название, string юридическийадрес, string фактическийадрес, Var9Сотрудник руководитель)
        {
            Название = название;
            Юридическийадрес = юридическийадрес;
            Фактическийадрес = фактическийадрес;
            Руководитель = руководитель;
        }
    }
}
