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
        public int ЧасыНачалаПары { get; }
        public int МинутыНачалаПары { get; }
        public int ЧасыКонцаПары { get; }
        public int МинутыКонцаПары { get; }
        public int ЧасыНачалаПерерыва { get; }
        public int МинутыНачалаПерерыва { get; }
        public int ЧасыКонцаПерерыва { get; }
        public int МинутыКонцаПерерыва { get; }
        public Var8Смена Смена { get; }
        public Var7Пара(int часыНачалаПары, int минутыНачалаПары, int часыКонцаПары, int минутыКонцаПары,
            int часыНачалаПерерыва, int минутыНачалаПерерыва, int часыКонцаПерерыва, int минутыКонцаПерерыва, Var8Смена смена)
        {
            ЧасыНачалаПары = часыНачалаПары;
            МинутыНачалаПары = минутыНачалаПары;
            ЧасыКонцаПары = часыКонцаПары;
            МинутыКонцаПары = минутыКонцаПары;
            ЧасыНачалаПерерыва = часыНачалаПерерыва;
            МинутыНачалаПерерыва = минутыНачалаПерерыва;
            ЧасыКонцаПерерыва = часыКонцаПерерыва;
            МинутыКонцаПерерыва = минутыКонцаПерерыва;
            Смена = смена;
        }
    }
}
