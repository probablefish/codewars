
// Successful solution
public static class Kata
{
    public static int СenturyFromYear(int year)
    {
        if (year <= 100)
        {
            return 1;
        } 
        
        int decade = (year / 10) % 10;

        int century = ((year / 100) % 10000) + 1;
        
        if (decade == 0)
        {
            int lastDigit = year % 10;

            if (lastDigit == 0)
            {
                century--;
            }
        }
        return century;
    }
}