//індексатори (переоприділення)
using System;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Derived insDerived = new Derived();
            Base insBase = insDerived;
            for (int i = 0; i < 3; i++)
                Console.WriteLine(insBase[i]);
            Console.ReadKey();
        }
    }
}
