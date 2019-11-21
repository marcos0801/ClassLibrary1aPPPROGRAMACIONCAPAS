using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPruebaFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 5;
            double res = ClassLibrary1aPPPROGRAMACIONCAPAS.FACTORIAL.Fact(num);
            Console.WriteLine("El factorial es : {0} es : {1}",num,res);
            cambio(27.50);
            Console.ReadKey(); //pausa
        }

        static void cambio(double dolares)
        {
            int billete10 = (int)dolares / 10;
            Console.WriteLine("{0} billete(s) de 10 dolares",billete10);

            int billete5 = ((int)dolares % 10) / 5;
            Console.WriteLine("{0} billete(s) de 5 dolares", billete5);

            int billete1 = ((int)dolares % 100) / 10;
            Console.WriteLine("{0} billete(s) de 1 deolar", billete1);

            int moneda50 = ((int)dolares % 100) / 20;
            Console.WriteLine("{0} moneda(s)  de 50 centavos", moneda50);



        }


    }
}
