using System;
using System.Runtime.InteropServices;

namespace ConsoleApp
{
    class Program
    {
        [DllImport("NativeLibrary.dll", EntryPoint = "add", CallingConvention = CallingConvention.StdCall)]
        public static extern int Add(int a, int b);

        [DllImport("NativeLibrary.dll", EntryPoint = "write_line", CallingConvention = CallingConvention.StdCall)]
        public static extern void WriteLine(string text);

        [DllImport("NativeLibrary.dll", EntryPoint = "factorial", CallingConvention = CallingConvention.StdCall)]
        public static extern int Factorial(int n);

        static void Main(string[] args)
        {
            var result = Add(1, 2);
            WriteLine(result.ToString());
            WriteLine("Hello World!");

            result = Factorial(5);
            WriteLine(result.ToString());
        }
    }
}
