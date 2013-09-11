// Task 2: Write a program to convert binary numbers to their decimal representation.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class BinaryToDecimal
{
    static void Main(string[] args)
    {
        String str = Console.ReadLine();
        ulong sum = 0;
        for (int i = 0; i < str.Length; i++)
        {
            sum += ulong.Parse(str[i].ToString()) * (ulong)(Math.Pow(2, str.Length - (i + 1)));
        }
        Console.WriteLine(sum);
    }
}