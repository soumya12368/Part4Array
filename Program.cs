using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part4Array
{
    internal class Program
    {
        static void Main(string[] args)
        {           
            int[] values = new int[5];// Create an array of integers
            Random randomizer = new Random();// Populate the array with random integer values
            for (int index = 0; index < values.Length; index++)
            {
                values[index] = randomizer.Next(1, 101); // integers between 1 and 100
            }           
            Console.WriteLine("Array Elements:");// Display the array elements
            foreach (int value in values)
            {
                Console.Write(value + " ");
            }           
            int total = 0;// Calculate and display the sum of the elements
            foreach (int value in values)
            {
                total += value;
            }
            Console.WriteLine("\nSum of the elements: " + total);           
            double avg = (double)total / values.Length;// Calculate and display the average of the elements
            Console.WriteLine("Average of the elements: " + avg);
        }
    }
}
