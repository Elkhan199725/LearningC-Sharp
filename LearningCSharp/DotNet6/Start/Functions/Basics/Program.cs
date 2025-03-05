using System;

// Functions are used to group re-usable code together in a single
// unit that can be customized with parameters.

// TODO: Functions have a return type, name, and optional parameters
float MilesToKilometers(float miles)
{
    return miles * 1.60934f;
}

// TODO: A function with no return value has a 'void' type
void PrintMessage(string message)
{
    Console.WriteLine(message);
}

// TODO: Call first function
Console.WriteLine("Enter miles to convert to kilometers:");
float miles = float.Parse(Console.ReadLine());
float kilometers = MilesToKilometers(miles);
Console.WriteLine($"{miles} miles is {kilometers} kilometers");

// TODO: Call second function
PrintMessage("Hello, World!");
PrintMessage("Goodbye, World!");
