//Task 1: Write a program that converts decimal numbers to their binary representation.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numeral_Systems
{
    class DecimalToBinary
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number:");
            int decNum = int.Parse(Console.ReadLine());
            int temp = decNum;
            string binNum = null;
            if (decNum >= 0)
            {
                do
                {
                    binNum = temp % 2 + binNum;
                    temp = temp / 2;
                }
                while (temp != 0);

                Console.WriteLine("Number {0} in binary system is {1}", decNum, binNum);
            }
            else
            {
                Console.WriteLine("You must enter positive number!");
            }
        }
    }
}