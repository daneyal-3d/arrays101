using System;

class Program {
    static void Main() {
        int[] numbers = { 10, 20, 30, 40, 50 };
        int target = 30;
        bool found = false;

        for (int i = 0; i < numbers.Length; i++) {
            if (numbers[i] == target) {
                Console.WriteLine($"Element {target} found at index {i}");
                found = true;
                break;
            }
        }

        if (!found) {
            Console.WriteLine($"Element {target} not found");
        }
    }
}