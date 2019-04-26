using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//this is my first c# program!!! 
//finding the max between three numbers. 

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
   
            Console.WriteLine("Please enter three numbers to find the max. Press enter after each number:");
            int num1, num2, num3; 
            while (!Int32.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("Invalid. Please enter a digit"); 
            }
            while (!Int32.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("Invalid. Please enter a digit");
            }
            while (!Int32.TryParse(Console.ReadLine(), out num3))
            {
                Console.WriteLine("Invalid. Please enter a digit");
            }
            Console.WriteLine("The max between " + num1 + ", " + num2 + ", and " + num3 + " is: " + GetMax(num1, num2, num3));
       
            Console.ReadLine(); 
        }

        static int GetMax(int num1, int num2, int num3)
        {
            int temp = 0;
            if(num1 >= num2)
            {
                temp = num1;
            }
            else
            {
                temp = num2; 
            }

            if (temp <= num3)
            {
                temp = num3; 
            }
       
            
            return temp; 
        }
    }
}
