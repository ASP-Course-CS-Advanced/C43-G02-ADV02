namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Part 02 NonGeneric Collections - ArrayList

            #region Part01 - Use Parameterless Constructor (new ArrayList()) & Add elements using method Add().

            //ArrayList numbers = new ArrayList();
            //Console.WriteLine($"Count = {numbers.Count}, Capacity = {numbers.Capacity}");// Count = 0, Capacity = 0

            //numbers.Add(1);// Boxing
            //Console.WriteLine($"Count = {numbers.Count}, Capacity = {numbers.Capacity}");// Count = 1, Capacity = 4

            //numbers.AddRange(new int[] { 2, 3, 4 });
            //Console.WriteLine($"Count = {numbers.Count}, Capacity = {numbers.Capacity}");// Count = 4, Capacity = 4

            //numbers.Add(5);
            //Console.WriteLine($"Count = {numbers.Count}, Capacity = {numbers.Capacity}");// Count = 5, Capacity = 8

            //numbers.TrimToSize();
            //Console.WriteLine($"Count = {numbers.Count}, Capacity = {numbers.Capacity}");// Count = 5, Capacity = 5 

            #endregion

            #region Part02 - Use Parameterless Constructor (new ArrayList() { 1, 2, 3, 4, 5, 6, 7, 8, 9 }) & Add elements using object Initializer.

            //ArrayList numbers = new ArrayList() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //Console.WriteLine($"Count = {numbers.Count}, Capacity = {numbers.Capacity}");// Count = 9, Capacity = 16 

            //// In this Example, CLR will make 3 new array of object
            //// 1- when adding first element [1], oldObject [Count = 0, Capacity = 0] - newObject [Count = 1, Capacity = 4].
            //// 2- when adding fifth element [5], oldObject [Count = 4, Capacity = 4] - newObject [Count = 5, Capacity = 8].
            //// 2- when adding ninth element [9], oldObject [Count = 8, Capacity = 8] - newObject [Count = 9, Capacity = 16].

            #endregion

            #region Part03 - Using Parametrized Constructor [new ArrayList(int Capacity)] That Take Capacity Value [if you know the number of elements will be added to array to avoid frequently creating new array object].

            //ArrayList numbers = new ArrayList(6) { 1, 2, 3, 4, 5, 6 };
            //Console.WriteLine($"Count = {numbers.Count}, Capacity = {numbers.Capacity}");// Count = 6, Capacity = 6

            #endregion

            #region Part04 - Using Parametrized Constructor [ new ArrayList(ICollection c) ]That Take object from any class implement "ICollection" interface.

            //int[] arr = new int[] { 1, 2, 3, 4, 5 };
            //ArrayList numbers = new ArrayList(arr);

            //foreach (int num in numbers)
            //{
            //    Console.Write(num + " ");// 1 2 3 4 5
            //}

            #endregion

            #region Part05 

            //ArrayList numbers = new ArrayList(5) { 1, 2, 3, 4, 5 };

            //if (numbers.Capacity < 21)
            //    numbers.Capacity = 21;

            //for (int i = 6; i <= 21; i++)
            //    numbers.Add(i);

            //foreach (int num in numbers)
            //{
            //    Console.Write(num + " ");// 1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20 21
            //} 

            #endregion

            #endregion

        }
    }
}
