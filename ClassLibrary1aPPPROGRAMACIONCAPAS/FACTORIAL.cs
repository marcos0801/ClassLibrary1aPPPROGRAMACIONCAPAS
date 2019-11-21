using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1aPPPROGRAMACIONCAPAS
{
    public static class FACTORIAL
    {
        /// <summary>
        /// calcula el factorial de un número
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public  static long Fact(int num)
        {
            long f = 1;
            if (num == 0 || num == 1)
                return f;

            for (int i = 1; i <= num; i++)
                f = f * i;

            return f;
        }
        /// <summary>
        /// calcula el cuadrado de un número
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static double  cuadrado(double num)
        {
            return (num * num);

        }

    }
}
