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
            /*
            int i = 2;
            while (i <= (number - 1))
            {
                int number = (Utils.Isprime(i));
                if (Utils.Isprime(i))
                    System.Console.WriteLine(" es primo " + i);
                i++;
                   
                else
                    System.Console.WriteLine("no es primo " + i);
                    

            }*/
        }
        public static void ejercicio4()
        {
            int i = 0;
            while (i < 100)
            { 
                System.Console.WriteLine(i);
                  i++;
            }
            


        }
        public static void ejercicio5()
        {
            int i = 0;
            while (i < 100)
            {
                System.Console.WriteLine(i * 3);
                i++;
            }



        }
        public static void ejercicio6()
        {
            int i = 0;
            while (i < 100)
            {
                System.Console.WriteLine( (i * 3) + 1 );
                i++;
            }



        }
        public static void Ejercicio7()
        {
            int i = 0;
            while (i < 100)
            {
                System.Console.WriteLine( 5 - i);
                i++;
            }



        }
        
        // A ver la cosa de que esto ejercicios tratan de que los contadores vayan sumando desde
        //en uno, en dos, tres, etc, pero también por ejemplo si son o no negativos (ejercicios 7 y 8)
        
        
        public static void Ejercicio8()
        {
            int i = 0;
            while (i < 100)
            {
                if (Utils.IsEven(i))
                    System.Console.WriteLine(i);
                else 
                    System.Console.WriteLine(-i);
                i++;
            }



        }
        public static void ejercicio()
        {
            int a = 0;
            int b = 1;
            int i = 0;


            while (i <= 100)
            {
                int c = a + b;// en este parte el planteamiento es el dicho arriba 0+1=1
                a = b;      // aquí lo que hago es que el valor de b ahora sea el resultado de
                            // la suma de a+b siendo sustituido por 1 y almacenado en b.
                b = c;    // mientras que aquí repito lo mismo, hago que lo a ya no se ha
                          //  0 sino que el valor de a será 1, es decir, lo que valia el sigiente
                          // número delante de 0 que es 1.

                System.Console.WriteLine(c);
                i++;

            }
        }
<<<<<<< HEAD
        public static void Asterico(int count)
        {
            
            for (int i = 0 ; i < count; i++)
            {
                Console.Write( "*" );
                
            }
           
        }
    }
=======
>>>>>>> 1798c05bc6fb5ce9ca53cb68b358aa9f1932d776
}
