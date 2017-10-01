using System;

static class Program
{

    static void Main(string[] args)
    {
        
        for (int i = 1; i <= 100; i++)
        {
            bool Even = i.CanBeMultipliedBy(2);

            if (Even)
            {
                Console.WriteLine(i * i);
            }
            else
            {
                Console.WriteLine("{0}", i);
            }
        }

        Console.ReadLine();
    }

    private static bool CanBeMultipliedBy(this int sourceNumber, int targetNumber)
    {

        return (sourceNumber % targetNumber) == 0;
    }
}