using System;
using Extension_Methods.Extensions;

namespace Extension_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2021, 05, 24, 16, 50, 45);
            Console.WriteLine(dt.ElapsedTime());
        }
    }
}
