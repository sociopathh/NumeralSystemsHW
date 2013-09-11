/* Task 3: Write a program to convert decimal numbers to their hexadecimal representation.*/
using System;
using System.Linq;

public class DecimalToHex
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter number:");
        int inputNum = int.Parse(Console.ReadLine());


        DecimalToHex(inputNum);
    }

    public static void DecimalToHex(int inputNum)
    {
        string result = string.Empty;
        while (inputNum > 0)
        {
            int remainder = inputNum % 16;
            switch (remainder)
            {
                case 10: result = "A" + result;
                    break;
                case 11: result = "B" + result;
                    break;
                case 12: result = "C" + result;
                    break;
                case 13: result = "D" + result;
                    break;
                case 14: result = "E" + result;
                    break;
                case 15: result = "F" + result;
                    break;
                default: result = (inputNum % 16) + result;
                    break;
            }
            inputNum /= 16;
        }

        Console.WriteLine(result);
    }
}