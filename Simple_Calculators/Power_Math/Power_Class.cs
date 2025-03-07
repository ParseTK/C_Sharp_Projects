using System;

namespace Power_Math
{
    class Power_Class
    {
        public static int GetPow(int baseNum, int powNum)
        {
            int result = 1; // Start with 1 because multiplying by 0 would make the result always 0
            for (int i = 0; i < powNum; i++) // Loop powNum times
            {
                result *= baseNum; // Multiply the result by baseNum in each iteration Result = result * baseNum
            }
            return result; // Return the final result
        }
    }
}
