//класи-абстракція (абстракція, наслідування, перевизначення метода)
using System;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Derived obj = new Derived();
            obj.SimpleMethod();//Base-Simple
            obj.VirtualMethod();//Derived-Virtual
            obj.AbstractMethod();//Derived-Abstract

            Console.ReadKey();
        }
    }
}
