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