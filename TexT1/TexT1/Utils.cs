
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
    }
}
