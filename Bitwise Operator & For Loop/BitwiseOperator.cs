using System;

namespace Bitwise_Operator___For_Loop
{
    class BitwiseOperator
    {
        static void Main(string[] args)
        {
            int a = 4;
            int b = 6;
            int i = 7;
            Console.WriteLine(a & b);
            Console.WriteLine(a | b);
            Console.WriteLine(~a);
            Console.WriteLine(a ^ b);
            Console.WriteLine(17>>1);
            Console.WriteLine(17>>2);
            Console.WriteLine(19<<1);
            Console.WriteLine(21<<2);
            ++i;
            Console.WriteLine(i);
            i++;
            Console.WriteLine(i);
            --i;
            Console.WriteLine(i);
            i--;
            Console.WriteLine(i);
        }
    }
}
