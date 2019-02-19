using System;
using System.Diagnostics;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Fibberly Gibbet!");
            if (Debugger.IsAttached)
                Console.ReadKey();
        }
    }
}
