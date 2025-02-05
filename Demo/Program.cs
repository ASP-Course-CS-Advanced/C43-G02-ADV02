using System.Collections;

namespace Demo
{
    internal class Program
    {

        #region Part 03 NonGeneric Collections Cons

        public static int SumArrayList(ArrayList numbers)
        {
            int sum = 0;
            if (numbers?.Count > 0)
            {
                for (int i = 0; i < numbers.Count; i++)
                    sum += (int?)numbers[i] ?? 0;// Unsafe Casting [ May throw exception if the value of numbers[i] is of type not int ]
            }
            return sum;
        }

        #endregion

        #region Part 04 Generic Collections - List

        public static int SumList(List<int> numbers)
        {
            int sum = 0;
            if (numbers?.Count > 0)
            {
                for (int i = 0; i < numbers.Count; i++)
                    sum += numbers[i];// No Unboxing - "Sum" is of type "int" and "numbers[i]" is of type "int"
            }
            return sum;
        }

        #endregion

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

            #region Part 03 NonGeneric Collections Cons

            //ArrayList numbers = new ArrayList(5);

            //numbers.Add(1);// Boxing, Add(object? item) - and you try to add int value - so this int value "1" will boxed into object in heap and return address of it to "item" that represent first element in the array of objects? .
            //numbers.Add(2);// Boxing, Add(object? item) - and you try to add int value - so this int value "2" will boxed into object in heap and return address of it to "item" that represent Second element in the array of objects? .
            //numbers.Add(3);// Boxing, Add(object? item) - and you try to add int value - so this int value "3" will boxed into object in heap and return address of it to "item" that represent Third element in the array of objects? .
            //numbers.Add(4);// Boxing, Add(object? item) - and you try to add int value - so this int value "4" will boxed into object in heap and return address of it to "item" that represent Fourth element in the array of objects? .
            //numbers.Add("Eslam");// Will Work, Because You Add into Array of objects? - Compiler can't enforce Type Safety - No Boxing , Because You pass object of type string [reference type].

            //Console.WriteLine(SumArrayList(numbers));// System.InvalidCastException: Unable to cast object of type 'System.String' to type 'System.Nullable`1[System.Int32]'.

            #endregion

            #region Part 04 Generic Collections - List

            #region Part01

            //List<int> numbers = new List<int>();
            //Console.WriteLine($"Count = {numbers.Count}, Capacity = {numbers.Capacity}");// Count = 0, Capacity = 0

            //numbers.Add(1);
            //Console.WriteLine($"Count = {numbers.Count}, Capacity = {numbers.Capacity}");// Count = 1, Capacity = 4

            //numbers.AddRange(new int[] { 2, 3, 4 });
            //Console.WriteLine($"Count = {numbers.Count}, Capacity = {numbers.Capacity}");// Count = 4, Capacity = 4

            //numbers.Add(5);
            //Console.WriteLine($"Count = {numbers.Count}, Capacity = {numbers.Capacity}");// Count = 5, Capacity = 8

            //numbers.TrimExcess();
            //Console.WriteLine($"Count = {numbers.Count}, Capacity = {numbers.Capacity}");// Count = 5, Capacity = 5 

            #endregion

            #region Part02

            //List<int> numbers = new List<int>(6) { 1, 2, 3, 4, 5 };
            //Console.WriteLine($"Count:{numbers.Count}, Capacity: {numbers.Capacity}");// Count:5, Capacity: 6

            //numbers[0] = 100;
            ////numbers[5] = 20;//Exception - out of range - indexer can access elements of index (i < count) only.

            //for (int i = 0; i < numbers.Count; i++) // Because List has Indexer [].
            //    Console.Write(numbers[i]+" ");// 100 2 3 4 5

            //Console.WriteLine();

            //foreach (int num in numbers)// Because List implement IEnumerable Interface.
            //    Console.Write(num+" ");// 100 2 3 4 5


            #endregion

            #region Part03

            //List<int> numbers = new List<int>(5);

            //numbers.Add(1);// No-Boxing, Add(int item) - and you try to add int value - so this no casting from type to another
            //numbers.Add(2);
            //numbers.Add(3);
            //numbers.Add(4);
            ////numbers.Add("Eslam");// Error, Because Add(int item) take only integer values - Compiler can enforce the type safety.

            //Console.WriteLine(SumList(numbers));// 10

            #endregion

            #endregion

            #region Part 06 Generic Collections - LinkedList

            //LinkedList<int> numbers = new LinkedList<int>();

            //LinkedListNode<int> node1 = numbers.AddFirst(1);
            //LinkedListNode<int> node4 = numbers.AddLast(4);
            //LinkedListNode<int> node2 = numbers.AddAfter(node1,2);
            //LinkedListNode<int> node3 = numbers.AddBefore(node4,3);

            //Console.WriteLine(node1.Next.Value);// 2

            //foreach (int item in numbers)
            //{
            //    Console.Write(item+ " ");// 1 2 3 4
            //}

            #endregion

        }
    }
}
