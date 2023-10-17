using System;
using System.Text;
namespace MethodToGenerateAndDisplayRandomNum
{ //Msimango KSI
    class Program
    {  // A C# console application that allow a user to enter a number.The system will then generate the random numbers and display them on the user
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to generate random numbers");  
            PrintNumbers();        
        }

        static void PrintNumbers()

        {                  
            int num = int.Parse(Console.ReadLine());
            Random random = new Random();
            Console.WriteLine("Your Random numbers are : ");

            for (int x=0; x<num; x++)
            {
               Console.WriteLine($"{random.Next(1,9)}");
            }
            Console.WriteLine();
        }

    }
}
