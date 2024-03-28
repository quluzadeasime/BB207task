using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationTask
{
    internal class Book:Product 
    {
        public string Genre;

        public Book(string no,string name, double _price, int _count,string genre):base(no,name)
        {
            Genre = genre;
            Price = _price;
            Count = _count;
        }

        public void Showinfo()
        {
            Console.WriteLine($"No: {No}\nName: {Name}\nGenre: {Genre}\nPrice: {Price}\nCount: {Count}");
        }


        
    }
    
}
