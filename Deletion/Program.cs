using System;

class Program {
    static void Main() {
        int[] numbers = { 10, 20, 30, 40, 50 };

        // Delete the element at index 2
        int deleteIndex = 2;
        int[] newArray = new int[numbers.Length - 1];

        for (int i = 0, j = 0; i < numbers.Length; i++) {
            if (i == deleteIndex) continue;
            newArray[j++] = numbers[i];
        }

        Console.WriteLine("Array after deletion:");
        foreach (int num in newArray) {
            Console.WriteLine(num);
        }
    }
}