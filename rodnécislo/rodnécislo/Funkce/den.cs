﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rodnécislo.Funkce
{
    internal class kontrolDen
    {
        public static int kontrolaDen(int d,int m,int r)
        {
            if ((m == 1) || (m == 3) || (m == 5) || (m == 7) || (m == 8) || (m == 10) || (m == 12))
            {
                if ((d >= 1) && (d <= 31))
                {
                    return d;
                }
                


            }else if ((m == 4) || (m == 6) || (m == 9) || (m == 11))
            {
                if ((d >= 1) && (d <= 30))
                {
                    return d;
                }
                
            }else if (m == 2)
            {
                if((d <= 1)&&(d >= 28))
                {
                    return d;
                }else if (((r % 400) == 0)&&((r % 100)==0))
                {
                    if ((d >= 1) && (d <= 29))
                    {
                        return d;
                    }
                }
            }
            return 0;
            
        }
    }
}
