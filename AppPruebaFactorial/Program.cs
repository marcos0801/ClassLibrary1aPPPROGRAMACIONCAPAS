﻿using System;
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
            Console.ReadKey(); //pausa
        }
    }
}
