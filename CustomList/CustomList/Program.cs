namespace CustomList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            Console.WriteLine(list.Count);

            
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
