using System;
using System.Collections.Generic;

namespace Assignment04
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Q1.Write a program that allows the user to insert an integer then print all numbers between 1 to that number.
            Console.Write("Enter an integer: ");
            int n1 = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n1; i++)
            {
                Console.Write(i + (i < n1 ? ", " : "\n"));
            }
            #endregion

            #region Q2.Write a program that allows the user to insert an integer then print a multiplication table up to 12.
            Console.Write("Enter an integer for multiplication table: ");
            int n2 = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 12; i++)
            {
                Console.Write((n2 * i) + (i < 12 ? " " : "\n"));
            }
            #endregion

            #region Q3.Write a program that allows the user to insert a number then print all even numbers between 1 to this number.
            Console.Write("Enter an integer: ");
            int n3 = int.Parse(Console.ReadLine());
            for (int i = 2; i <= n3; i += 2)
            {
                Console.Write(i + (i + 2 <= n3 ? " " : "\n"));
            }
            #endregion

            #region Q4.Write a program that takes two integers then prints the power.
            Console.Write("Enter base: ");
            int baseNum = int.Parse(Console.ReadLine());
            Console.Write("Enter exponent: ");
            int exponent = int.Parse(Console.ReadLine());
            Console.WriteLine("Power: " + Math.Pow(baseNum, exponent));
            #endregion

            #region Q5.Write a program to enter marks of five subjects and calculate total, average, and percentage.
            int[] marks = new int[5];
            Console.WriteLine("Enter marks of 5 subjects: ");
            for (int i = 0; i < 5; i++)
            {
                marks[i] = int.Parse(Console.ReadLine());
            }
            int total = 0;
            foreach (int mark in marks) total += mark;
            double average = total / 5.0;
            double percentage = (total / 500.0) * 100;
            Console.WriteLine($"Total: {total}, Average: {average}, Percentage: {percentage}%");
            #endregion

            #region Q6.Write a program to allow the user to enter a string and print the REVERSE of it.
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();
            char[] reverseChars = input.ToCharArray();
            Array.Reverse(reverseChars);
            Console.WriteLine("Reversed string: " + new string(reverseChars));
            #endregion

            #region Q7.Write a program to allow the user to enter an integer and print the REVERSED of it.
            Console.Write("Enter an integer: ");
            int num = int.Parse(Console.ReadLine());
            int reverseNum = 0;
            while (num > 0)
            {
                reverseNum = reverseNum * 10 + (num % 10);
                num /= 10;
            }
            Console.WriteLine("Reversed number: " + reverseNum);
            #endregion

            #region Q8.Write a program in C# Sharp to find prime numbers within a range of numbers.
            Console.Write("Enter starting range: ");
            int start = int.Parse(Console.ReadLine());
            Console.Write("Enter ending range: ");
            int end = int.Parse(Console.ReadLine());
            Console.WriteLine("Prime numbers:");
            for (int i = start; i <= end; i++)
            {
                if (IsPrime(i)) Console.Write(i + " ");
            }
            Console.WriteLine();
            static bool IsPrime(int num)
            {
                if (num < 2) return false;
                for (int j = 2; j <= Math.Sqrt(num); j++)
                {
                    if (num % j == 0) return false;
                }
                return true;
            }
            #endregion

            #region Q9.Write a program in C# Sharp to convert a decimal number into binary without using an array.
            Console.Write("Enter a decimal number: ");
            int decimalNumber = int.Parse(Console.ReadLine());
            string binary = "";
            while (decimalNumber > 0)
            {
                binary = (decimalNumber % 2) + binary;
                decimalNumber /= 2;
            }
            Console.WriteLine("Binary: " + binary);
            #endregion

            #region Q10.Create a program that asks the user to input three points (x1, y1), (x2, y2), and (x3, y3), and determines whether these points lie on a single straight line.
            Console.Write("Enter points (x1 y1 x2 y2 x3 y3): ");
            string[] points = Console.ReadLine().Split(' ');
            int x1 = int.Parse(points[0]);
            int y1 = int.Parse(points[1]);
            int x2 = int.Parse(points[2]);
            int y2 = int.Parse(points[3]);
            int x3 = int.Parse(points[4]);
            int y3 = int.Parse(points[5]);

            if ((y2 - y1) * (x3 - x2) == (y3 - y2) * (x2 - x1))
            {
                Console.WriteLine("Points lie on a straight line.");
            }
            else
            {
                Console.WriteLine("Points do not lie on a straight line.");
            }
            #endregion

            #region Q11.Write a program that prints an identity matrix of size n*n.
            Console.Write("Enter the size of the identity matrix: ");
            int size = int.Parse(Console.ReadLine());
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(i == j ? "1 " : "0 ");
                }
                Console.WriteLine();
            }
            #endregion

            #region Q12.Write a program in C# Sharp to find the sum of all elements of the array.
            Console.Write("Enter the size of the array: ");
            int arrSize = int.Parse(Console.ReadLine());
            int[] arr = new int[arrSize];
            Console.WriteLine("Enter the elements of the array:");
            int sum = 0;
            for (int i = 0; i < arrSize; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                sum += arr[i];
            }
            Console.WriteLine("Sum of elements: " + sum);
            #endregion

            #region Q13.Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.
            Console.Write("Enter the size of the arrays: ");
            int mergeSize = int.Parse(Console.ReadLine());
            int[] arr1 = new int[mergeSize];
            int[] arr2 = new int[mergeSize];
            Console.WriteLine("Enter elements of the first array:");
            for (int i = 0; i < mergeSize; i++)
                arr1[i] = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter elements of the second array:");
            for (int i = 0; i < mergeSize; i++)
                arr2[i] = int.Parse(Console.ReadLine());
            int[] mergedArray = new int[mergeSize * 2];
            arr1.CopyTo(mergedArray, 0);
            arr2.CopyTo(mergedArray, mergeSize);
            Array.Sort(mergedArray);
            Console.WriteLine("Merged array: " + string.Join(" ", mergedArray));
            #endregion

            #region Q14.Write a program in C# Sharp to count the frequency of each element of an array.
            Console.Write("Enter the size of the array: ");
            int freqSize = int.Parse(Console.ReadLine());
            int[] freqArray = new int[freqSize];
            Console.WriteLine("Enter the elements of the array:");
            for (int i = 0; i < freqSize; i++)
                freqArray[i] = int.Parse(Console.ReadLine());
            Dictionary<int, int> frequency = new Dictionary<int, int>();
            foreach (int value in freqArray)
            {
                if (frequency.ContainsKey(value))
                    frequency[value]++;
                else
                    frequency[value] = 1;
            }
            foreach (var kvp in frequency)
            {
                Console.WriteLine($"Element {kvp.Key} occurs {kvp.Value} times.");
            }
            #endregion

            #region Q15.Write a program in C# Sharp to find the maximum and minimum element in an array.
            Console.Write("Enter the size of the array: ");
            int maxMinSize = int.Parse(Console.ReadLine());
            int[] maxMinArray = new int[maxMinSize];
            Console.WriteLine("Enter the elements of the array:");
            for (int i = 0; i < maxMinSize; i++)
                maxMinArray[i] = int.Parse(Console.ReadLine());
            int maxElement = int.MinValue;
            int minElement = int.MaxValue;
            foreach (int value in maxMinArray)
            {
                if (value > maxElement) maxElement = value;
                if (value < minElement) minElement = value;
            }
            Console.WriteLine($"Maximum element: {maxElement}, Minimum element: {minElement}");
            #endregion

            #region Q16.Write a program in C# Sharp to find the second largest element in an array.
            Console.Write("Enter the size of the array: ");
            int secondLargestSize = int.Parse(Console.ReadLine());
            int[] secondLargestArray = new int[secondLargestSize];
            Console.WriteLine("Enter the elements of the array:");
            for (int i = 0; i < secondLargestSize; i++)
                secondLargestArray[i] = int.Parse(Console.ReadLine());
            Array.Sort(secondLargestArray);
            Console.WriteLine("Second largest element: " + secondLargestArray[secondLargestSize - 2]);
            #endregion

            #region Q17.Write a program to find the longest distance between two equal elements in an array.
            Console.Write("Enter the size of the array: ");
            int distSize = int.Parse(Console.ReadLine());
            int[] distArray = new int[distSize];
            Console.WriteLine("Enter the elements of the array:");
            for (int i = 0; i < distSize; i++)
                distArray[i] = int.Parse(Console.ReadLine());
            Dictionary<int, int> firstIndices = new Dictionary<int, int>();
            int longestDist = 0;
            for (int i = 0; i < distSize; i++)
            {
                if (!firstIndices.ContainsKey(distArray[i]))
                    firstIndices[distArray[i]] = i;
                else
                    longestDist = Math.Max(longestDist, i - firstIndices[distArray[i]]);
            }
            Console.WriteLine("Longest distance: " + longestDist);
            #endregion

            #region Q18.Given a list of space-separated words, reverse the order of the words.
            Console.Write("Enter a sentence: ");
            string sentence = Console.ReadLine();
            string[] words = sentence.Split(' ');
            Array.Reverse(words);
            Console.WriteLine("Reversed sentence: " + string.Join(" ", words));
            #endregion

            #region Q19.Write a program to create two multidimensional arrays of the same size.
            Console.Write("Enter rows and columns of the arrays: ");
            string[] dimensions = Console.ReadLine().Split(' ');
            int rows = int.Parse(dimensions[0]);
            int cols = int.Parse(dimensions[1]);
            int[,] array1 = new int[rows, cols];
            int[,] array2 = new int[rows, cols];
            Console.WriteLine("Enter elements of the first array:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    array1[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    array2[i, j] = array1[i, j];
                }
            }
            Console.WriteLine("Elements of the second array:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(array2[i, j] + " ");
                }
                Console.WriteLine();
            }
            #endregion

            #region Q20.Write a program to print a one-dimensional array in reverse order.
            Console.Write("Enter the size of the array: ");
            int reverseArrSize = int.Parse(Console.ReadLine());
            int[] reverseArray = new int[reverseArrSize];
            Console.WriteLine("Enter the elements of the array:");
            for (int i = 0; i < reverseArrSize; i++)
                reverseArray[i] = int.Parse(Console.ReadLine());
            Array.Reverse(reverseArray);
            Console.WriteLine("Reversed array: " + string.Join(" ", reverseArray));
            #endregion
        }
    }
}

