using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Linear_Data_Structures
{
    class Program

    {
        static void Main()
        {
            //Questions

            //Write a few sentences describing when you would use a liked list in solving a problem and why you would do so. - 2.5 points
            //you don't know how many items will be in the list.
            //With arrays, you may need to re-declare and copy memory if the array grows too big.
            //
            //
            //
            //Write a sentence or two describing the difference between a stack and a queue. - 2.5 points
            //Imagine a stack as in a stack of objects where you can only give and recieve from the top.
            //Imagine a queue as in a horizontal stack where you can give and recieve from both sides (front and rear)
            //
            //
            //Describe a situation in which a developer would use a stack while writing a program. -2.5 points
            //We can use stacks to reverse items such as in this assignment.
            //Could use for emails and certain communication apps to see newest message.
            //
            //
            //
            //In what situation would a developer use an array rather than a list while writing a program? -2.5 points
            // I found from a website named 'softwareengineering' that,
            // "The most important reason I use an array instead of a List<> is to imply that the data is fixed length.
            // If I won't add or remove any items from that data collection, I want to make sure that the type reflects that."
            //
            //I feel that this hit it pretty well, so I felt the need to quote it.
            //








            //Program #2
            //Write a program, which reads from the console N integers and prints them in reversed order. Use the Stack<int> class. Use pop and push in your processing. (15 points)
            Console.WriteLine("\nPlease enter a list of integers. Each integer should be separated by a comma.\n");

            string[] list = Console.ReadLine().Split(",");
            int[] integers = Array.ConvertAll(list, s => int.Parse(s));
            Stack<int> stack = new Stack<int>();
            //Push integers into Stack<int>
            foreach (int x in integers)
            {
                stack.Push(x);
            }
            Console.Write("\nThe list of given integers in reverse order is:\n");
            //Print ints in reverse order with .Pop
            while (stack.Count > 0)
            {
                int integer = stack.Pop();
                Console.WriteLine(integer);
            }



            //Program #7
            //Write a program that finds in a given array of integers (in the range [0...1000]) how many times each of them occurs. Example: array = { 3, 4, 4, 2, 3, 3, 4, 3, 2} (15 points)
            Console.WriteLine("Program 7:\nEnter an array of integers; each int should be separated by a comma.\nThis program will count how many times each int occurs.\n\n");

            //Separating integers to add into array
            string[] theList = Console.ReadLine().Split(",");
            int[] integerList = Array.ConvertAll(theList, k => int.Parse(k));

            int[] arr1 = new int[] { };
            List<int> listArr1 = arr1.ToList();
            foreach (int x in integerList)
            {
                listArr1.Add(x);
            }
            Dictionary<int, int> dict1 = new Dictionary<int, int>();
            foreach (int i in listArr1)
            {
                if (dict1.ContainsKey(i))
                {
                    int value = dict1[i];
                    value++;
                    dict1[i] = value;
                }
                else
                {
                    dict1.Add(i, 1);
                }
            }
            for (int x = 0; x < dict1.Count(); x++)
            {
                Console.WriteLine("Value {0} is repeated {1} times", dict1.Keys.ElementAt(x), dict1[dict1.Keys.ElementAt(x)]);
            }



            //Program #9
            //Not 100% sure exactly what you meant on this question but I have been without wifi over break so I am just trying my best

            Console.WriteLine("Any Key to Continue...");
            Console.ReadLine();
            Queue queue = new Queue();
            int N = 1;
            queue.Enqueue(N);
            int index = 0;
            int p = 50;
            Console.WriteLine("S =");
            while (queue.Count < 351)
            {
                index++;
                int current = (int)queue.Dequeue();
                Console.WriteLine(" " + current);
                if (current == p)
                {
                    Console.WriteLine();
                    Console.WriteLine("Index = " + index);
                    return;
                }

                int S1 = N;
                int S2 = S1 + 1;
                int S3 = 2 * S1 + 1;
                int S4 = S1 + 2;
                int S5 = S2 + 1;
                int S6 = 2 * S2 + 1;
                int S7 = S2 + 2;

                queue.Enqueue(S1);
                queue.Enqueue(S2);
                queue.Enqueue(S3);
                queue.Enqueue(S4);
                queue.Enqueue(S5);
                queue.Enqueue(S6);
                queue.Enqueue(S7);
            }
        }
    }
}



