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
    }
  }
}
