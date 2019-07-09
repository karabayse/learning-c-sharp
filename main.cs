using System;

namespace BirthMonth
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("What is your name?");
      var name = Console.ReadLine();

      Console.WriteLine("What is your age?");
      var age = Console.ReadLine();

      Console.WriteLine("In what month were you born?");
      var month = Console.ReadLine();

      Console.WriteLine("Your name is: {0}", name);
      Console.WriteLine("Your age is: {0}", age);
      Console.WriteLine("Your birth month is: {0}", month);

      if (month == "January")
      {
        Console.WriteLine("You were born in the winter");
      }
      else if (month = "May")
      {
        Console.WriteLine("You were born in the spring");
      }
      else if (month = "October")
      {
        Console.WriteLine("You were born in the fall");
      }
    }
  }
}


using System;

namespace Authentication
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("What is the pass code?");
      var code = Console.ReadLine();

      if (code == "secret")
      {
        Console.WriteLine("Authenticated")
      }
      else if (code != "secret")
      {
        Console.WriteLine("Not Authenticated");
      }
    }
  }
}
