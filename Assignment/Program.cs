using System.Collections;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Assignment
{
    internal class Program
    {
        #region Q01 - Given an array consists of numbers with size N and number of queries

        static void NumbersGreaterThanX(int[] arr, int[] queries)
        {
            foreach (int x in queries)
            {
                int count = 0;
                foreach (int num in arr)
                {
                    if (num > x)
                        count++;
                }
                Console.WriteLine(count);
            }
        }

        #endregion

        #region Q02 - Given a number N and an array of N numbers. Determine if it's palindrome or not.

        static bool IsPalindrome(int[] arr)
        {
            int left = 0, right = arr.Length - 1;
            while (left < right)
            {
                if (arr[left] != arr[right])
                    return false;
                left++;
                right--;
            }
            return true;
        }

        #endregion

        #region Q03 - Given a Queue, implement a function to reverse the elements of a queue using a stack.

        static Queue<int> ReverseQueue(Queue<int> queue)
        {
            Stack<int> stack = new Stack<int>();
            while (queue.Count > 0)
            {
                stack.Push(queue.Dequeue());
            }
            while (stack.Count > 0)
            {
                queue.Enqueue(stack.Pop());
            }
            return queue;
        }

        #endregion

        #region Q04 - Given a Stack, implement a function to check if a string of parentheses is balanced using a stack.

        static bool IsBalanced(string str)
        {
            Stack<char> stack = new Stack<char>();
            foreach (char c in str)
            {
                if (c == '(' || c == '[' || c == '{')
                {
                    stack.Push(c);
                }
                else
                {
                    if (stack.Count == 0)
                        return false;
                    char top = stack.Pop();
                    if ((c == ')' && top != '(') || (c == ']' && top != '[') || (c == '}' && top != '{'))
                    {
                        return false;
                    }
                }
            }
            return stack.Count == 0;
        }


        #endregion

        #region Q05 - Given an array, implement a function to remove duplicate elements from an array.

        static int[] RemoveDuplicates(int[] arr)
        {
            HashSet<int> uniqueSet = new HashSet<int>();
            List<int> result = new List<int>();

            foreach (int num in arr)
            {
                if (uniqueSet.Add(num)) // Add returns true if the element is not already in the set
                {
                    result.Add(num);
                }
            }

            return result.ToArray();
        }

        #endregion

        #region Q06 - Given an array list , implement a function to remove all odd numbers from it.

        static int[] RemoveOddNumbers(int[] arr)
        {
            List<int> result = new List<int>();

            foreach (int num in arr)
            {
                if (num % 2 == 0) // Check if the number is even
                {
                    result.Add(num);
                }
            }

            return result.ToArray();
        }

        #endregion

        #region Q08 - Create a function that pushes a series of integers onto a stack. Then, search for a target integer in the stack.If the target is found, 

        static void SearchInStack(Stack<int> stack, int target)
        {
            int count = 0;
            bool found = false;
            Stack<int> tempStack = new Stack<int>(stack);

            while (tempStack.Count > 0)
            {
                count++;
                if (tempStack.Pop() == target)
                {
                    found = true;
                    break;
                }
            }

            if (found)
            {
                Console.WriteLine($"Target found successfully and the count is {count}");
            }
            else
            {
                Console.WriteLine("Target not found");
            }
        }

        #endregion

        #region Q09 - 

        static int[] Intersection(int[] arr01, int[] arr02)
        {
            List<int> result = new List<int>();
            Dictionary<int, int> frequency = new Dictionary<int, int>();

            foreach (int num in arr01)
            {
                if (frequency.ContainsKey(num))
                    frequency[num]++;
                else
                    frequency[num] = 1;
            }

            foreach (int num in arr02)
            {
                if (frequency.ContainsKey(num) && frequency[num] > 0)
                {
                    result.Add(num);
                    frequency[num]--;
                }
            }

            return result.ToArray();
        }

        #endregion

        static void Main(string[] args)
        {

            #region Q01 - Given an array consists of numbers with size N and number of queries

            //Console.Write("Enter The Size of array: ");
            //int size = int.Parse(Console.ReadLine()!);

            //Console.Write("Enter The number of Queries: ");
            //int query = int.Parse(Console.ReadLine()!);

            //int[] arr = new int[size];
            //int[] queries = new int[query];

            //Console.WriteLine("Fill The Array => ");
            //for (int i = 0; i < size; i++)
            //{
            //    Console.Write($"Element {i + 1}: ");
            //    arr[i] = int.Parse(Console.ReadLine()!);
            //}

            //Console.WriteLine("Fill The Queries => ");
            //for (int i = 0; i < query; i++)
            //{
            //    Console.Write($"Query {i + 1}: ");
            //    queries[i] = int.Parse(Console.ReadLine()!);
            //}

            //NumbersGreaterThanX(arr, queries);

            #endregion

            #region Q02 - Given a number N and an array of N numbers. Determine if it's palindrome or not.

            //int[] arr = { 1, 3, 2, 3, 1 };

            //if (IsPalindrome(arr))
            //    Console.WriteLine("Yes!");
            //else
            //    Console.WriteLine("No!");

            #endregion

            #region Q03 - Given a Queue, implement a function to reverse the elements of a queue using a stack.

            //Queue<int> queue = new Queue<int>();
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //queue.Enqueue(4);
            //queue.Enqueue(5);

            //queue = ReverseQueue(queue);

            //foreach (int item in queue)
            //{
            //    Console.Write(item + " ");
            //}

            #endregion

            #region Q04 - Given a Stack, implement a function to check if a string of parentheses is balanced using a stack.

            //string str = "[()]{}";

            //if(IsBalanced(str))
            //    Console.WriteLine("Balanced!");
            //else
            //    Console.WriteLine("Not Balanced!");

            #endregion

            #region Q05 - Given an array, implement a function to remove duplicate elements from an array.

            //int[] arr = { 1, 1, 2, 2, 3, 4, 4, 5, 6, 7, 7 };
            //int[] result = RemoveDuplicates(arr);
            //Console.WriteLine(string.Join(", ", result));

            #endregion

            #region Q06 - Given an array list , implement a function to remove all odd numbers from it.

            //int[] arr = { 1, 2, 3, 4, 5, 6 };
            //int[] result = RemoveOddNumbers(arr);
            //Console.WriteLine(string.Join(", ", result));

            #endregion

            #region Q07 - Implement a queue that can hold different data types.

            //Queue queue = new Queue();
            //queue.Enqueue(1);
            //queue.Enqueue("Apple");
            //queue.Enqueue(5.28);

            //while (queue.Count > 0)
            //{
            //    Console.WriteLine(queue.Dequeue());
            //}

            #endregion

            #region Q08 - Create a function that pushes a series of integers onto a stack. Then, search for a target integer in the stack.If the target is found,

            //Stack<int> stack = new Stack<int>();
            //stack.Push(10);
            //stack.Push(20);
            //stack.Push(30);
            //stack.Push(40);

            //Console.Write("Enter target: ");
            //int target = int.Parse(Console.ReadLine()!);

            //SearchInStack(stack, target);

            #endregion

            #region Q09 - Given two arrays, find their intersection. Each element in the result should appear as many times as it shows in both arrays.

            //int[] arr01 = { 1, 2, 3, 4, 4 };
            //int[] arr02 = { 1, 4, 4 ,3};
            //int[] result = Intersection(arr01, arr02);
            //Console.WriteLine(string.Join(", ", result));

            #endregion

        }
    }
}
