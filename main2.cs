using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp
{
  class Program
  {
    static void Main(string[] args)
    {
      /*
        Console.Write()
        Console.WriteLine()
        Console.ReadLine()

        WriteLine indicates a new line
        \n achieves the same thing:  Console.Write("Hello World\n")
      */
      Console.WriteLine("Hello World");
      Console.Write("Hello Programmer");
      Console.Read();

      string hello = "Hello World";
      string number = "10";
      Console.WriteLine(hello);
      Console.WriteLine(number);
      Console.ReadLine();


      /* Data Types */
      int number = 10;
      double number2 = 36.80;
      float number3 = 50.36;
      char cr = 'A';
      Console.WriteLine(number);
      Console.WriteLine(number2);
      Console.WriteLine(cr);
      Console.ReadLine();


      /* Mathematical Operations */
      int number4 = 10;
      var number5 = 10;
      Console.WriteLine(10 + 10 * 20 / 2);
      Console.WriteLine(number4 + number5);
      Console.ReadLine();


      /* Arrays */
      string[] statement = {
        "Hello, ", // 0
        "Programmers", // 1
        "We are", // 2
        "learning", // 3
        "C# Programming" // 4
      };
      Console.WriteLine(statement[4]);
      Console.ReadLine();

      string[] statement2 = new string[];
      statement[0] = "Hello";
      statement[1] = "World";

      Console.WriteLine(statement[0] + statement[1]);
      Console.ReadLine();


      /* Conditional Statements */
      Console.WriteLine("Enter your age below");
      int age = Convert.toInt32(Console.Readline());

      if (age < 18)
      {
        Console.WriteLine("You may not vote");
      }
      else if (age < 16)
      {
        Console.WriteLine("You may not drive");
      }
      else
      {
        Console.WriteLine("You are good to go");
      }

      Console.ReadLine();
  }
}
