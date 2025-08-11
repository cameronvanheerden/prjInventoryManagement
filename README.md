# InventoryManagement

## Overview

This C# console application simulates a simple **inventory management system**. It demonstrates the use of:

- Custom types (a `Product` class)
- Extension methods to calculate total inventory value and filter low stock items
- LINQ queries with anonymous types to display product summaries
- Unsafe code with pointer types for educational purposes

This project is designed to reinforce key C# concepts and requires some research and referencing. All code and examples follow academic conventions with citations where applicable.

---

## Features

### Custom Type

A `Product` class is used to represent each item with the following properties:

- `ID` (int)
- `Name` (string)
- `Quantity` (int)
- `Price` (double)

### Extension Methods

Two extension methods were added to `List<Product>`:

1. `TotalPrice()` – Calculates the total value of all products in inventory.  
2. `FilterStock()` – Filters and displays products with low stock (quantity < 25).

### LINQ and Anonymous Types

A LINQ query selects the product name and price into an **anonymous type** for a clean summary:

### Unsafe Code and Pointer Types

A demonstration of C# pointer types is included:

int qty = prod[0].Quantity;
int* ptr = &qty;
Console.WriteLine($"Address: {(ulong)ptr:X} | Value: {*ptr}");

### Screenshot of Output 
![Screenshot of Output](https://github.com/user-attachments/assets/57713de3-3d5e-426d-8ba2-47f47e06d3de)

### Video of Code 
Video includes All my Methods and My Reference List 
https://youtu.be/4L4neZHwRLk

### About Pointer Types in C#

In C#, pointer types are used to store the memory address of another variable, similar to how they work in languages like C or C++. They are typically used in scenarios requiring direct memory access, such as high-performance applications or interop with unmanaged code. Because pointers can bypass C#’s type safety and memory protection, they must be used inside an unsafe context and the project must allow unsafe compilation. This design helps prevent common bugs and security issues.

Reference List:
Microsoft Learn. Pointer types (C# Programming Guide). Retrieved from: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/unsafe-code
