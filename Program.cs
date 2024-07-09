using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Y9_DEC_TO_BIN_SKELETON
{
    internal class Program

    {
        static void Main(string[] args)
        {
            //STARTER: Practice using breakpoints and the watch window (F8 to single-step, F11 to start in single step mode)
            int myInt = 0; //just for testing single stepping
            string myString = "12"; //watch me being cast from string to int
            int myStringAsInt = Convert.ToInt32(myString); //watch me cast from string to int

            Console.WriteLine("Enter number");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(numberConversion(num, 2));
            if (num <= 0)
            {
                Console.WriteLine("Number must be above 0");
            }
   
            if (num >= 257)
            {
                Console.WriteLine("Number must be below 257");
            }
            
            

        }
        //MAIN:  NUMBER CONVERSION PROGRAM


        //static void means the function will not return a value so it does not need a data type 
        //...this function DOES return a value so the method must have a data type


        static string numberConversion(int num, int numberbase)
        {
           string result = ("");
            int count = 0;
            numberbase = 2;
            int[] myArray = new int[32];
            while (num > 0)
            {
                myArray[count] = num % numberbase;
                num = num / numberbase;
                count = count + 1;
            }
            for (int i = count - 1 ; i >= 0; i--)
            {
                Console.Write(myArray[i]);
            }

            Console.WriteLine("Enter a number to be converted into hexadecimal");
            string hexanum = Console.ReadLine();

            return result; //REMOVE THE RED LINE!

          
                    } 
    }
}
