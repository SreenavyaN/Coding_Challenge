/****************************************************/
/* Author : Sreenavya N
 * Date : Feb 21, 2020
 * This project is a part of Call-Em-All coding challenge
 /**************************************************/ 

// import needed packages
using System;
using System.Text;
using System.Text.RegularExpressions;

namespace CallEmAll_Test
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a string to compute the maximum distance between charecters of the string");
            var input1 = Console.ReadLine();
            if (Regex.IsMatch(input1, @"^[a-zA-Z]+$") && input1.Length > 0)
            {
                char[] given = input1.ToCharArray();
                int diff = MaxDistance(given);
                Console.WriteLine("Maximum possible distance for the given input is: " + diff);
            }
            else
                Console.WriteLine("Please enter alphabets (A-Z or a-z)");
        }
        // Method MaxDistance(char[]) takes a charecter array as input and returns an integer with maximum possible distance
        public static int MaxDistance(char[] given)
        {
            String str = new String(given); //Convert charecter srray to a string
            int j = 0, diff = 0, res = -1;
            if (Regex.IsMatch(str, @"^[a-zA-Z]+$") && str.Length > 1) // Validating the alphabetic input AND the input size for more that one charecter
            {
                byte[] ascii_values = Encoding.ASCII.GetBytes(given); // Constructing an array of ASCII values for the given charecters
                for (int i = 0; i < ascii_values.Length - 1; i++) //Spans the whole array
                {
                    for (j = i + 1; j < ascii_values.Length; j++) // Spans the array from the next element of i
                    {
                        if (ascii_values[i] < ascii_values[j]) //checking the given condition if a[i] occurs before a[j] 
                        {
                            res = (ascii_values[j] - ascii_values[i]) - 1; //Computing the difference
                            if (res < diff) //Checking if the current difference is less than existing and if yes, then assign the maximum difference value
                                res = diff;
                        }
                        diff = res;  // else retain the maximum distance value
                    }
                }
            }
            return res; //return the maximum difference obtained
        }
    }
}