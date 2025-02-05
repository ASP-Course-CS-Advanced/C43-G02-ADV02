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
        }
    }
}
