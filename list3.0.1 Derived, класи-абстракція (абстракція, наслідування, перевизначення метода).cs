//Derived.cs
using System;

namespace ConsoleApplication
{
    class Derived: Abstract
    {
        //перевизначення віртуального метода
        public override void VirtualMethod()
        {
            Console.WriteLine("Derived-Virtual");
        }

        //реалізація абстрактного метода
        public override void AbstractMethod()
        {
            Console.WriteLine("Derived-Abstract");
        }
    }
}
