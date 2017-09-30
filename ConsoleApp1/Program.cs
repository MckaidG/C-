using System;

static class Program
{

    static void Main(string[] args)
    {

        for (int i = 1; i <= 100; i++)
        {

            bool canBeMultipliedByFive = i.CanBeMultipliedBy(5);
            bool canBeMultipliedByThree = i.CanBeMultipliedBy(3);

            if (canBeMultipliedByFive && canBeMultipliedByThree)
            {

                Console.WriteLine("{0}: FizzBuzz", i);
            }
            else if (canBeMultipliedByThree)
            {
                
                Console.WriteLine("{0}: Fizz", i);

            }
            else if (canBeMultipliedByFive)
            {

                Console.WriteLine("{0}: Buzz", i);

            }
            else
            {

                Console.WriteLine(i);
            }
        }

        Console.ReadLine();
    }

    private static bool CanBeMultipliedBy(this int sourceNumber, int targetNumber)
    {

        return (sourceNumber % targetNumber) == 0;
    }
}