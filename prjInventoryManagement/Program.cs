using System;
using System.Collections.Generic;
using System.Linq;

namespace prjInventoryManagement
{
    unsafe class Program// (Wagner & Kotas, 2025) 
    {
        static void Main(string[] args)
        {
            var prod = new List<Product>() // List of different Items
            {
                new Product { ID = 1, Name = "Powerade", Quantity = 100, Price = 18.99 },
                new Product { ID = 2, Name = "Bar-One", Quantity = 90, Price = 15.90 },
                new Product { ID = 3, Name = "Lunch Bar", Quantity = 60, Price = 60.00 },
                new Product { ID = 4, Name = "Coca Cola", Quantity = 22, Price = 20.00 },
                new Product { ID = 5, Name = "Chicken Mayo Sandwich", Quantity = 15, Price = 25.00 },
                new Product { ID = 6, Name = "Red Bull", Quantity = 80, Price = 24.00 }
            };

            // Call FilterStock and get the count of low stock items
            var lowStock = prod.FilterStock();
            Console.WriteLine($"Total low stock items: {lowStock.Count}");
            Console.WriteLine();

            // Calculate total value
            double sum = prod.TotalPrice();
            Console.WriteLine($"Total Value: R{sum}");
            Console.WriteLine();

            // Pointer example: Show memory address and value of Quantity of first product
            int qty = prod[0].Quantity;// (Wagner & Kotas, 2025) 
            int* ptr = &qty;// (Wagner & Kotas, 2025) 

            Console.WriteLine($"Pointer demo for Quantity of {prod[0].Name}:");// (Wagner & Kotas, 2025) 
            Console.WriteLine($"Address: {(ulong)ptr:X} | Value: {*ptr}");// (Wagner & Kotas, 2025) 

            Console.ReadKey();
        }
    }

    // Extension methods
    public static class TotalValueHelper//(Wagner, 2025) 
    {
        // Calculates total value of all products
        public static double TotalPrice(this List<Product> prod)//(Wagner, 2025) 
        {
            return prod.Sum(x => x.Price * x.Quantity);// (Wagner, 2025)
        }

        // Filters and prints low stock items
        public static List<Product> FilterStock(this List<Product> prod)//(Wagner, 2025) 
        {
            var lowStock = prod.Where(p => p.Quantity < 25).ToList(); // (Wagner, 2025)

            Console.WriteLine("Low stock items:");
            foreach (var item in lowStock)
            {
                Console.WriteLine($"{item.Name} - Qty: {item.Quantity}");
                                
            }
            return lowStock;
        }
    }
}

/*
Reference List

Spain, C., 2025. Overview of object oriented techniques in C#. [Online] 
Available at: https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/object-oriented/
[Accessed 11 August 2025].
Wagner, B., 2025. Anonymous types. [Online] 
Available at: https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/types/anonymous-types
[Accessed 11 August 2025].
Wagner, B., 2025. Extension members (C# Programming Guide). [Online] 
Available at: https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[Accessed 11 August 2025].
Wagner, B., 2025. Language Integrated Query (LINQ). [Online] 
Available at: https://learn.microsoft.com/en-us/dotnet/csharp/linq/
[Accessed 11 August 2025].
Wagner, B. & Kotas, J., 2025. Unsafe code, pointer types, and function pointers. [Online] 
Available at: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/unsafe-code#pointer-types
[Accessed 11 August 2025].



*/


