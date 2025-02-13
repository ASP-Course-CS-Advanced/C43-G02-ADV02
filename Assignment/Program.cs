using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;
namespace Assignment
{
    internal class Program
    {
        #region 01 - GPT Solve

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

        #region Q10 - Given an ArrayList of integers and a target sum, find if there is a contiguous sub list that sums up to the target.

        static void PrintSublist(int[] arr, int start, int end)
        {
            Console.Write("[");
            for (int i = start; i <= end; i++)
            {
                Console.Write(arr[i]);
                if (i < end) Console.Write(", ");
            }
            Console.WriteLine("]");
        }

        static void FindSublist(int[] arr, int target)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int sum = 0;
                for (int j = i; j < arr.Length; j++)
                {
                    sum += arr[j];
                    if (sum == target)
                    {
                        PrintSublist(arr, i, j);
                        return;
                    }
                }
            }
            Console.WriteLine("No sublist found");
        }

        #endregion


        #endregion

        #region 02 - Me Solve

        #region Q01 -  Given an array  consists of  numbers with size N and number of queries, in each query you will be given an integer X

        public static void NumbersMoreThanQuery(int[] arr, int[] Queries)
        {
            for (int i = 0; i < Queries.Length; i++)
            {
                int count = 0;
                List<int> newList = new List<int>();
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[j] > Queries[i])
                    {
                        count++;
                        newList.Add(arr[j]);
                    }
                }
                Console.WriteLine($"The Count of numbers more than {Queries[i]} => {count}, And is => {string.Join(", ", newList)}");
            }
        }

        #endregion

        #region Q02 - Given a number N and an array of N numbers. Determine if it's palindrome or not

        public bool isPalindromeArr(int[] arr)
        {
            int[] RevArr = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                RevArr[i] = arr[arr.Length - i - 1];
            }

            bool isPalindrome = true;

            for (int i = 0; i < arr.Length; i++)
            {
                if (!(arr[i] == RevArr[i]))
                    isPalindrome = false;
            }
            return isPalindrome;
        }

        #endregion

        #region Q03 - Given a Queue, implement a function to reverse the elements of a queue using a stack.

        public static Queue<int> ReverseQueueElements(Queue<int> nums)
        {
            Stack<int> ReverseNums = new Stack<int>(nums.Count);

            foreach (var item in nums)
            {
                ReverseNums.Push(item);
            }

            Queue<int> newRevNums = new Queue<int>(nums.Count);

            foreach (var item in ReverseNums)
            {
                newRevNums.Enqueue(item);
            }

            return newRevNums;

        }

        #endregion

        #region Q06 - Given an array list , implement a function to remove all odd numbers from it.

        public static void RemoveElements(ArrayList arrayList, Predicate<int?> predicate)
        {
            for (int i = 0; i < arrayList.Count; i++)
                if (predicate.Invoke(arrayList[i] as int?))
                    arrayList.RemoveAt(i);
        }

        #endregion

        #region Q08 - Create a function that pushes a series of integers onto a stack. 

        public static void PushSeriesOfIntOntoStackAndSearch(Stack<int> nums, int target)
        {
            int count = nums.Count;
            bool found = false;
            foreach (var item in nums)
            {
                count--;
                if (target == item)
                {
                    found = true;
                    break;
                }
            }
            if (found)
                Console.WriteLine($"Target was found successfully and the count = {count + 1}");
            else
                Console.WriteLine($"Target was not found !");

        }

        #endregion

        #region Q09 - Given two arrays, find their intersection. 

        public static List<T> FindIntersection2Arr<T>(T[] arr1, T[] arr2) where T : IComparable
        {
            List<T> list = new List<T>();
            for (int i = 0; i < arr1.Length; i++)
                for (int j = 0; j < arr2.Length; j++)
                {
                    if (arr1[i].CompareTo(arr2[j]) == 0)
                    {
                        list.Add(arr1[i]);
                        break;
                    }

                }
            return list;
        }

        #endregion

        #region Q11 - Given a queue reverse first K elements of a queue, keeping the remaining elements in the same order 

        public static void ReverseFirstKElementsOfQueue(Queue<int> queue, int k)
        {
            List<int> ints = new List<int>(queue.Count);

            foreach (var item in queue)
            {
                ints.Add(item);
            }

            ints.Reverse(0, k);

            queue.Clear();

            foreach (var item in ints)
            {
                queue.Enqueue(item);
            }

        }

        #endregion 

        #endregion

        static void Main(string[] args)
        {

            #region 01 - Gpt Solve

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

            #region Q10 - Given an ArrayList of integers and a target sum, find if there is a contiguous sub list that sums up to the target.

            //int[] arr = { 1, 2, 3, 7, 5 };
            //int target = 12;
            //FindSublist(arr, target);

            #endregion

            #endregion

            #region 02 - Me Solve

            #region Q01 - Given an array  consists of  numbers with size N and number of queries, in each query you will be given an integer X

            //Console.Write("Plz enter the size of the array: ");
            //int size = int.Parse(Console.ReadLine()!);
            //int[] arr = new int[size];

            //Console.Write("Plz enter Number of Queries: ");
            //int Queries = int.Parse(Console.ReadLine()!);
            //int[] QueriesArr = new int[Queries];

            //Console.WriteLine("Fill The Array: ");
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($"Element {i + 1}: ");
            //    arr[i] = int.Parse(Console.ReadLine()!);
            //}

            //Console.WriteLine("Enter The Queries: ");
            //for (int i = 0; i < QueriesArr.Length; i++)
            //{
            //    Console.Write($"Query {i + 1}: ");
            //    QueriesArr[i] = int.Parse(Console.ReadLine()!);
            //}

            //NumbersMoreThanQuery(arr, QueriesArr);

            #endregion

            #region Q02 - Given a number N and an array of N numbers. Determine if it's palindrome or not

            //Console.Write("Enter Size Of The Array: ");
            //int size = int.Parse(Console.ReadLine()!);
            //int[] arr = new int[size];

            //Console.WriteLine("Fill The Array => ");
            //for (int i = 0; i < size; i++)
            //{
            //    Console.Write($"Element {i + 1}: ");
            //    arr[i] = int.Parse(Console.ReadLine()!);
            //}

            //Console.WriteLine(IsPalindrome(arr));

            #endregion

            #region Q03 - Given a Queue, implement a function to reverse the elements of a queue using a stack.

            //Queue<int> nums = new Queue<int>();
            //nums.Enqueue(1);
            //nums.Enqueue(2);
            //nums.Enqueue(3);
            //nums.Enqueue(4);
            //nums.Enqueue(5);

            //Queue<int> RevNums = ReverseQueueElements(nums);

            //Console.WriteLine(string.Join(", ", RevNums));//5, 4, 3, 2, 1 

            #endregion

            #region Q06 - Given an array list , implement a function to remove all odd numbers from it.

            //ArrayList numbers = new ArrayList { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //RemoveElements(numbers, X => X % 2 == 1);

            //foreach (var item in numbers)
            //{
            //    Console.Write(item + " ");//2 4 6 8 10
            //}

            #endregion

            #region Q07 - Implement a queue that can hold different data types

            //Queue queue = new Queue();
            //queue.Enqueue(1);
            //queue.Enqueue("Apple");
            //queue.Enqueue(5.28);

            //foreach (var item in queue)
            //{
            //    Console.Write(item+" ");// 1 Apple 5.28
            //}

            #endregion

            #region Q08 - Create a function that pushes a series of integers onto a stack. 

            //Stack<int> ints = new Stack<int>(5);
            //ints.Push(0);
            //ints.Push(5);
            //ints.Push(4);
            //ints.Push(7);
            //ints.Push(9);
            //ints.Push(1);

            //bool isParse = true;
            //int result;
            //do
            //{
            //    Console.Write("Input The Target Value: ");
            //    isParse = int.TryParse(Console.ReadLine(), out result);
            //} while (!isParse);

            //PushSeriesOfIntOntoStackAndSearch(ints, result);//Target was found successfully and the count = 3 

            #endregion

            #region Q09 - Given two arrays, find their intersection. Each element in the result should appear as many times as it shows in both arrays.

            //string[] arr1 = ["Ahmed", "Eslam", "Khalid", "Ebrahim", "Amr"];
            //string[] arr2 = ["Khalid", "Mohamed", "Amr", "Salim"];

            //List<string> names = FindIntersection2Arr<string>(arr1, arr2);

            //Console.WriteLine(string.Join(", ", names));

            #endregion

            #region Q11 - Given a queue reverse first K elements of a queue, keeping the remaining elements in the same order 

            //Queue<int> queue = new Queue<int>();
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //queue.Enqueue(4);
            //queue.Enqueue(5);

            //ReverseFirstKElementsOfQueue(queue, 3);

            //foreach (var item in queue)
            //{
            //    Console.Write(item + " ");
            //}

            #endregion 

            #endregion

        }
    }
}
