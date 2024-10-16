using System;

public class Program
{
    public static void Main(string[] args)
    {

        Write1ThroughN_While(-6);
        Write1ThroughN_For(5);
        WriteNThrough1_While(5);
        WriteNThrough1_For(5);
        WriteEvensThrough100();
        FindSum(5);
        FindSumOfEvenNumbers(6);
        FindSumOfOddNumbers(5);
        OutputRightTriangle(6);
        OutputRightTriangle(-6);
    }

    public static void OutOfRangeMessage(int n)
    {
        if (n == 1)
        {
            Console.WriteLine("Number is out of range");
        }
    }

    public static void Write1ThroughN_While(int n)
    {
        int i = 1;
        while (i <= n)
        {
            Console.WriteLine(i);
            i++;
        }
        if (n < i)
        {
            OutOfRangeMessage(1);
        }
    }

    public static void Write1ThroughN_For(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(i);
        }
        if (n < 1)
        {
            OutOfRangeMessage(1);
        }
    }

    public static void WriteNThrough1_While(int n)
    {
        if (n < 1)
        {
            OutOfRangeMessage(1);
        }
        int i = 1;
        while (n >= i)
        {
            Console.WriteLine(n);
            n--;
        }
    }

    public static void WriteNThrough1_For(int n)
    {
        if (n < 1)
        {
            OutOfRangeMessage(1);
        }

        for (int i = 1; n >= i; n--)
        {
            Console.WriteLine(n);
        }
    }

    public static void WriteEvensThrough100()
    {
        for (int i = 0; i <= 100; i += 2)
        {
            Console.WriteLine(i);
        }
    }

    public static void FindSum(int n)
    {
        int result = 0;
        for (int i = 1; i <= n; i += 1)
        {
            result = result + i;
        }

        if (n == 0)
        {
            result = 0;
        }

        Console.WriteLine(result);
    }

    public static void FindSumOfEvenNumbers(int n)
    {
        int result = 0;
        for (int i = 2; i <= n; i += 2)
        {
            result = result + i;
        }
        if (n == 0)
        {
            result = 0;
        }
        Console.WriteLine(result);
    }

    public static void FindSumOfOddNumbers(int n)
    {
        int result = 0;
        for (int i = 1; i <= n; i += 2)
        {
            result = result + i;
        }
        if (n == 0)
        {
            result = 0;
        }
        Console.WriteLine(result);
    }

    public static void OutputRightTriangle(int _base)
    {
        for (int i = 1; i <= _base; i++)
        {
            for (int o = 1; o <= i; o++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        for (int i = _base; i <= 1; i++)
        {
            for (int o = -1; o >= i; o--)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}