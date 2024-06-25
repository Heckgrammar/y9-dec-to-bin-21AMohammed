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

            Console.WriteLine("Enter a string");
            string string1 = Console.ReadLine();
            Console.WriteLine("Enter another string");
            string string2 = Console.ReadLine();
            Console.WriteLine(string1 + string2);
        }
        //MAIN:  NUMBER CONVERSION PROGRAM

        //CODE GOES HERE


        //static void means the function will not return a value so it does not need a data type 
        //...this function DOES return a value so the method must have a data type
        static string numberConversion(int number, int numberbase)
        {
           string result = ("0");
            Console.WriteLine("Enter the Denary number that you want converted to Binary");
            number = (Convert.ToInt32(Console.ReadLine()));
            numberbase = (2);

            while (number / numberbase > 0)
            {
                result = ();
            }
           

            return result; //REMOVE THE RED LINE!
        }
    }
}
