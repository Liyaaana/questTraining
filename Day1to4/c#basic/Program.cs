using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace c_basic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("enter your marks:");
            int marks = int.Parse(Console.ReadLine());
            char grade;
            if (marks > 90)
            {
                grade = 'A';

            }
            else if (marks > 80)
            {
                grade = 'B';

            }
            else if (marks > 70)
            {
                grade = 'C';

            }
            else if (marks > 60)
            {
                grade = 'D';

            }
            else 
            {
                grade = 'F';

            }
            Console.WriteLine($"grade is {grade}");
            */


            /*
            Console.WriteLine("enter your name:");
            var name = Console.ReadLine();
            for (int i = 0; i < name.Length; i++)
            {
                char c = name[i];
                if (c >= 'a' && c <= 'z')
                {
                    Console.Write((char)(c - 32));
                }
                else
                {
                    Console.Write(c);
                }
            }
            */


            /*
            Console.WriteLine("enter the string:");
            string name = Console.ReadLine();
            string newName = "";

            for (int i = 0; i < name.Length; i++)
            {
                if (name[i] == ' ')
                {
                    newName += '_';

                }
                else
                {
                    newName += name[i];
                }

            }
            Console.WriteLine(newName);
            */

            /*
            
            Console.WriteLine("Enter the pattern:");
            string pattern = Console.ReadLine();
            int sum = 0;
            for (int i = 0; i < pattern.Length; i++)
            {
                if (pattern[i] == '_')
                {
                    continue;
                }
                else
                {
                    sum = sum + int.Parse(pattern[i].ToString()); // int.Parse() method expects a string as input, so toString() is used to convert a character to a string.
                }
            }
            Console.WriteLine(sum);
            


            string input = "10_200_3";
            int result = 0;
            int number = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]))
                {
                    number *= 10;
                    number += int.Parse(input[i].ToString());
                }
                else if (input[i] == '_')
                {
                    result += number;
                    number = 0;
                }
            }

            result += number; // Add the last number to the result

            Console.WriteLine(result);

            /*

            Console.Write("Enter the input: ");
            string input = Console.ReadLine();

            int sum = 0;
            int number = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] >= '0' && input[i] <= '9')
                {
                    number = number * 10 + (input[i] - '0'); // Used to convert a digit character to its integer value.
                }
                else
                {
                    sum += number;
                    number = 0;
                }
            }

            sum += number;

            Console.WriteLine("Sum: " + sum);

            




            int length = 10; 
            Console.Write("Enter the height of the rectangle: ");
            int height = int.Parse(Console.ReadLine());

            for (int i = 0; i < length; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();

            for (int i = 1; i < height - 1; i++)
            {
                Console.Write("*");
                for (int j = 1; j < length - 1; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("*");
            }

            for (int i = 0; i < length; i++)
            {
                Console.Write("*");
            }
            


            


            int[] numbers = new int[5];
            int sum = 0;
            Console.WriteLine("Enter 5 numbers:");
            for (int i = 0; i < 5; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Number {i + 1}: ");
                Console.WriteLine(numbers[i]);
            }
            

            for (int i = 0; i < 5; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    sum += numbers[i];
                    
                }
            }
            Console.WriteLine("sum= " + sum);
            



            int[] numbers = new int[0];
            int index = 0;

            while (true)
            {
                if (numbers.Length < 2)
                {
                    Console.Write("Enter number: ");
                    Array.Resize(ref numbers, numbers.Length + 1);
                    numbers[index] = int.Parse(Console.ReadLine());
                    index++;
                    continue;
                }

                Console.Write($"Enter number ({numbers.Length + 1}) or q to exit: ");
                string input = Console.ReadLine();

                if (input == "q")
                {
                    break;
                }

                Array.Resize(ref numbers, numbers.Length + 1);
                numbers[index] = int.Parse(input);
                index++;

                int sum = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    sum += numbers[i];
                }

                Console.WriteLine(sum);
            }
            


            Console.Write("Enter the number of elements in the array: ");
            int n = int.Parse(Console.ReadLine());

            int[] originalArray = new int[n];

            Console.WriteLine("Enter the elements of the array:");
            for (int i = 0; i < n; i++)
            {
                originalArray[i] = int.Parse(Console.ReadLine());
            }

            int[] reversedArray = new int[n];

            for (int i = 0; i < n; i++)
            {
                reversedArray[i] = originalArray[n - 1 - i];
            }

            Console.WriteLine("Reversed array:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(reversedArray[i] + " ");
            }



            // 1,2,3,4 ==> 2,1,4,3
            // 1,2,3,4,5 ==> 2,1,3,5,4
            int[] numbers = { 1, 2, 3, 4, 5 };

            int[] reverse = new int[numbers.Length]; // 5, 4, 3, 2, 1

            bool isEven = numbers.Length % 2 == 0;

            if (!isEven)
            {
                int centerIndex = (numbers.Length - 1) / 2; // Corrected index calculation
                reverse[centerIndex] = numbers[centerIndex];

                for (int i = 0; i < centerIndex; i++)
                {
                    reverse[i] = numbers[centerIndex - 1 - i];
                }

                int count = 0;

                for (int i = centerIndex + 1; i < numbers.Length; i++)
                {
                    reverse[i] = numbers[numbers.Length - 1 - count];
                    count++;
                }
            }
            else
            {
                // Handle even-length arrays differently
                for (int i = 0; i < numbers.Length; i++)
                {
                    reverse[i] = numbers[numbers.Length - 1 - i];
                }
            }

            Console.WriteLine(string.Join("", reverse));

            */




          

          


        }

    }
}


