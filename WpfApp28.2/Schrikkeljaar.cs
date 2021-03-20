using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp28._2
{
    class Schrikkeljaar
    {
        public static bool IsSchrikkeljaar(int jaar)
        {
            return (jaar % 4 == 0 && jaar % 100 != 0) || jaar % 400 == 0;
        }
    }
}
