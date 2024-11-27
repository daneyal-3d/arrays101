using System;

class Program {
    static void Main() {
        int[] numbers = { 10, 20, 30, 40, 50 };

        Console.WriteLine("Array elements:");
        for (int i = 0; i < numbers.Length; i++) {
            Console.WriteLine(i);
            Console.WriteLine(numbers[i]);
        }

        // Using foreach
        Console.WriteLine("Using foreach loop:");
        foreach (int num in numbers) {
            Console.WriteLine(num);
        }
    }
}

// Difference b/w i++ and ++i.
