using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjInventoryManagement
{
    //Custom Types
    public class Product//Class that holds the attributes for the class
    {
        public int ID { get; set; }//(Wagner, 2025)

        public string Name { get; set; }//(Wagner, 2025)

        public int Quantity { get; set; }//(Wagner, 2025)

        public double Price { get; set; }//(Wagner, 2025)
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