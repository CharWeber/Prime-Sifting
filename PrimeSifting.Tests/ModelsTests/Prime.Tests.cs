using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

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
    [TestMethod]
    public void findPrime_CreatesListOfNumbers_List()
    {
      // Arrange
      Prime newPrime = new Prime();

      //Act
      List<int> numList = new List<int>{2, 3, 4, 5};
      List<int> resultList = newPrime.findPrime(5);
      
      //Assert
      CollectionAssert.AreEqual(numList, resultList);
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