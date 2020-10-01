using System;

namespace TexT1
{
    class Geometry
    {
        public static double GetVectorLength(double x, double y)
        {
            double aux, aux2, a ;
            aux = x * x + y * y ;
            aux2 = System.Math.Sqrt(aux) ;
            a = aux2 ;
                return a;

        }
        public static double GetVectorLength3D(double x, double y,double z)
        {
            double aux, aux2, a ;
            aux = x * x + y * y + z * z ;
            aux2 = System.Math.Sqrt(aux) ;
            a = aux2 ; 

                return a ;
        
        }
    }
}
