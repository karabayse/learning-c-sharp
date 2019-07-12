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

namespace BirthMonth
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("What is your name?");
      var name = TypeResponse();

      Console.WriteLine("What is your age?");
      var age = TypeResponse();

      Console.WriteLine("In which month were you born?");
      var month = TypeResponse();

      Console.WriteLine("Your name is: {0}", name);
      Console.WriteLine("Your age is: {0}", age);
      Console.WriteLine("Your birth month is: {0}", month);

      if (month == "March")
      {
        Console.WriteLine("You were born in the spring");
      }
      else if (month == "July")
      {
        Console.WriteLine("You were born in the summer");
      }
      else if (month == "December")
      {
        Console.WriteLine("You were born in the winter");
      }
    }
    static string TypeResponse() // return type is a string
  }
  var answer = Console.ReadLine();
  if (answer == "")
  {
    Console.WriteLine("Please type a response");
    return Console.ReadLine();
  }
  return answer;
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


using System;

namespace JobCandidate
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("How many years of experience do you have?");

      var years = int.Parse(Console.ReadLine()); // return an integer not a string

      switch(years);
      {
        case 0:
          Console.WriteLine("Inexperienced");
          break; // ends a specific case
        case 1:
            Console.WriteLine("Junior");
            break;
        case 2:
            Console.WriteLine("Intermediate");
            break;
        case 3:
            Console.WriteLine("Advanced");
            break;
        default:
            Console.WriteLine("Senior");
            break;
      }
    }
  }
}


using System;
using System.Collections.Generic;  // need this in order to use the 'new list' collection

namespace SchoolTracker
{
  class Program
  {
    static void Main(string[] args)
    {
      var students = new List<student>();

      var adding = true;

      while (adding)
      {
        var newStudent = new Student();

        Console.Write("Student Name: ");
        newStudent.Name = Console.Readline();

        Console.Write("Student Grade: ");
        newStudent.Grade = int.Parse(Console.Readline());

        Console.Write("Student Birthday: ");
        newStudent.Birthday = Console.Readline();

        Console.Write("Student Address: ");
        newStudent.Address = Console.Readline();

        Console.Write("Student Phone Number: ");
        newStudent.Phone = int.Parse(Console.Readline());

        students.Add(newStudent);

        Console.WriteLine("Add another?  Y/N");

        if (Console.ReadLine() != "Y")
          adding = false;
      }

      foreach (var student in students)
      {
        Console.WriteLine("Name: {0}, Grade{1}", student.Name, student.Grade);
      }
    }
  }

  class Student
  {
    static void public int Count;

    public string Name;
    public int Grade;
    public string Birthday;
    public string Address;
    private int phone; // 'private' provides a protection level *note lowercase

    public int phone
    {
      set { phone = value; }
    }

    public void setPhone{int number}
    {
      phone = number;
    }
  }
}
