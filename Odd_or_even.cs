using System;
using System.Threading;
public class Checker
{
    //greeting method
    static void greeting()
    {
        Console.WriteLine("Odd or even number checker!!");
        Console.WriteLine("          By ze");
        Console.WriteLine("------------------------------ \n");
    } 
    public static void Main(string[] args)
    {
        greeting(); //calling the greeting method at the beginning
        double num; // delcaring num
        ConsoleKeyInfo key; //delcaring key
        do{ // beginning of do while loop

        try // beginning of try and catch statement
        {

        Console.Write("Enter number: "); // output/question
        num = Convert.ToDouble(Console.ReadLine()); //reads the input and converts it into double

        }

        catch // if you enter for example "t" it will do this
        {

         Console.WriteLine("Not a number"); // writes this
         Main(args); // recalls this method (basically restarting it)
         break; // breaking out of the catch method

        } // end of try and catch statement

        double ore = num%2; // ore = odd or even and it's equal num%2

    
        if (num > double.MaxValue) // if the input is higher than 1e+308 it prints this
        {
            Console.WriteLine("This is past the number limit (1.7976931348623157E+308) \n"); // output
            Main(args); // recalls function
        }

        if (ore == 1) // if ore is equal to 1 then it's an odd number (true or false type stuff)
        {
            Console.WriteLine("Odd number");
        }
        else //else print even number
        {
            Console.WriteLine("Even number");
        
        }
        int a = 0;
        for (int i = 1; i <= num; i++) {
            if (num % i == 0) {
               a++;
            }
         }
         if (a == 2) {
            Console.WriteLine("Prime Number", num);
         }

        Console.WriteLine("press e to exit or enter to contuine"); // outputs
        key = Console.ReadKey(); // waits for a key to be pressed
        Console.Clear(); // clears the console
        }while (key.Key != ConsoleKey.E); // end of while loop and this means if the key pressed is not equal to "E" then conttuine
    }
}

// the end :D