using System;
using System.Diagnostics;

namespace MS_TDD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            if (Debugger.IsAttached)
                Console.ReadKey();
        }
    }
}
