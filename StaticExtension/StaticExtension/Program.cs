namespace StaticExtension
{
    internal class Program
    {
        static Person person;
        static Product product;
        static Store store;
        static void Main(string[] args)
        {
            store = new Store();
            int choice;
            bool running = true;
            do
            {
                Console.WriteLine("************Menu*******");
                Console.WriteLine("1.Add product");
                Console.WriteLine("2.Remove product");
                Console.WriteLine("3.Show product by no");
                Console.WriteLine("4.Show product by type");
                Console.WriteLine("5.Show product by name");
                Console.WriteLine("6.Show all product");
                Console.WriteLine("0.Exit");
                Console.WriteLine("***********************");

                do
                {
                    Console.Write("Enter your choice: ");
                } while (!int.TryParse(Console.ReadLine(), out choice));
                

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("**********************");
                        Console.WriteLine("Enter product information:");
                        Console.Write("Enter name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter type: ");
                        string type = Console.ReadLine();
                        double price;
                        do
                        {
                            Console.Write("Enter price: ");
                        } while (!double.TryParse(Console.ReadLine(), out price) || price <= 0);
                        int count;
                        do
                        {
                            Console.Write("Enter count: ");
                        } while (!int.TryParse(Console.ReadLine(), out count) || count <= 0);
                        Product newProduct = new Product(name, price, type, count);
                        store.AddProduct(newProduct);
                        Console.WriteLine("Product added :)");

                        break;
                    case 2:
                        int productNo;
                        do
                        {
                            Console.Write("Enter product no to remove: ");
                        } while (!int.TryParse(Console.ReadLine(), out productNo) || productNo <= 0);
                        store.RemoveProductByNo(productNo);
                        Console.WriteLine("Product removed");
                        break;
                    case 3:
                        int getNo;
                        do
                        {
                            Console.Write("Enter product number to see: ");
                        } while (!int.TryParse(Console.ReadLine(), out getNo) || getNo <= 0);
                        Product product = store.GetProduct(getNo);
                        if (product == null)
                        {
                            Console.WriteLine("Product not found!");
                        }
                        else Console.WriteLine(product);
                        break;
                    case 4:
                        Console.Write("Enter product type to see:");
                        string getType = Console.ReadLine();
                        Product[] getFilteredType = store.FilterProductsByType(getType);
                        foreach (Product prod in getFilteredType)
                        {
                            Console.WriteLine(prod);
                        }
                        break;
                    case 5:
                        Console.Write("Enter product name to see: ");
                        string getName = Console.ReadLine();
                        Product[] getFilteredName = store.FilterProductByName(getName);
                        foreach (Product pro in getFilteredName)
                        {
                            Console.WriteLine(pro);
                        }
                        break;
                    case 6:
                        Console.WriteLine("All products information: ");
                        Console.WriteLine("Name  |  Price  |  Type  |  Count | No");
                        var allProducts = store.ShowAllProduct();
                        for(int i = 0; i< allProducts.Length; i++)
                        {
                            Console.WriteLine($"{allProducts[i].Name} | {allProducts[i].Price} | {allProducts[i].Type}           | {allProducts[i].Count}       | {allProducts[i].No}");
                        }
                        Console.WriteLine();
                        break;
                    case 0:
                        Console.WriteLine("Exiting...");
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice, you should be enter a number between 0 and 6!");
                        break;
                }

            } while (running);
            Console.WriteLine("Program has been stopped!");
            Console.WriteLine("************************");
        }
    }
}