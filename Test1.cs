class PrintNextTwentyLeapYears
{
    private static void Main()
    {
        var currentYear = DateTime.Now.Year;

        int leapYearCounter = 0;

        while (leapYearCounter < 20)
        {
            if (DateTime.IsLeapYear(currentYear))
            {
                Console.WriteLine(currentYear);
                leapYearCounter += 1;
            }
            currentYear += 1;
        }
    }
}
