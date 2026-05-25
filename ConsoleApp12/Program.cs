using System.Collections;

namespace ConsoleApp303
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyNode<string> node1 = new MyNode<string>("Lado");
            MyNode<string> node2 = new MyNode<string>("Giorgi");
            MyNode<string> node3 = new MyNode<string>("Luka");
            MyNode<string> node4 = new MyNode<string>("Nika");
            MyNode<string> node5 = new MyNode<string>("Efemia");
            MyNode<string> node6 = new MyNode<string>("Tornike");
            MyNode<string> node7 = new MyNode<string>("Lika");
            MyNode<string> node8 = new MyNode<string>("Elene");

            node1.Next = node2;
            node2.Next = node3;
            node3.Next = node4;
            node4.Next = node5;
            node5.Next = node6;
            node6.Next = node7;
            node7.Next = node8;

            Print(node1);
        }

        public static void Print<T>(MyNode<T>? node)
        {
            if (node == null)
                return;
            Console.WriteLine(node);
            Print(node.Next);
        }

        //public static void Print<T>(MyNode<T> node)
        //{
        //    MyNode<T>? currentNode = node;
        //    while (currentNode != null)
        //    {
        //        Console.WriteLine(currentNode);
        //        currentNode = currentNode.Next;
        //    }
        //} 
    }

    public class MyLinkedList<T> : ICollection<T>
    {
        private MyNode<T>? _first;

        public int Count { get; private set; }
        public bool IsReadOnly => false;

        public MyNode<T> AddFirst(T value)
        {
            ArgumentNullException.ThrowIfNull(value, nameof(value));

            var newNode = new MyNode<T>(value, _first);
            AddFirst(newNode);
            return newNode;
        }

        public void AddFirst(MyNode<T> node)
        {
            ArgumentNullException.ThrowIfNull(node, nameof(node));

            node.Next = _first;
            _first = node;
            Count++;
        }

        public MyNode<T> AddLast(T value)
        {
            throw new NotImplementedException();
        }

        public void AddLast(MyNode<T> node)
        {
            throw new NotImplementedException();
        }

        public MyNode<T> AddAfter(MyNode<T> node, T value)
        {
            throw new NotImplementedException();
        }

        public void AddAfter(MyNode<T> node, MyNode<T> newNode)
        {
            throw new NotImplementedException();
        }

        public MyNode<T> AddBefore(MyNode<T> node, T value)
        {
            throw new NotImplementedException();
        }

        public void AddBefore(MyNode<T> node, MyNode<T> newNode)
        {
            throw new NotImplementedException();
        }

        public bool Remove(T value)
        {
            throw new NotImplementedException();
        }

        public void Remove(MyNode<T> node)
        {
            throw new NotImplementedException();
        }

        public void RemoveFirst()
        {
            throw new NotImplementedException();
        }

        public void RemoveLast()
        {
            throw new NotImplementedException();
        }

        public MyNode<T>? Find(T value)
        {
            throw new NotImplementedException();
        }

        public MyNode<T>? FindLast(T value)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(T value)
        {
            MyNode<T>? current = _first;
            while (current != null)
            {
                if (Equals(current.Value, value))
                    return true;
                current = current.Next;
            }
            return false;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        void ICollection<T>.Add(T item)
        {
            AddLast(item);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class MyNode<T>
    {
        public MyNode(T value)
        {
            Value = value;
        }

        public MyNode(T value, MyNode<T> next) : this(value)
        {
            Next = next;
        }

        public T Value { get; set; }
        public MyNode<T> Next { get; set; }

        public override string? ToString()
        {
            return Value?.ToString();
        }
    }
}

////////////////////////////////
////////////////////////////////
///////////////////////////////
/////


//using System.Collections;

//namespace G03_20210221
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            //Hashtable market = new Hashtable();
//            Dictionary<string, Product> market = new Dictionary<string, Product>();

//            Product p1 = new Product("P001", "Apple", 5);
//            market.Add("P001", p1);

//            Product p2 = new Product("P002", "Banana", 20);
//            market.Add(p2.Code, p2);

//            market.Add("P003", new Product("P003", "Orange", 3.5));
//            market.Add("P004", new Product("P004", "Strawberry", 1));
//            market.Add("P005", new Product("P005", "Pear", 7));

//            //tu eseti key aris mashin tavze gadaawers values, tu arada daamatebs.
//            market["P006"] = new Product("P006", "Pineapple", 21);

//            foreach (var item in market)
//            {
//                Console.WriteLine($"{item.Key}: {item.Value}");
//            }
//        }
//    }

//    class Product
//    {
//        public string Code { get; private init; }
//        public string Name { get; set; }
//        public double Price { get; set; }

//        public Product(string code)
//        {
//            ArgumentNullException.ThrowIfNull(code, nameof(code));
//            Code = code;
//        }

//        public Product(string code, string name, double price) : this(code)
//        {
//            Name = name;
//            Price = price;
//        }

//        public override string ToString()
//        {
//            return $"Code: {Code}, Name: {Name}, Price: {Price:0.00}";
//        }
//    }
//}
///////////////////////////////
/////////////////////////////
/////////////////////////////
/////
//using System.Collections;

//namespace G03_20210221
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            //Hashtable market = new Hashtable();
//            Dictionary<string, Product> market = new Dictionary<string, Product>();

//            Product p1 = new Product("P001", "Apple", 5);
//            market.Add("P001", p1);

//            Product p2 = new Product("P002", "Banana", 20);
//            market.Add(p2.Code, p2);

//            market.Add("P003", new Product("P003", "Orange", 3.5));
//            market.Add("P004", new Product("P004", "Strawberry", 1));
//            market.Add("P005", new Product("P005", "Pear", 7));

//            //tu eseti key aris mashin tavze gadaawers values, tu arada daamatebs.
//            market["P006"] = new Product("P006", "Pineapple", 21);

//            //elementis dzebna da downcasti product - ze
//            while (true)
//            {
//                // klaviaturidan sadziebo kodis sheyvana
//                Console.Write("Enter Code: ");
//                string key = Console.ReadLine().ToUpper();

//                if (key == "EXIT")
//                {
//                    break;
//                }

//                if (market.TryGetValue(key, out Product? product))
//                {
//                    Console.WriteLine(product);
//                }
//                else
//                {
//                    Console.WriteLine("Product not found.");
//                }
//            }
//        }
//    }

//    class Product
//    {
//        public string Code { get; private init; }
//        public string Name { get; set; }
//        public double Price { get; set; }

//        public Product(string code)
//        {
//            ArgumentNullException.ThrowIfNull(code, nameof(code));
//            Code = code;
//        }

//        public Product(string code, string name, double price) : this(code)
//        {
//            Name = name;
//            Price = price;
//        }

//        public override string ToString()
//        {
//            return $"Code: {Code}, Name: {Name}, Price: {Price:0.00}";
//        }
//    }
//}

/////////////////////////////
////////////////////////////
////////////////////////////
/////
//using System.Collections;

//namespace G03_20210221
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            //Hashtable market = new Hashtable();
//            Dictionary<string, Product> market = new Dictionary<string, Product>();

//            Product p1 = new Product("P001", "Apple", 5);
//            market.Add("P001", p1);

//            Product p2 = new Product("P002", "Banana", 20);
//            market.Add(p2.Code, p2);

//            market.Add("P003", new Product("P003", "Orange", 3.5));
//            market.Add("P004", new Product("P004", "Strawberry", 1));
//            market.Add("P005", new Product("P005", "Pear", 7));

//            //tu eseti key aris mashin tavze gadaawers values, tu arada daamatebs.
//            market["P006"] = new Product("P006", "Pineapple", 21);

//            //elementis dzebna da downcasti product - ze
//            while (true)
//            {
//                // klaviaturidan sadziebo kodis sheyvana
//                Console.Write("Enter Code: ");
//                string key = Console.ReadLine().ToUpper();

//                if (key == "EXIT")
//                {
//                    break;
//                }

//                if (market.ContainsKey(key))
//                {
//                    var p = market[key];
//                    Console.WriteLine(p);
//                }
//                else
//                {
//                    Console.WriteLine("Not Found, Try Again");
//                }
//            }
//        }
//    }

//    class Product
//    {
//        public string Code { get; private init; }
//        public string Name { get; set; }
//        public double Price { get; set; }

//        public Product(string code)
//        {
//            ArgumentNullException.ThrowIfNull(code, nameof(code));
//            Code = code;
//        }

//        public Product(string code, string name, double price) : this(code)
//        {
//            Name = name;
//            Price = price;
//        }

//        public override string ToString()
//        {
//            return $"Code: {Code}, Name: {Name}, Price: {Price:0.00}";
//        }
//    }
////}
///////////////////////////
//////////////////////////////////////
////
//////////////////////////////////

//using System.Collections;

//namespace G09_20260501
//{
//    internal class Program
//    {
//        static void Main()
//        {

//        }
//    }

//    public abstract class MyCollection<T> : ICollection<T>
//    {
//        public void Clear()
//        {
//            throw new NotImplementedException();
//        }

//        public bool Contains(T item)
//        {
//            throw new NotImplementedException();
//        }

//        public void CopyTo(T[] array, int arrayIndex)
//        {
//            throw new NotImplementedException();
//        }

//        void ICollection<T>.Add(T item)
//        {
//            throw new NotImplementedException();
//        }

//        bool ICollection<T>.Remove(T item)
//        {
//            throw new NotImplementedException();
//        }

//        public IEnumerator<T> GetEnumerator()
//        {
//            throw new NotImplementedException();
//        }

//        public int Count { get; }

//        public bool IsReadOnly { get; }

//        IEnumerator IEnumerable.GetEnumerator()
//        {
//            return GetEnumerator();
//        }
//    }

//    public class MyList<T> : MyCollection<T>, IList<T>
//    {
//        public void Add(T item)
//        {
//            throw new NotImplementedException();
//        }

//        public bool Remove(T item)
//        {
//            throw new NotImplementedException();
//        }

//        public void Insert(int index, T item)
//        {
//            throw new NotImplementedException();
//        }

//        public void RemoveAt(int index)
//        {
//            throw new NotImplementedException();
//        }

//        public int IndexOf(T item)
//        {
//            throw new NotImplementedException();
//        }

//        public int IndexOf(T item, int startIndex)
//        {
//            throw new NotImplementedException();
//        }

//        public T this[int index]
//        {
//            get => throw new NotImplementedException();
//            set => throw new NotImplementedException();
//        }
//    }

//    public class MyQueue<T> : MyCollection<T>
//    {
//        public void Enqueue(T item)
//        {
//            throw new NotImplementedException();
//        }

//        public T Dequeue()
//        {
//            throw new NotImplementedException();
//        }

//        public T Peek()
//        {
//            throw new NotImplementedException();
//        }
//    }

//    public class MyStack<T> : MyCollection<T>
//    {
//        public void Push(T item)
//        {
//            throw new NotImplementedException();
//        }

//        public T Pop()
//        {
//            throw new NotImplementedException();
//        }

//        public T Peek()
//        {
//            throw new NotImplementedException();
//        }
//    }

//    public class MyEnumerator<T> : IEnumerator<T>
//    {
//        public T Current => throw new NotImplementedException();

//        public bool MoveNext()
//        {
//            throw new NotImplementedException();
//        }

//        public void Reset()
//        {
//            throw new NotImplementedException();
//        }

//        public void Dispose()
//        {
//            // For now leave it blank!
//        }

//        object IEnumerator.Current => Current;
//    }

//    public class MyStackEnumerator<T> : IEnumerator<T>
//    {
//        public T Current => throw new NotImplementedException();

//        public bool MoveNext()
//        {
//            throw new NotImplementedException();
//        }

//        public void Reset()
//        {
//            throw new NotImplementedException();
//        }

//        public void Dispose()
//        {
//            // For now leave it blank!
//        }

//        object IEnumerator.Current => Current;
//    }
//}