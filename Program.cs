using System;
/*
 Assignment #0
 
 Instructions:
 Arnold’s Clothing Emporium is a very busy place, and needs some software to help with orders of clothing.  
 For this mini-assignment, you will write code that will ask the user the follow:
 What colour of shirt they want to order
 Ask if they want a long sleeve shirt or a short sleeve shirt (press 1 for long sleeve, 2 for short sleeve)
 Ask how many shirts they want
 And print out a total of how much all the shirts will cost.
 You can use a fixed cost for shirts cost $7.99.

Course: PROG1783-18W-Sec1-IT Support Programming Fundamentals
Professor: Scanlan, H.
Number Student ID: 7679566
Name Student: Daniel Brazil
Date: Jan, 18, 2018
 
*/
namespace CalculatingCostShirts
{
  public class Program
  {

    /// <summary>
    /// Method to Draw Welcome Window
    /// </summary>
    public static void DrawWelcomeWindow()
    {
      //Print text at the start of the program to briefly explain the purpose of the program in your own words 
      //(a "welcome screen" for this shirt cost calculator)
      Console.WriteLine("================================================================================");
      Console.WriteLine("            Welcome to Calculating the Cost of Awesome Shirts!");
      Console.WriteLine("================================================================================");
      Console.WriteLine("This program calculate the total cost of shirts of long sleeve or a short sleeve");
      Console.WriteLine("================================================================================");
      Console.WriteLine("");
      Console.WriteLine("");
    }

    /// <summary>
    /// Method to Calule Total Cost and ask question to user
    /// </summary>
    public static void CalculeShirt()
    {
      //declaration of consts
      const double SHIRTCOST = 7.99;
      //declaration of variables for result of questions
      string sColorShirt, sKindOfShirt, sManyShirts = string.Empty;
      int iManyShirts; // this variable receive the number of shirts
      double dTotal; // this variable calculate the total price of shirts
      bool bValidate = false; // this variable is used to control questiob about quantity of shirts

      Console.Clear();
      DrawWelcomeWindow();

      //Prompt for and then receive the input from the user needed to write a program to solve the above
      Console.WriteLine("What colour of shirt you want to order?");
      sColorShirt = Console.ReadLine();
      //loop for control to user input some information
      while (sColorShirt == "")
      {
        Console.Clear();
        DrawWelcomeWindow();
        Console.WriteLine("Please input something. What colour of shirt you want to order?");
        Console.Beep(5000, 500);
        sColorShirt = Console.ReadLine();
      }
      Console.Clear();
      DrawWelcomeWindow();
      Console.WriteLine("What is the type of shirt? (Press 1 for long sleeve, 2 for short sleeve)");
      sKindOfShirt = Console.ReadLine();
      //loop for control to user input just 1 or 2
      while (sKindOfShirt != "1" && sKindOfShirt != "2")
      {
        Console.Clear();
        DrawWelcomeWindow();
        Console.WriteLine("Please input 1 for long sleeve OR 2 for short sleeve");
        Console.Beep(5000, 500);
        sKindOfShirt = Console.ReadLine();
      }
      Console.WriteLine("");
      // ask question until user input numbers
      while (!bValidate)
      {
        Console.Clear();
        DrawWelcomeWindow();
        Console.WriteLine("How many shirts you want to order? Please press just numbers.");
        sManyShirts = Console.ReadLine();
        if (int.TryParse(sManyShirts, out iManyShirts))
        {
          bValidate = true;
        }
        else Console.Beep(5000, 500);
      }

      iManyShirts = Convert.ToInt32(sManyShirts);
      //HERE is the calcule to cost of total of shirts
      dTotal = iManyShirts * SHIRTCOST;
      Console.Clear();
      DrawWelcomeWindow();
      //Print a summary report that shows what was bought including the type of shirt, colour of shirt, and total cost payable.
      Console.ForegroundColor = ConsoleColor.Blue;
      Console.WriteLine("                                Order Summary Report");
      Console.WriteLine("================================================================================");
      Console.WriteLine("");
      //validate if user input 1 or 2
      sKindOfShirt = (sKindOfShirt == "1") ? "Long sleeve" : "Short sleeve";
      Console.WriteLine("Type of shirt..................: {0}", sKindOfShirt);
      Console.WriteLine("Colour of shirt................: {0}", sColorShirt);
      Console.WriteLine("Quantity of shirt..............: {0}", sManyShirts);
      Console.WriteLine("The total value of the order is: $ {0}", dTotal.ToString("0.00"));
      Console.WriteLine("");
      Console.WriteLine("================================================================================");
      Console.ResetColor();
    }

    /// <summary>
    /// Main Method
    /// </summary>
    /// <param name="args"></param>
    public static void Main(string[] args)
    {
      string sYesNo = "Y";
      while (sYesNo.ToUpper() == "Y")
      {
        CalculeShirt();
        Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Would you like to order another shirt?");
        Console.WriteLine("Press Y (es) for new order OR ANY key to finish!");
        sYesNo = Console.ReadLine().ToUpper();
        Console.ResetColor();
      }
    }
  }
}
