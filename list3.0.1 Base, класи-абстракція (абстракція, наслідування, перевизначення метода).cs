//Base.cs
using System;

namespace ConsoleApplication
{
    abstract class Abstract
    {
        //звичайний метод
        public void SimpleMethod()
        {
            Console.WriteLine("Base-Simple");
        }
		
        //віртуальний метод
        virtual public void VirtualMethod()
        {
            Console.WriteLine("Base-Virtual");
        }

        //абстрактний метод
        abstract public void AbstractMethod();
    }
}
