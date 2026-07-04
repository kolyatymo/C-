using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_practical
{
    internal class MyList<T> : IMyList<T>, IMyCollection<T>, IEnumerable<T>
    {
        T[] stack;
        const int Empty = -1;
        int top = Empty;
        public T this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public MyList(int capacity = 5)
        {
            stack = new T[capacity];

        }
        public int Count => top +1;

        public int Capacity => stack.Length;

        bool Full()
        {
            return top == Capacity - 1;
        }
        public void Add(T element)
        {
            if (Full())
                Array.Resize(ref stack, Capacity * 2);
            stack[++top] = element;   
        }

        public void Clear()
        {
            top = Empty;
        }

        public bool Contains(T item)
        {
            for (int i = 0; i <= top; i++)
            {
                if (stack[i].Equals(item))
                    return true;
            }
            return false;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i <= top; i++)
            {
                yield return stack[i];
            }
        }

        public int IndexOf(T item)
        {
            for (int i = 0; i <= top; i++)
            {
                if (stack[i].Equals(item))
                    return i;

            }
            return -1;
        }

        public void Insert(int index, T item)
        {
            if(index < 0 || index > Count)
                throw new ArgumentOutOfRangeException(" error index");
            if (Full())
                Array.Resize(ref stack, stack.Length * 2);
            for (int i = top; i >= index; i--)
            {
                    stack[i+1] = stack[i];
            }
            stack[index] = item;
            top++;
        }

        public bool Remove(T item)
        {
            if (!stack.Contains(item))
                return false;
            int index = -1;
            for (int i = 0; i <= top; i++)
            {
                if (stack[i].Equals(item))
                {
                    index = i;
                    break;
                }
            }
            for (int j = index; j < top; j++)
            {
                stack[j] = stack[j + 1];
            }
            top--;
            return true;
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index > top)
                throw new IndexOutOfRangeException(" error index");
            if (top == Empty)
                throw new InvalidOperationException("Stack is Empty");
            try
            {
                for (int i = index; i < top; i++)
                {
                    stack[i] = stack[i + 1];
                }
                top--;
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ResetColor();
            }
           
        }

        public int LastIndexOf(T element)
        {
            for (int i = top; i >= 0; i--)
            {
                if (stack[i].Equals(element))
                    return i;
            }
            return -1;
        }
        public List<T> FindAll(Predicate<T> match)
        {
            List<T> list = new List<T>();
            for (int i = 0; i <= top; i++)
            {
                if (match(stack[i]))
                    list.Add(stack[i]);
            }
            return list;
        }
        public T Find(Predicate<T> match)
        {

            for (int i = 0; i <= top; i++)
            {
                if (match(stack[i]))
                    return stack[i];
            }
            throw new InvalidOperationException("Not Found");
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
