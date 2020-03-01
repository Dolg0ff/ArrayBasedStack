using System;

namespace ArrayBasedStack
{
    public class Stack<T>
    {
        private T[] items;
        private int count;
        const int n = 10;

        public Stack()
        {
            items = new T[n];
        }

        public Stack(int lenght)
        {
            items = new T[lenght];
        }

        public void Push(T item)
        {
            if(count == items.Length)
            {
                throw new InvalidOperationException("Список заполнен");
            }
            else
            {
                items[count++] = item;
            }

        }

        public T Pop()
        {
            if(count == 0)
            {
                throw new InvalidOperationException("Список пуст");
            }
            T item = items[--count];
            items[count] = default(T);
            return item;
        }

        public T Peek()
        {
            return items[count - 1];
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>();
            stack.Push("Apple");
            stack.Push("Samsung");
            stack.Push("Nokia");
            stack.Push("LG");
            stack.Pop();
            stack.Pop();

            var head = stack.Peek();
            Console.WriteLine(head);


            Console.ReadLine();
        }
    }
}
