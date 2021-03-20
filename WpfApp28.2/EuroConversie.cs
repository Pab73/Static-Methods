using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp28._2
{
    class EuroConversie
    {
        private static decimal _koers = 40.3399m;

        public static decimal Koers
        {
            get => _koers;
            set => _koers = value;
        }
        public static decimal ToBef(decimal amount)
        {
            return (amount * Koers);
        }
        public static decimal ToEuro(decimal amount)
        {
            return amount / Koers;
        }
        public EuroConversie()
        {
            Koers = _koers;
        }


    }
}
