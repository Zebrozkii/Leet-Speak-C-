using System;
using System.Collections.Generic;


namespace Leetspeak
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Write any sentence");
      string userInput = Console.ReadLine();
      Translate userTest = new Translate();
      Console.WriteLine(userTest.translateString(userInput));
    }
  }
}
