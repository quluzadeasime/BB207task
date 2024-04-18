using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class ListMethods<T>
    {
        private T[] items;
        private int count;
        private int Capacity = 4;
        public int capacity
        {
            get { return items.Length; }
        }
        public int Count
        {
            get { return count; }
        }
        public T this[int index]
        {
            get
            {
                return items[index];
            }
        }
        public ListMethods()
        {
            
        }
        public ListMethods(int Count)
        {
            items = new T[Capacity];
            count = 0;
        }
        public void AddMethod(T item)
        {
            if (items == null)
            {
                items = new T[Capacity];
            }
            if (count == items.Length)
            {
                T[] newArray = new T[items.Length * 2];

                for (int i = 0; i < count; i++)
                {
                    newArray[i] = items[i];
                }
                newArray[count] = item;
                items = newArray;
            }
            else
            {
                items[count] = item;
            }
            count++;
        }
        public void RemoveAllMethod(Func<T, bool> predicate)
        {
            for (int i = 0; i < count; i++)
            {
                if (predicate(items[i]))
                {
                    for (int j = i; j < count - 1; j++)
                    {
                        items[j] = items[j + 1];
                    }
                    count--;
                    i--;
                }
            }
        }
        public void RemoveMethod(Func<T,bool> predicate)
        {
            for(int i = 0;i < count; i++)
            {
                if (predicate(items[i]))
                {
                    for (int j = i; j < count - 1; j++)
                    {
                        items[j] = items[j + 1];
                    }
                    count--;
                    break;
                }
            }
        }
        public void ForEachMethod(Action<T> action)
        {
            foreach(var item in items)
            {
                action(item);
            }
        }
        public ListMethods<T> findAll(T findItem)
        {
            if (items == null)
            {
                items = new T[Capacity];
            }
            ListMethods<T> list = new ListMethods<T>();
            foreach(T item in items)
            {
                if (item.Equals(findItem))
                {
                    list.AddMethod(findItem);
                }
            }
            return list;
        }
        public ListMethods<T> findMethod(T findItem)
        {
            if (items == null)
            {
                items = new T[Capacity];
            }
            ListMethods<T> list = new ListMethods<T>();
            foreach (T item in items)
            {
                if (item.Equals(findItem))
                {
                    list.AddMethod(findItem);
                    break;
                }
            }
            return list;
        }

        public ListMethods<T> ReverseMethod()
        {
            ListMethods<T> reverseList = new ListMethods<T>();
            for (int i = count - 1; i >= 0; i--)
            {
                reverseList.AddMethod(items[i]);
            }
            return reverseList;
        }

        public void ClearMethod()
        {
            items = new T[Capacity];
            count = 0;
        }

    }
}
