// Successful solution

using System;
public class Kata
{
    public static int[] DataReverse(int[] data)
    {
        int[] bits = new int[data.Length];
        int startIndex = data.Length - 8;
        
        for (int i = 0; i < bits.Length; i += 8)
        {
            for (int j = 0; j < 8; j++)
            {
                bits[i + j] = data[startIndex + j];
            }
            startIndex -= 8;
        }

        return bits;
    }

}