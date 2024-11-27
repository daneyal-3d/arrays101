using System;

class Program {
    static void Main() {
        // Declare and initialize an array
        int[] numbers = { 10, 20, 30, 40, 50 };

        // Access elements
        Console.WriteLine("First element: " + numbers[0]); // Output: 10
        Console.WriteLine("Size of Array: " + numbers.Length); // Output: 05
        Console.WriteLine("Last element: " + numbers[numbers.Length - 1]); // Output: 50
    }
}