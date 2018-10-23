// Successful solution

public class Kata
{
    public static long FindNextSquare(long num)
    {
        decimal sqrt = Convert.ToDecimal(Math.Sqrt(num));
        
        if (sqrt % 1 == 0)
        {
        long floor = (long) Math.Floor(sqrt);
        long next = Convert.ToInt32(floor + 1);
    
        return next * next;
        }
        return -1;
    }
}