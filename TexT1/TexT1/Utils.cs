
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
    }
}
