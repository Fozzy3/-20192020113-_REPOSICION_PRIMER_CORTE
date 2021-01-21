/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD
{
   class MCD
    {
        public  Tres_numeros(double numero1, double numero2, double numero3)
        {
            double a = 2;
            double mcd = 1;

            while(a<= numero1 && a<=numero2 && a<= numero3)
            {
                while(numero1%a==0 && numero2%a==0 && numero3 % a == 0)
                {
                    mcd = mcd * a;
                    numero1 = numero1 / a;
                    numero2 = numero2 / a;
                    numero3 = numero3 / a;
                }
                a = a + 1;
            }

            return mcd;
        }

    }
}
*/