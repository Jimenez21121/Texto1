
using System.Globalization;

namespace TexT1
{
    class Utils
    {
        public static int GetMinValue(int a, int b)
        {
            if (a < b)
                return b;
            else
                return a;


        }
        public static int GetMaxValue(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }



        }
        // IsEven delvuelve True si el valor es par
        // y false en caso contrio
        public static bool IsEven(int value)
        {

            if ((value % 2) == 0)
                return true;
            else
                return false;





        }
        public static bool Isprime(int number)
        { 
            int i = 2;
            while (i <= (number - 1))
            {
                if ((number % i ) == 0) 
                 return false;
                i++;

            
            }
            return true;



        }
    }
}
