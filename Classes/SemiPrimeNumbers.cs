using System.Collections.Generic;
using System.Linq;
using IsItASemiPrimeNumber.Interfaces;

namespace IsItASemiPrimeNumber.Classes
{
    public class SemiPrimeNumbers : ISemiPrimeNumbers
    {
        public List<int> GetSemiPrimeNumbers(List<int> primeNumbers, int limit)
        {
            //Semi prime numbers are products of two prime numbers. The two primes in the product may equal each other

            List<int> requiredSemiPrimes = new List<int>();

            //this will be used as a loop control to break out of the entire loop 
            var breakEntireLoop = false;

            //We've already got a list of prime numbers, we just need to find the squares of each of them and there multiples with
            //each other upto the limit
            for (var n = 0; n < primeNumbers.Count; n++)
            {
                //if the flag to break entire loop is set to true then break, this helps to optimise the code
                //it is only used for inner loop since breaking out of inner loop won't break out of the outer loop
                if (breakEntireLoop) break;

                //lets start with the first element in the list

                //since semi primes also includes squares of any prime numbers let's
                //get it's square first
                var squareNumber = primeNumbers[n] * primeNumbers[n];// multiplying by itself
                if (squareNumber == limit)
                {
                    //we only want anything upto and equal the limit, so if it's equal then we add it to the list 
                    //anything from this point is only going to be higher, so we can break the loop at this point, again helps with optimisation
                    requiredSemiPrimes.Add(squareNumber);
                    break;
                }
                else
                {
                    if (squareNumber < limit)
                    {
                        //if the sqaure number is also less than the limit then add it to the list
                        requiredSemiPrimes.Add(squareNumber);

                        //now let's look for other possibilities of semiprimes by creating another loop(an inner loop)
                        //for e.g : we have a list of prime numbers 
                        //    examplePrimeNumber = [2 , 3, 5, 7, 11, 13, 17, 19, 23 ........n]
                        // now we need something like 
                        //(2 * 3)
                        //(2 * 5) 
                        //(2 * 7) 
                        //(2 * 11) 
                        //(2 * 13 
                        //where 2 = n (the outer loop increment)
                        //and in (2 * 3)   3 = n + 1(which will be the inner loop)
                        //therefore the i starts from n + 1
                        for (var i = n + 1; i < primeNumbers.Count; i++)
                        {

                            var semiPrime = primeNumbers[n] * primeNumbers[i];
                            if (semiPrime < limit)
                            {
                                //if it's less than the limit add it to the list
                                requiredSemiPrimes.Add(semiPrime);
                            }
                            if (semiPrime == limit)
                            {
                                requiredSemiPrimes.Add(semiPrime);
                                //at this point the semi prime has reached it's limit so we set the flag to break entire loop to true and break out of this inner loop aswell
                                breakEntireLoop = true;//set to true
                                //break inner loop
                                break;
                            }

                        }

                    }
                }

            }

            return requiredSemiPrimes.OrderBy(n => n).ToList();
        }
    }
}
