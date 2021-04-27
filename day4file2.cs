

using System.IO;
using System;

class Calculator
{
    public void InputX()
    {
        Console.WriteLine("enter the value of x");
        Console.WriteLine("enter the value of y");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("x= "+x);
        int y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("y= "+y);
        Console.WriteLine("x+y= :"+(x+y));
    }
    public static void Main()
    {
      Calculator obj = new Calculator();
      int exitkey = 1;
      while(exitkey>0)
      {
          Console.WriteLine("You want to Exit ? Y/N");
          string choice = Console.ReadLine();
          if (choice.ToLower() == "n")
          {
              obj.InputX();
              choice = Console.ReadLine();
          }
          else
          {
              break;
          }
      }
    }
}