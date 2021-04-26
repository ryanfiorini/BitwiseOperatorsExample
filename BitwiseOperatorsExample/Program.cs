using System;

namespace BitwiseOperatorsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start");

            int x = 5, y = 10, result;
            result = x & y;
            Console.WriteLine("Bitwise AND: " + result);
            result = x | y;
            Console.WriteLine("Bitwise OR: " + result);
            result = x ^ y;
            Console.WriteLine("Bitwise XOR: " + result);
            result = ~x;
            Console.WriteLine("Bitwise Complement: " + result);
            result = x << 2;
            Console.WriteLine("Bitwise Left Shift: " + result);
            result = x >> 2;
            Console.WriteLine("Bitwise Right Shift: " + result);

            Console.WriteLine("End");

        }
    }
}
