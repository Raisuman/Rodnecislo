using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rodnécislo.Funkce
{
    internal class kontrolaRok
    {
        public static int uRok(int r)
        {
            if ((r >= 00) && (r <= 23))
            {
                r = 2000 + r;
                return r;
            }
            else if((r >= 24)&&(r <= 99))
            {
                r = 1900 + r;
                return r;
            }
            return 0;

        }
    }
}
