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


      /* Loops */

      /* for loop */
      int[] number = {
        10, 20, 30, 40, 50
      };

      for (int num = 0; num < number.Length(); num++)
      {
        Console.WriteLine(number[num]);
      }

      /* foreach */
      foreach(int myNumer in number)
      {
        Console.WriteLine(myNumber);
      }

      /* while loop */
      int num2 = 0;
      while (num2 < number.Length)
      {
        Console.WriteLine(number[num2]);
      }

      /* do while */
      var num3 = 0;
      do
      {
        Console.WriteLine(number[num3]);
        num++
      }
      while (num3 < number.Length);

      Console.ReadLine();


      /* Switch Case */
      int age = Convert.ToInt32(Console.ReadLine());

      switch(age)
      {
        case 16:
          Console.WriteLine("You may drive");
          break;
        case 18:
          Console.WriteLine("You may vote");
          break;
        case 21:
          Console.WriteLine("You may order a drink");
          break;
        case 100:
          Console.WriteLine("You may do anything");
          break;
        default:
          Console.WriteLine("Follow the law");
      }
      Console.ReadLine();


      /* Enum */
      enum Age
      {

      }
      Console.ReadLine();
  }
}
