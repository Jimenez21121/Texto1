using System;
using System.Collections.Generic;
using System.Text;

namespace TexT1
{
    class Ejercicios
    {
        //ejercicio: Hacer una función que muestre los números del 0 al 9.
        // y que lo imprima por pantalla. M.V.C = MODEL VISTA CONTROLADOR
        // Contador = contador + 1; o contador +=1; o contador++; hacen la misma función de sumar los tres en un contador
        // Haz una función que imprima los número pares que hay desde 0 hasta n.
        // los contadora
      public static void ejercicio2(int n)
      {
            int i;
            i = 0;

            while(i < n )
            {
                if (Utils.IsEven(i))
                    System.Console.WriteLine(i);
                i++;




            }





      }

      public static void ejercicio1()
      {
            int contador;
            contador = 0;
            
            while( contador < 100)
            {
                System.Console.WriteLine(contador);
                contador++;
           
            }





      }
        public static void ejercicio3(int number)
        {
            int i = 2;
            while (i <= (number - 1) )
            {
                if (Utils.Isprime(i))
                    System.Console.WriteLine(i);
                i++;

            }


        }

    }
}
