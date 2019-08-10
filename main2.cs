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
    }
  }
}
