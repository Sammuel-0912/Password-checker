using System;

namespace PasswordChecker
{
  class Program
  {
    public static void Main(string[] args)
    {
      int minLength;
      string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ" ; 
      string lowercase = "abcdefghijklmnopqrstuvwxyz" ; 
      string digits = "0123456789"; 
      string speicalChars = "#?!,-'/`_*$";
      int score = 0 ; 
      Console.WriteLine("enter a password");
      string password = Console.ReadLine();
      // Perform checks and display results
      if ( (score) >= (minLength))
      {
        score ++ ; 
      }
      if (Tools.Contains(password, uppercase ))
      {
        score ++ ; 
      }
      if (Tools.Contains(password, lowercase ))
      {
        score ++ ; 
      }
      if (Tools.Contains(password, digits ))
      {
        score ++ ; 
      }
      if (Tools.Contains(password,speicalChars))
      {
        score ++ ; 
      }
      Console.WriteLine(password);
      Console.WriteLine(score);
      switch(score)
      {
        case 5:
        case 4:
          Console.WriteLine("This is an extremely strong password");
          break;
        case 3:
          Console.WriteLine("the password is strong);
          break;
        case 2:
          Console.WriteLine("the password is medium);
          break;
        case 1:
          Console.WriteLine("the password is weak);
          break;
        default:
          Console.WriteLine("the password doesn’t meet any of the standards");
          break ; 
      }
        Console.ReadLine();
      }
    }
  }
