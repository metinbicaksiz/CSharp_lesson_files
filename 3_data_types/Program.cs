/* C# Data types

 Value types and reference types
 Value types are stored in the stack, reference types are stored in the heap.
    Reference types are accessed via a reference (pointer) to the actual data in the heap.
    Reference types include classes, arrays, delegates, and strings.
    Value types include:
    - Integral types: byte, sbyte, short, ushort, int, uint, long, ulong
    - Floating-point types: float, double, decimal
    - Other types: char, bool, struct, enum
    - Nullable types: can hold a value or null, defined as Nullable<T> or T? where T is a value type.

*/

// int sayi = 10; // int is a value type
// float ondalikliSayi = 10.5f; // float is a value type
// char karakter = 'A'; // char is a value type
// bool dogruMu = true; // bool is a value type
// string metin = "Merhaba"; // string is a reference type
// int[] sayiDizisi = new int[5]; // array is a reference type


/*
 Why do we convert value types to reference types? 
    Value types are stored in the stack, which is faster for access, but they have a limited size and scope. 
*/

// Console.Write("Sayi 1: ");
// int sayi1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Sayi 2: ");
// int sayi2 = Convert.ToInt32(Console.ReadLine());

// int toplam =  sayi1 + sayi2;

// Console.WriteLine("Toplam: " + toplam);