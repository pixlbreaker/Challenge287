using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge287 {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("The Last digit is: " + largest_digit(4561).Last());
            descending_digits(2341).ForEach(Console.Write);
            descending_digits(1769).ForEach(Console.Write);
            Console.WriteLine(kaprekar(6589));
            Console.Read();
        }

        // Returns the Largest Digit from a number
        public static List<int> largest_digit(int num) {

            // List of int
            List<int> listint = new List<int>();

            int divisor = 1000;
            for (int i = 0; i < 4; i++) {
                int temp = num / divisor;
                num = num - (temp * divisor);
                listint.Add(temp);
                divisor = divisor / 10;
            }

            listint.Sort();
            return listint;
        }

        // Returns a Descending Order of Digits
        public static List<int> descending_digits(int num) {

            // List of int
            List<int> listint = new List<int>();

            int divisor = 1000;
            for (int i = 0; i < 4; i++) {
                int temp = num / divisor;
                num = num - (temp * divisor);
                listint.Add(temp);
                divisor = divisor / 10;
            }

            listint.Sort();
            listint.Reverse();
            return listint;
            
        }

        // The kaprekar
        public static int kaprekar(int num) {
            int iterations;
            List<int> reverseList = descending_digits(num);
            List<int> originalList = largest_digit(num);

            int num1 = 0;
            int count = 0;
            for (int i = 4; i > 0; i--) {
                num1 = originalList[count] * Convert.ToInt32(Math.Pow(10, i));
            }

            int num2 = 0;
            int count2 = 0;
            for (int i = 4; i > 0; i--) {
                num2 = reverseList[count2] * Convert.ToInt32(Math.Pow(10, i));
            }

            iterations = 0;
            int diff;
            do {
                diff = num2 - num1;
                iterations++;
            } while (diff != 6174);
                        
            return iterations;
        }
    }
}
