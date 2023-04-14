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
        public Var7Пара(string времяНачала, string времяОкончания, string времяНачалаПерерыва, string времяОкончанияПерерыва, Var8Смена смена)
        {
            if ((времяНачала != "") && (TimeSpan.TryParse(времяНачала, out TimeSpan StartTimePara)))
            {
                ВремяНачала = StartTimePara;
            }
            else
            {
                ВремяНачала = DateTime.Now.TimeOfDay;
            }
            if ((времяОкончания != "") && (TimeSpan.TryParse(времяОкончания, out TimeSpan EndTimePara)))
            {
                ВремяОкончания = EndTimePara;
            }
            else
            {
                ВремяОкончания = DateTime.Now.TimeOfDay;
            }
            if ((времяНачалаПерерыва != "") && (TimeSpan.TryParse(времяНачалаПерерыва, out TimeSpan StartTimePereriv)))
            {
                ВремяНачалаПерерыва = StartTimePereriv;
            }
            else
            {
                ВремяНачалаПерерыва = DateTime.Now.TimeOfDay;
            }
            if ((времяОкончанияПерерыва != "") && (TimeSpan.TryParse(времяОкончанияПерерыва, out TimeSpan EndTimePereriv)))
            {
                ВремяОкончанияПерерыва = EndTimePereriv;
            }
            else
            {
                ВремяОкончанияПерерыва = DateTime.Now.TimeOfDay;
            }
            Смена = смена;
        }
    } 
}

