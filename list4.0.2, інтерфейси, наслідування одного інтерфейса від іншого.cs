//інтерфейси, наслідування одного інтерфейса від іншого
using System;

namespace ConsoleApplication
{
    //вузький інтерфейс
    interface MyI1
    {
        void Method1();
    }

    //широкий інтерфейс
    interface MyI2 : MyI1
    {
        void Method2();
    }

    class MyClass: MyI2
    {
        public void Method1()
        {
            Console.WriteLine("interface 1");
        }

        public void Method2()
        {
            Console.WriteLine("interface 2");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass ins = new MyClass();
            ins.Method1();
            ins.Method2();

            MyI1 ins1 = ins as MyI1;
            ins1.Method1();

            MyI2 ins2 = ins as MyI2;
            ins2.Method1();
            ins2.Method2();

            Console.ReadKey();
        }
    }
}
