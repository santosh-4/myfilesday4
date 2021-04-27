using System;
class sk 
{
  static void Main()
  {
    int x = 1;
    int y;
    try
    {
       y = x / 0; 
       Console.WriteLine(y);
    }
    catch(DivideByZeroException ex)
    {
        Console.WriteLine(ex.Message);
        Console.WriteLine(ex.StackTrace);
        Console.WriteLine("Some error have occured");
    }
    finally
    {
        Console.WriteLine("Iam in finally block");
    }
  }
}
