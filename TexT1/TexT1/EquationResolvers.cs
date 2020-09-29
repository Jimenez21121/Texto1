using System;
using System.Collections.Generic;
using System.Text;

namespace TexT1
{
    class EquationResolvers
    {
        static public double FirstEquation(double a, double b)
        {
            double aux, x;
            aux = b * -1;
            x = (aux) / a;

            return x;
        }
        static public double SecondEquation(double a, double b, double c)
        {
            double aux, aux2, x;
            aux = b * b - 4 * a * c;
            aux2 = System.Math.Sqrt(aux);
            x = -(b) + (aux2) / 2 * a;

            return x;

        }
    }
}
