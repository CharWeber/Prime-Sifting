using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PrimeSifting.Tests
{
  [TestClass]
  public class PrimeTests
  {
    [TestMethod]
    public void findPrime_CreatesInstanceOfPrime_Prime()
    {
      Prime newPrime = new Prime();
      Assert.AreEqual(typeof(Prime), newPrime.GetType());
    }
    
  }
}

// return list of all primes up to user input
// list of all numbers up to user input (skip #1)
// iterate through that list, removing any number with multiples of each number?
// whats left are prime numbers
// display that list

// tests list:

// #1 create a list of numbers up to user input
// #2 removes multiples of numbers incrementally
// #3 retunrs list of primes