using System.Collections.Generic;

namespace CustomList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListMethods<int> listMethod = new ListMethods<int>();
            listMethod.AddMethod(3);
            listMethod.AddMethod(4);
            listMethod.AddMethod(4);
            listMethod.AddMethod(6);
            listMethod.AddMethod(7);
            listMethod.AddMethod(9);
            listMethod.AddMethod(10);
            listMethod.AddMethod(11);
            listMethod.AddMethod(12);
            //Console.WriteLine(listMethod.Count);
           
            //Console.WriteLine(listMethod.capacity);

            Func<int, bool> tekEded = item => item % 2 == 1;
            listMethod.RemoveAllMethod(tekEded);
            //listMethod.ClearMethod();
            for (int i = 0; i < listMethod.Count; i++)
            {
                Console.WriteLine(listMethod[i]);
            }
            Console.WriteLine(listMethod.capacity);
            //listMethod.ForEachMethod(item => Console.WriteLine(item));

            //ListMethods<int> newList = listMethod.findAll(tekEded);
            //ListMethods<int> newList = listMethod.findAll(x => x % 2 == 0);
            //ListMethods<int> newList = listMethod.findMethod(4);
            //for (int i = 0; i < newList.Count; i++)
            //{
            //    Console.WriteLine(newList[i]);
            //}

            //ListMethods<int> reverseSrt = listMethod.ReverseMethod();
            //for (int i = 0; i < reverseSrt.Count; i++)
            //{
            //    Console.WriteLine(reverseSrt[i]);
            //}

            //listMethod.ClearMethod();
            //for (int i = 0; i < listMethod.Count; i++)
            //{
            //    Console.WriteLine(listMethod[i]);
            //}
        }
    }
}
