using System;

class IntStack
{
    //member variables
    private int maxsize = 10; 
    private int top = -1;
    private int[] data;

    public IntStack()
    {
        data = new int[maxsize];
    }

    // methods
    public void Push(int value)
    {
        if (IsFull())
        {
            Console.WriteLine("Stack is full");
            return;
        }
        top++;
        data[top] = value;
    }

    public int Pop()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Stack is empty");
            return 0;
        }
        return data[top--];
    }

    public int Peek()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Stack is empty");
            return 0;
        }
        return data[top];
    }

    public bool IsEmpty()
    {
        return top == -1;
    }

    public bool IsFull()
    {
        return top == (maxsize - 1);
    }

}


// Example usage
class Program
{
    static void Main()
    {
        IntStack stack = new IntStack();

        stack.Push(10);
        stack.Push(20);
        stack.Push(30);

        Console.WriteLine($"Peek: {stack.Peek()}"); // Output: 30
        stack.Pop();
        Console.WriteLine($"Peek: {stack.Peek()}"); // Output: 20

        while (!stack.IsEmpty())
        {
            stack.Pop();
        }

        stack.Pop(); // Attempt to pop from an empty stack
        stack.Push(100);
        Console.WriteLine($"Peek: {stack.Peek()}"); // Output: 100
    }
}
