using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    //Ссылка: https://docs.google.com/document/d/1r4OjKXg55yj6ibHB778UEF5Z1nbUqGdXjpQXbTGWiQ/edit?usp=sharelink
    public class Var7Пара
    {
        public DateTime ВремяНачалаПары { get; }
        public DateTime ВремяОкончанияПары { get; }
        public DateTime ВремяНачалаПерерыва { get; }
        public DateTime ВремяОкончанияПерерыва { get; }
        public Var8Смена Смена { get; }
        public Var7Пара(string времяНачалаПары, string времяОкончанияПары, string времяНачалаПерерыва, string времяОкончанияПерерыва, Var8Смена смена)
        {
            if ((DateTime.TryParse(времяНачалаПары, out DateTime StartTimePara)) && (времяНачалаПары != ""))
            {
                ВремяНачалаПары = StartTimePara;
            }
            else
            {
                ВремяНачалаПары = DateTime.Now;
            }
            if ((DateTime.TryParse(времяОкончанияПары, out DateTime EndTimePara)) && (времяОкончанияПары != ""))
            {
                ВремяОкончанияПары = EndTimePara;
            }
            else
            {
                ВремяОкончанияПары = DateTime.Now;
            }
            if ((DateTime.TryParse(времяНачалаПерерыва, out DateTime StartTimePereriv)) && (времяНачалаПерерыва != ""))
            {
                ВремяНачалаПерерыва = StartTimePereriv;
            }
            else
            {
                ВремяНачалаПерерыва = DateTime.Now;
            }
            if ((DateTime.TryParse(времяОкончанияПерерыва, out DateTime EndTimePereriv)) && (времяОкончанияПерерыва != ""))
            {
                ВремяОкончанияПерерыва = EndTimePereriv;
            }
            else
            {
                ВремяОкончанияПерерыва = DateTime.Now;
            }
            Смена = смена;
        }
    }
}
