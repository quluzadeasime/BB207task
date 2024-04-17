using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T>
    {
        private T[] items;
        private int count;

        public CustomList()
        {
            items = new T[10];
            count = 0;
        }

        public void AddMethod(T item)
        {
            if(count ==  items.Length)
            {
                T[] newArray = new T[count + 1];

                for(int i = 0; i < count; i++)
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
    }


}
