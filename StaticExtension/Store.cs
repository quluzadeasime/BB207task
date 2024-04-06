using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExtension
{
    internal class Store
    {
        public static int _id = 0;
        public int Id { get; }
        private Product[] Products;

        public Store()
        {
            _id++;
            Id = _id;
            Products = new Product[0];
        }
        public void AddProduct(Product product)
        {
            Array.Resize(ref Products, Products.Length + 1);
            Products[Products.Length - 1] = product;
        }

        public Product GetProduct(int no)
        {
            foreach (Product product in Products)
            {
                if (product.No == no)
                {
                    return product;
                }
            }
            Console.WriteLine("Product not found");
            return null;
        }

        public Product[] FilterProductsByType(string type)
        {
            Product[] productsByType = new Product[0];
            foreach (Product product in Products)
            {
                if (product.Type == type)
                {
                    Array.Resize(ref productsByType, productsByType.Length + 1);
                    productsByType[productsByType.Length - 1] = product;
                }
            }
            if (productsByType.Length == 0)
            {
                Console.WriteLine("Product not found!");
            }
            return productsByType;
        }

        public Product[] FilterProductByName(string name)
        {
            Product[] productsByName = new Product[0];
            foreach (Product product in Products)
            {
                if (product.Name == name)
                {
                    Array.Resize(ref productsByName, productsByName.Length + 1);
                    productsByName[productsByName.Length - 1] = product;
                }
            }
            if (productsByName.Length == 0)
            {
                Console.WriteLine("Product not found!");
            }
            return productsByName;
        }

        public void RemoveProductByNo(int no)
        {
            for (int i = 0; i < Products.Length; i++)
            {
                if (Products[i].No == no)
                {
                    Array.Copy(Products, i + 1, Products, i, Products.Length - i - 1);
                    Array.Resize(ref Products, Products.Length - 1);
                    break;
                }
            }
        }
        public  Product[] ShowAllProduct()
        {
            return Products;
        }
        public void Sale(int no, Person person)
        {
            Product product = GetProduct(no);
            if (product.Count > 0 && person.Cash >= product.Price && product != null)
            {
                product.Count--;
                person.Cash = person.Cash - product.Price;
            }
            else
            {
                Console.WriteLine("Product not found!");
            }
        }
    }
}
