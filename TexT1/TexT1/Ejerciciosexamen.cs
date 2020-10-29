
using System;
using System.Windows.Markup;

namespace TexT1
{
    class Ejerciciosexamen
    { //Como no se nos pide imprimir pantalla siempre devolveremos el valor en pantallla con un return. 
        public static int FuncionSumaExamen( int value, int  value2)
        {
            int Resultado = value + value2 ;
            return Resultado;
        }
        //Hacer una función que reciba dos reales y devuelva la resta de esos dos reales.
        public static double FuncionExamenResta(double value, double value2)
        {
            double Resultado = value - value2 ;
            return Resultado ;



        }
        // hacer una funcion a la que se le pase dos enteros y devuelva el menor de ellos.
        public static int DevolverElMenor(int value, int value2)
        {
            if (value < value2)
                return value;
            else
                return value2;
                    

        }
        // Hacer una función que reciba como parametro dos enteros y devuelva si el primero es menor que el segundo.
        public static bool PimeroMayor(int value, int value2)
        { 
            if (value > value2)
                return true;
            else
                return false;
            // la respuesta perfecta seria return a < b; que hace lo del de arriba pero en solo una línea.
                 
        }
    }

}
