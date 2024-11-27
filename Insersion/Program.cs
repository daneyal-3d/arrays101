using System;

class Program {
    static void Main() {
        int[] numbers = { 10, 20, 30, 40 };

        // Insert 25 at position 2
        int newElement = 25;
        int position = 2;
        int[] newArray = new int[numbers.Length + 1];

        for (int i = 0, j = 0; i < newArray.Length; i++) {
            if (i == position) {
                newArray[i] = newElement;
            } else {
                newArray[i] = numbers[j];
                j++;

            }
        }

        Console.WriteLine("Array after insertion:");
        foreach (int num in newArray) {
            Console.WriteLine(num);
        }
    }
}