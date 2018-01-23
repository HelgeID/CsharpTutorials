//інтерфейси, об'єднання однойменних методів
using System;

namespace ConsoleApplication
{
    interface MyI
    {
        void Method();
    }

    class Base
    {
        public void Method()
        {
            Console.WriteLine("Base");
        }
    }

    class Derived : Base, MyI
    {
        //реалізація необов'язкова
        //об'єднання двох методів Method() (з класа та інтерфейса)
    }

    class Program
    {
        static void Main(string[] args)
        {
            Derived ins = new Derived();
            ins.Method();

            MyI ins1 = ins as Derived;
            ins1.Method();

            Console.ReadKey();
        }
    }
}
