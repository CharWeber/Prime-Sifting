using System;
using System.Collections.Generic;

namespace PrimeSifting
{
  public class Prime
  {
    public List<int> findNumbers(int num)
    {
      List<int> numList = new List<int> {};
      for (int i = 2; i <= num ; i++)
      {
        numList.Add(i);
      }
      return numList;
    }
    public List<int> findPrime(List<int> numList)
    {
      for(int i =0; i <= numList.Count; i++)
      {
        for(int j = i + 1; j < numList.Count; j++)
        {
          if(numList[j] % numList[i] == 0)
          {
            numList.RemoveAt(j);
          }
        }
      }
      return numList;
    }
  }
}
// returns all the primes less than the user input