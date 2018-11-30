using System;
using System.Diagnostics;
using IsItASemiPrimeNumber.Classes;

namespace IsItASemiPrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Stopwatch();
            s.Start();
            //create an instance of PrimeNumbers and SemiPrimeNumbers class respectively
            var primeNoClass = new PrimeNumbers();
            var semiPrimeNoClass = new SemiPrimeNumbers();

            //set the limit, in this case 100,000
            var limit = 100000;

            //get the list of prime numbers
            var primeNumbers = primeNoClass.GetPrimeNumbers(limit);
            //get the list of semi prime numbers
            var semiPrimeNumbers = semiPrimeNoClass.GetSemiPrimeNumbers(primeNumbers, limit);

            //a string to show all of the prime numbers
            var primeNumbersListString = "";
            foreach (var prime in primeNumbers)
            {
                //go through every prime number in the list and append it to the primeNumbersListString
                primeNumbersListString = primeNumbersListString + " " + prime;
            }
            Console.WriteLine("List of prime numbers : ");
            Console.WriteLine(primeNumbersListString.Trim());//display

            //a string to show all of the semi prime numbers
            var semiPrimeNumbersListString = "";

            foreach (var semiPrime in semiPrimeNumbers)
            {
                //go through every semi-prime number in the list and append it to the primeNumbersListString
                semiPrimeNumbersListString = semiPrimeNumbersListString + " " + semiPrime;
            }
            Console.WriteLine("\nList of semi prime numbers : ");
            Console.WriteLine(semiPrimeNumbersListString.Trim());// display 
            s.Stop();
            Console.WriteLine($"Ellapsed ms : {s.ElapsedMilliseconds}");
        }
    }
}
