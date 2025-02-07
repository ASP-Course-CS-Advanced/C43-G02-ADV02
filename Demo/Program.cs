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

            #region Part 05 Generic Collections - List (Methods)

            #region 01 - Add(T item).

            //List<int> numbers = new List<int>(5) { 1, 2, 3, 4, 5 };
            //numbers.Add(6);

            //foreach (var item in numbers)
            //{
            //    Console.Write(item+" ");// 1 2 3 4 5 6
            //}

            #endregion

            #region 02 - Insert(T index, T item)

            //List<int> numbers = new List<int>(5) { 1, 2, 3, 4, 5 };
            //numbers.Insert(0,100);

            //foreach (var item in numbers)
            //{
            //    Console.Write(item + " ");// 100 1 2 3 4 5 6
            //}

            #endregion

            #region 03 - AddRange(IEnumerable<T> collection)

            //List<int> numbers = new List<int>(5) { 1, 2, 3, 4, 5 };
            //numbers.AddRange(new int[] {6,7,8,9,10});

            //foreach (var item in numbers)
            //{
            //    Console.Write(item + " ");// 1 2 3 4 5 6 7 8 9 10
            //}

            #endregion

            #region 04 - InsertRange()

            //List<int> numbers = new List<int>(5) { 1, 2, 3, 4, 5 };
            //numbers.InsertRange(2,new int[] { 6, 7, 8, 9, 10 });

            //foreach (var item in numbers)
            //{
            //    Console.Write(item + " ");// 1 2 6 7 8 9 10 3 4 5
            //}

            #endregion

            #region 05 - AsReadOnly()

            //List<int> numbers = new List<int>(5) { 1, 2, 3, 4, 5 };

            //IReadOnlyList<int> ReadOnlyNums = numbers.AsReadOnly();
            ////ReadOnlyNums.Add(1);//Invalid, ReadOnly Access.
            ////ReadOnlyNums[0] = 100;//Invalid, ReadOnly Access.

            //foreach (var item in ReadOnlyNums)
            //{
            //    Console.Write(item + " ");// 1 2 3 4 5
            //}
            //Console.WriteLine();

            //numbers.AddRange(new int[] { 6, 7, 8, 9 });

            //foreach (var item in ReadOnlyNums)
            //{
            //    Console.Write(item + " ");// 1 2 3 4 5 6 7 8 9
            //}

            #endregion

            #region 06 - BinarySearch

            #region 06.1 - BinarySearc(T item)

            //List<int> numbers = new List<int>(5) { 1, 2, 3, 4, 5 };

            //Console.WriteLine(numbers.BinarySearch(5));// 4
            //Console.WriteLine(numbers.BinarySearch(10));// -6


            //List<Employee> employees = new List<Employee>()
            //{
            //    new Employee(){Id = 10, Name = "Eslam", Salary = 8000},
            //    new Employee(){Id = 50, Name = "Eslam", Salary = 20_000},
            //    new Employee(){Id = 20, Name = "Ahmed", Salary = 9000}
            //};

            //employees.Sort();

            //Console.WriteLine(employees.BinarySearch(new Employee() { Id = 20, Name = "Ahmed", Salary = 9000 }));// 1 -> index after sorting

            #endregion

            #region 06.2 - BinarySearch(T item, IComparer<T>? comparer)

            //List<Employee> employees = new List<Employee>()
            //{
            //    new Employee(){Id = 10, Name = "Eslam", Salary = 8000},
            //    new Employee(){Id = 50, Name = "Khalid", Salary = 20_000},
            //    new Employee(){Id = 20, Name = "Ahmed", Salary = 9000}
            //};

            //employees.Sort(new EmployeeComparerId());

            //Console.WriteLine(employees.BinarySearch(new Employee() { Id = 50 }, new EmployeeComparerId()));// 2 -> After Sorting based on id.


            #endregion

            #region 06.3 - BinarySearc(int index,int count,T item, IComparer<T>? comparer)

            //List<Employee> employees = new List<Employee>()
            //{
            //    new Employee(){Id = 10, Name = "Eslam", Salary = 8000},
            //    new Employee(){Id = 50, Name = "Khalid", Salary = 20_000},
            //    new Employee(){Id = 20, Name = "Ahmed", Salary = 9000},
            //    new Employee(){Id = 30, Name = "Salam", Salary = 1000}
            //};

            //employees.Sort(new EmployeeComparerId());

            //Console.WriteLine(employees.BinarySearch(1,3,new Employee() { Id = 10}, new EmployeeComparerId()));// -2 -> Not found this element in the specified range.

            #endregion

            #endregion

            #region 07 - Clear()

            //List<int> numbers = new List<int>(5) { 1, 2, 3, 4, 5 };

            //Console.WriteLine($"Count: {numbers.Count}, Capacity: {numbers.Capacity}");// Count: 5, Capacity: 5

            //numbers.Clear();

            //Console.WriteLine($"Count: {numbers.Count}, Capacity: {numbers.Capacity}");// Count: 0, Capacity: 5

            #endregion

            #region 08 - Contains()

            //List<int> numbers = new List<int>(5) { 1, 2, 3, 4, 5 };

            //Console.WriteLine(numbers.Contains(3));// True

            #endregion

            #region 09 - ConvertAll<Toutput>(Convert)

            //List<int> numbers = new List<int>(5) { 1, 2, 3, 4, 5 };

            //List<long>longNumbers = numbers.ConvertAll<long>(delegate (int n) { n += 1000; return n; });

            //foreach (var item in longNumbers)
            //{
            //    Console.Write(item+" ");// 1001 1002 1003 1004 1005
            //}

            #endregion

            #region 10 - CopyTo()

            #region 10.1 - CopyTo(T[] array)

            //List<int> numbers = new List<int>(5) { 1, 2, 3, 4, 5 };
            //int[] arr = new int[5];// must be with size >= count of the source collection.
            //numbers.CopyTo(arr);

            //foreach (var item in arr)
            //{
            //    Console.Write(item+" ");// 1 2 3 4 5
            //}

            #endregion

            #region 10.2 - CopyTo(T[] array, int arrayIndex)

            //List<int> numbers = new List<int>(5) { 1, 2, 3, 4, 5 };
            //int[] arr = new int[10];// must be with size >= count of the source collection.
            //numbers.CopyTo(arr,5);// start copy with index (5) in the destination array

            //foreach (var item in arr)
            //{
            //    Console.Write(item + " ");// 0 0 0 0 0 1 2 3 4 5
            //}

            #endregion

            #region 10.3 CopyTo(int index, T[] arr, int arrayIndex, int count)

            //List<int> numbers = new List<int>(5) { 1, 2, 3, 4, 5 };
            //int[] arr = new int[10];
            //numbers.CopyTo(2, arr, 5, 3);

            //foreach (var item in arr)
            //{
            //    Console.Write(item + " ");// 0 0 0 0 0 3 4 5 0 0
            //}

            #endregion


            #endregion

            #region 11 - Find(predicate<T> match)

            //List<int> numbers = new List<int>(5) { 1, 2, 3, 4, 5 };

            //int firstEvenNumber = numbers.Find(N => N % 2 == 0);

            //Console.WriteLine(firstEvenNumber);// 2

            #endregion

            #region 12 - FindLast(predicate<T> match)

            //List<int> numbers = new List<int>(5) { 1, 2, 3, 4, 5 };

            //int lastEvenNumber = numbers.FindLast(N => N % 2 == 0);

            //Console.WriteLine(lastEvenNumber);// 4

            #endregion

            #region 13 - FindIndex(predicate<T> match)

            //List<int> numbers = new List<int>(5) { 1, 2, 3, 4, 5 };

            //int firstEvenNumber = numbers.Find(N => N % 2 == 0);
            //int firstEvenNumberIndex = numbers.FindIndex(N => N % 2 == 0);

            //Console.WriteLine($"First Even Number => {firstEvenNumber}, at index => {firstEvenNumberIndex}");// First Even Number => 2, at index => 1

            #endregion

            #region 14 - FindLastIndex(predicate<T> match)

            //List<int> numbers = new List<int>(5) { 1, 2, 3, 4, 5 };

            //int lastEvenNumber = numbers.FindLast(N => N % 2 == 0);
            //int lastEvenNumberIndex = numbers.FindLastIndex(N => N % 2 == 0);

            //Console.WriteLine($"Last Even Number => {lastEvenNumber}, at index => {lastEvenNumberIndex}");// Last Even Number => 4, at index => 3

            #endregion

            #region 15 - FindAll(predicate<T> match)

            //List<int> numbers = new List<int>(10) { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //List<int> EvenNumbers = numbers.FindAll(N => N % 2 == 0);

            //foreach (var item in EvenNumbers)
            //{
            //    Console.Write(item + " ");// 2 4 6 8 10
            //}

            #endregion

            #region 16 - Exists(predicate<T> match)

            //List<int> numbers = new List<int>(5) { 1, 2, 3, 4, 5 };

            //Console.WriteLine(numbers.Exists(N => N % 2 == 0));// True

            #endregion

            #region 17 - TrueForAll(predicate<T> match)

            //List<int> numbers = new List<int>(5) { 1, 2, 3, 4, 5 };

            //Console.WriteLine(numbers.TrueForAll(N => N % 2 == 0));// False

            #endregion

            #region 18 - ForEach(Action<T> action)

            //List<int> numbers = new List<int>(5) { 1, 2, 3, 4, 5 };

            //numbers.ForEach(N =>
            //{
            //    N += 100;
            //    Console.Write(N+" ");// 101 102 103 104 105
            //});

            //Console.WriteLine();

            //foreach (var item in numbers)
            //{
            //    Console.Write(item+" ");// 1 2 3 4 5
            //}

            #endregion

            #region 19 - GetRange(int index, int count)

            //List<int> numbers = new List<int>(5) { 1, 2, 3, 4, 5 };

            //List<int> subRangeNumbers = numbers.GetRange(0, 3);

            //foreach (var item in subRangeNumbers)
            //{
            //    Console.Write(item+" ");// 1 2 3
            //}

            #endregion

            #region 20 - IndexOf()

            #region 20.1 - IndexOf(T item)

            //List<int> number = new List<int>(5) { 1, 2, 3, 4, 5 };

            //Console.WriteLine(number.IndexOf(4));// 3 -> index of the first occurence of (4)

            #endregion

            #region 20.2 - IndexOf(T item,int index)

            //List<int> number = new List<int>(5) { 5, 2, 3, 4, 4 };

            //Console.WriteLine(number.IndexOf(5,1));// -1 -> not found "5" in the range of elemnts from index 1

            #endregion

            #region 20.3 - IndexOf(T item,int index,int count)

            //List<int> number = new List<int>(8) { 5, 2, 3, 5, 4, 8, 9, 5 };

            //Console.WriteLine(number.IndexOf(5, 1, 4));// 3

            #endregion


            #endregion

            #region 21 - LastIndexOf()

            #region 20.1 - IndexOf(T item)

            //List<int> number = new List<int>(5) { 5, 1, 2, 3, 4, 5 };

            //Console.WriteLine(number.LastIndexOf(5));// 5

            #endregion

            #region 20.2 - IndexOf(T item,int index)

            //List<int> number = new List<int>(5) { 5, 2, 3, 4, 4 };

            //Console.WriteLine(number.LastIndexOf(5, 2));// 0

            #endregion

            #region 20.3 - IndexOf(T item,int index,int count)

            //List<int> number = new List<int>(8) { 5, 2, 3, 5, 4, 8, 9, 5 };

            //Console.WriteLine(number.LastIndexOf(2, 4, 4));// 1

            #endregion

            #endregion

            #region 22 - Remove(T item)

            //List<int> numbers = new List<int>() { 1, 2, 3, 4, 5 };

            //Console.WriteLine(numbers.Remove(2));// True

            //foreach (var item in numbers)
            //{
            //    Console.Write(item+" ");// 1 3 4 5
            //}

            #endregion

            #region 23 - RemoveAt(int index)

            //List<int> numbers = new List<int>() { 1, 2, 3, 4, 5 };

            //numbers.RemoveAt(4);

            //foreach (var item in numbers)
            //{
            //    Console.Write(item + " ");// 1 2 3 4
            //}

            #endregion

            #region 24 - RemoveRange(int index,int count)

            //List<int> numbers = new List<int>() { 1, 2, 3, 4, 5 };

            //numbers.RemoveRange(1,3);

            //foreach (var item in numbers)
            //{
            //    Console.Write(item + " ");// 1 5
            //}

            #endregion

            #region 25 - RemoveRange(int index,int count)

            //List<int> numbers = new List<int>() { 1, 2, 3, 4, 5 };

            //int numberOfRemovedElements = numbers.RemoveAll(N => N % 2 == 0);

            //Console.WriteLine(numberOfRemovedElements);// 2

            //foreach (var item in numbers)
            //{
            //    Console.Write(item + " ");// 1 3 5
            //}

            #endregion

            #region 26 - Reverse()

            //List<int> numbers = new List<int>(5) { 1, 2, 3, 4, 5 };

            //numbers.Reverse();

            //foreach (var item in numbers)
            //{
            //    Console.Write(item+" ");// 5 4 3 2 1
            //}

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

            #region Part 07 Generic Collections - Stack [LIFO]

            #region Ex01

            //Stack<int> stack = new Stack<int>();

            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);
            //stack.Push(4);
            //stack.Push(5);

            //Console.WriteLine(stack.Pop());// 5

            //foreach (var item in stack)
            //{
            //    Console.Write(item + " ");// 4 3 2 1
            //}

            #endregion

            #region Ex02

            //Stack<int> stack = new Stack<int>();

            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);

            //Console.WriteLine(stack.TryPop(out int value01));// True
            //Console.WriteLine(value01);// 3

            //Console.WriteLine(stack.TryPop(out int value02));// True
            //Console.WriteLine(value02);// 2

            //Console.WriteLine(stack.TryPop(out int value03));// True
            //Console.WriteLine(value03);// 1

            //Console.WriteLine(stack.TryPop(out int value04));// False [stack is empty so pop fail]
            //Console.WriteLine(value04);// 0 [default value of int [valueType]]

            #endregion

            #region Ex03

            //Stack<int> stack = new Stack<int>();

            //Console.WriteLine(stack.TryPeek(out int value01));// False
            //Console.WriteLine(value01);// 0

            //stack.Push(5);

            //Console.WriteLine(stack.TryPeek(out int value02));// True
            //Console.WriteLine(value02);// 5

            #endregion

            #endregion

            #region Part 08 Generic Collections - Queue [FIFo].

            #region Ex01

            //Queue<int> queue = new Queue<int>();

            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //queue.Enqueue(4);
            //queue.Enqueue(5);

            //Console.WriteLine(queue.Dequeue());// 1

            //foreach (var item in queue)
            //{
            //    Console.Write(item + " ");// 2 3 4 5
            //}

            #endregion

            #region Ex02

            //Queue<int> queue = new Queue<int>();

            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);

            //Console.WriteLine(queue.TryDequeue(out int value01));// True
            //Console.WriteLine(value01);// 1

            //Console.WriteLine(queue.TryDequeue(out int value02));// True
            //Console.WriteLine(value02);// 2

            //Console.WriteLine(queue.TryDequeue(out int value03));// True
            //Console.WriteLine(value03);// 3

            //Console.WriteLine(queue.TryDequeue(out int value04));// False [queue is empty so Dequeue fail]
            //Console.WriteLine(value04);// 0 [default value of int [valueType]]

            #endregion

            #region Ex03

            //Queue<int> queue = new Queue<int>();

            //Console.WriteLine(queue.TryPeek(out int value01));// False
            //Console.WriteLine(value01);// 0

            //queue.Enqueue(5);

            //Console.WriteLine(queue.TryPeek(out int value02));// True
            //Console.WriteLine(value02);// 5

            #endregion

            #endregion



        }
    }
}
