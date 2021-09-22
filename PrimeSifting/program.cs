using System;
using System.Collections.Generic;
using PrimeSifting;

public class Program 
{
  public static void Main()
  {
    Console.WriteLine("----Welcome to Prime Sifting----");
    Console.WriteLine("Enter a number and I'll return prime numbers up to that number");
    int number = int.Parse(Console.ReadLine());
    Prime newPrime = new Prime();
    List<int> numList = newPrime.findNumbers(number);
    numList = newPrime.findPrime(numList);
    Console.WriteLine("LIST STARTS HERE:");
    foreach(int input in numList)
    {
      Console.WriteLine(input);
    }
    Main();
  }
}