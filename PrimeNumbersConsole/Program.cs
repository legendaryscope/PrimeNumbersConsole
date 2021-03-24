using System;
using System.Collections.Generic;

namespace PrimeNumbersConsole
{
  // To find all the prime numbers less than or equal to a given integer n by Eratosthenes' method:
  // Create a list of consecutive integers from 2 through n: (2, 3, 4, ..., n).
  // Initially, let p equal 2, the smallest prime number.
  // Enumerate the multiples of p by counting in increments of p from 2p to n,
  //      and mark them in the list (these will be 2p, 3p, 4p, ...; the p itself should not be marked).
  // Find the smallest number in the list greater than p that is not marked.If there was no such number,
  //      stop.Otherwise, let p now equal this new number(which is the next prime), and repeat from step 3.
  // When the algorithm terminates, the numbers remaining not marked in the list are all the primes below n.
  class Program
  {
    static void Main(string[] args)
    {
      var maxValue = 50;
      foreach (var prime in GeneratePrimes(maxValue))
      {
        Console.Write($"{prime} ");
      }
    }

    private static IEnumerable<int> GeneratePrimes(int maxValue)
    {
      var checkIfPrime = true;

      for (var calPrime = maxValue; calPrime >= 2; calPrime--)
      {
        for (int count = maxValue; count >= 2; count--)
        {

          if (calPrime != count && calPrime % count == 0)
          {
            checkIfPrime = false;
            break;
          }

        }

        if (checkIfPrime)
        {
          yield return calPrime;
        }

        checkIfPrime = true;
      }
    }
  }
}
