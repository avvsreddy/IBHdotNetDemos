namespace SimpleMathClassLibrary
{
    public class SimpleMath
    {
        public static int FindMax(int fno, int sno) // SRP - BL
        {
            int max = 0;
            if (fno > sno)
            {
                max = fno;
            }
            else
            {
                max = sno;
            }
            return max;
        }
    }
}