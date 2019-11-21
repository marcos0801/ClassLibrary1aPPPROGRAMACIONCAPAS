using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1aPPPROGRAMACIONCAPAS
{
    public static class Ecuacion
    {
        public static double X1(double a, double b, double c, out string msg)
        {
            double X1=0;
          
            msg = "";
            if (a == 0)
            {
                msg = "Error , división por cero ..";
                return 0;
            }

            double d = (b * b) - (4 * a * c);
            if (d < 0)
            {
                msg = "Raices negativas . La ecuacion tiene solución imaginaria ...";
                return 0;
            }
           X1 = (-b + Math.Sqrt(d)) / (2 * a);
            return X1;


        }

        public static double getX1(double a, double b, double c)
        {
            throw new NotImplementedException();
        }
    }



}

    public static class Ecuacion
{
    public static double X2(double a, double b, double c, out string msg)
    {
        double X2= 0;
        msg = "";
        if (a == 0)
        {
            msg = "Error , división por cero ..";
            return 0;
        }

        double d = (b * b) - (4 * a * c);
        if (d < 0)
        {
            msg = "Raices negativas . La ecuacion tiene solución imaginaria ...";
            return 0;
        }
        X2 = (-b - Math.Sqrt(d)) / (2 * a);
        return X2;

    }

    public static double GetX1(double a, double b, double c)
    {
        double X1 = 0;
        if (a == 0)
        
            throw new Exception("Error , división por cero..");    
        
        double d = (b * b) - (4 * a * c);
        if (d < 0)
            throw new Exception("Raices negativas . La ecuacion tiene solución imaginaria ...");
        
        X1 = (-b + Math.Sqrt(d)) / (2 * a);
        return X1;
    }
}