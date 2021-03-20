using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp28._2
{
    class Rijksregisternummer
    {

        public static bool Isvalid(string rrnr)
        {
            try
            {
                if (rrnr == null) return false;
                if (rrnr.Length != 11) return false;
                string leftPartS = rrnr.Substring(0, 9);
                string rightPartS = rrnr.Substring(9);

                int leftPartI = int.Parse(leftPartS);
                int rightPartI = int.Parse(rightPartS);

                // Special check for children of 21st century
                int year = DateTime.Today.Year - 2000;
                if (leftPartI < year * 10000000)
                {
                    leftPartI += 2000000000;
                }

                int mod = leftPartI % 97;
                int compareTo = 97 - mod;
                return compareTo == rightPartI;
            }
            catch (ApplicationException)
            {
                return false;
            }

        }
    }
}
