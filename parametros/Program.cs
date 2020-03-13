using System;

namespace parametros
{
    class bisi
    {
        public static void bici(ref int a)
        {
            a++;
        }
        public static void birria(in int a,in int b, out int res)
        {
            res = a + b;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            int x = 3;
            int y = 2;
            int res = 0;
            
            bisi.bici(ref x);
            bisi.birria(in x, in y, out res);
            Console.WriteLine(x);
            Console.WriteLine(res);
        }
    }
}
