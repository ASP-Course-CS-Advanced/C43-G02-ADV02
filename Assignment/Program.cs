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
        }
    }
}
