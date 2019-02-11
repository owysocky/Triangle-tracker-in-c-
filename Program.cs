using System;

namespace TriangleTracker
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("WELCOME TO TRIANGLE TRACKER!");
      Console.WriteLine("Enter the length of first side: ");
      int sideOne = int.Parse(Console.ReadLine());
      Console.WriteLine("Enter the length of second side: ");
      int sideTwo = int.Parse(Console.ReadLine());
      Console.WriteLine("Enter the length of third side: ");
      int sideThree = int.Parse(Console.ReadLine());

      if(sideOne + sideTwo <= sideThree || sideOne + sideThree <= sideTwo || sideTwo + sideThree <= sideOne)
      {
        Console.WriteLine("This is not a triangle! Want to try again? ['Y' for yes, 'Enter' for no]");
        string finishedAnswer = Console.ReadLine();
          if (finishedAnswer == "Y" || finishedAnswer == "y")
          {
            Main();
          }
          else
          {
            Console.WriteLine("Thank you for your time!");
          }
      }
      else
      {
        if(sideOne==sideTwo && sideOne==sideThree){
          Console.WriteLine("This is EAQUILATERAL triangle! Want to check another triangle? ['Y' for yes, 'Enter' for no]");
          string finishedAnswer = Console.ReadLine();
            if (finishedAnswer == "Y" || finishedAnswer == "y")
            {
              Main();
            }
            else
            {
              Console.WriteLine("Thank you for your time!");
            }
        } else if (sideOne==sideTwo||sideOne==sideThree||sideTwo==sideThree){
          Console.WriteLine("This is ISOSCELES triangle! Want to check another triangle? ['Y' for yes, 'Enter' for no]");
          string finishedAnswer = Console.ReadLine();
            if (finishedAnswer == "Y" || finishedAnswer == "y")
            {
              Main();
            }
            else
            {
              Console.WriteLine("Thank you for your time!");
            }
        } else if(sideOne!=sideTwo && sideOne!=sideThree){
          Console.WriteLine("This is SCALENE triangle! Want to check another triangle? ['Y' for yes, 'Enter' for no]");
          string finishedAnswer = Console.ReadLine();
            if (finishedAnswer == "Y" || finishedAnswer == "y")
            {
              Main();
            }
            else
            {
              Console.WriteLine("Thank you for your time!");
            }
        }
      }

    }
  }
}
