// Successful solution
using System;

public class Kata
{
    public static long FindNextSquare(long num)
    {
        decimal sqrt = Convert.ToDecimal(Math.Sqrt(num));
        
        if (sqrt % 1 == 0)
        {
        long floor = (long) Math.Floor(sqrt);
        long next = floor + 1;
    
        return next * next;
        }
        return -1;
    }
}