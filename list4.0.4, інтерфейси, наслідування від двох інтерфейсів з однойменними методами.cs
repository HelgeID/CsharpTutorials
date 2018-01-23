//інтерфейси, наслідування від двох інтерфейсів з однойменними методами
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

    class MyClass : MyI1, MyI2
    {
        //реалізація методів інтерфейса (техніка об'єднання реалізації однойменних абстрактних членів)
        public void Method()
        {
            Console.WriteLine("interface 1 && interface 2");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass ins = new MyClass();
            ins.Method();

            MyI1 ins1 = ins as MyI1;
            ins1.Method();

            MyI2 ins2 = ins as MyI2;
            ins2.Method();

            Console.ReadKey();
        }
    }
}
