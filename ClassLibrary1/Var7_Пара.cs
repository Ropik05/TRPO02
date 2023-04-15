using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    //Ссылка: https://docs.google.com/document/d/1r4OjKXg5_5yj6ibHB778UEF5Z1nbUqGdXjpQXbTGWiQ/edit
    public class Var7Пара 
    {
        public TimeSpan ВремяНачала { get; }
        public TimeSpan ВремяОкончания { get; }
        public TimeSpan ВремяНачалаПерерыва { get; }
        public TimeSpan ВремяОкончанияПерерыва { get; }
        public Var8Смена Смена { get; }
        public Var7Пара(TimeSpan времяНачала, TimeSpan времяОкончания, TimeSpan времяНачалаПерерыва, TimeSpan времяОкончанияПерерыва, Var8Смена смена)
        {
            ВремяНачала = времяНачала;
            ВремяОкончания = времяОкончания;
            ВремяНачалаПерерыва = времяНачалаПерерыва;
            ВремяОкончанияПерерыва = времяОкончанияПерерыва;
            Смена = смена;
        }
    } 
}

