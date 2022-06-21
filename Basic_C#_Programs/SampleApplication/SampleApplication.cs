// System is the main namespace of the Base Class library of code that provides the most basic rfunctionality of the C# language.
using System;

// This is a class declaration
class SampleApplication {
    // "static" in the line below tells the compiler that this function can be called without relying on reference to an object
    // "void" in the line below tells the compiler that this function will not return a value. Instead, it is just going to perform an action (i.g. printing words to the console)
    // Main() is a function that tells the compiler to execute anything between the braces. In a console application, a function with the name Main() is automatically executed as the first step in running the program
    static void Main()
    {
        Console.WriteLine("Hello, World");
    }
}