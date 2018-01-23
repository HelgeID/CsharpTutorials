//інтерфейси, реалізація інтерфейсів
using System;

namespace ConsoleApplication
{
    interface MyI1
    {
        void Method();
    }

    interface MyI2
    {
        void Method();
    }

    //реалізація інтерфейса MyI1
    abstract class Abstract1 : MyI1
    {
        //реалізація абстрактного метода із інтерфейса
        public void Method()
        {
            Console.WriteLine("realization in Abstract class");
        }
    }

    class MyClass1 : Abstract1
    {
    }

    //реалізація інтерфейса MyI2
    abstract class Abstract2 : MyI2
    {
        //заміщення абстрактного метода із інтерфейса
        public abstract void Method();
    }

    class MyClass2: Abstract2
    {
        //реалізація абстрактного метода із абстрактного класа
        public override void Method()
        {
            Console.WriteLine("realization in Concrete class");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass1 obj1 = new MyClass1();
            obj1.Method();//realization in Abstract class

            MyClass2 obj2 = new MyClass2();
            obj2.Method();//realization in Concrete class

            Console.ReadKey();
        }
    }
}
