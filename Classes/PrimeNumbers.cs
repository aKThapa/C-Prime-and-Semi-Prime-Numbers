using System.Collections.Generic;
using System.Linq;
using IsItASemiPrimeNumber.Interfaces;

namespace IsItASemiPrimeNumber.Classes
{
    public class PrimeNumbers : IPrimeNumbers
    {
        public List<int> GetPrimeNumbers(int limit)
        {
            List<int> primeNumbers = new List<int>();
            //starting the loop from 2 insures that any illegal values like limit of 1 is accounted for even if it's not accounted for in the main program
            //it just means that the loop will never run and the list is empty
            for (var n = 2; n <= limit; n++)
            {
                if (IsPrimeNumber(n))
                {
                    primeNumbers.Add(n);
                }
            }
            return primeNumbers.OrderBy(n => n).ToList();
        }

        public bool IsPrimeNumber(int number)
        {
            bool isPrime = true;

            //2 is the first prime number
            if (number == 2)
            {
                return isPrime;
            }

            //prime numbers are any number that are only divisible by itself or 1
            //for e.g to determine if 7 is a prime no or not we need to find out if it's infact divisible by any number between 2 and 6(number - 1) 
            //so that's why the loop starts at 2 and goes all the way upto (number - 1)
            for (var c = 2; c <= number - 1; c++)
            {
                //if the remainder is 0 we know that it's not a prime no so we set the flag to false and break out of the loop(this should speed up the calculation)
                if (number % c == 0)
                {
                    isPrime = false;
                    break;
                }

            }
            return isPrime;
        }
    }
}
