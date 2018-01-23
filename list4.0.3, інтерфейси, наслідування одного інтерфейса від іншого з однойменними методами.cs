//інтерфейси, наслідування одного інтерфейса від іншого з однойменними методами
using System;

namespace ConsoleApplication
{
    interface MyI1
    {
        void Method();
    }

    interface MyI2 : MyI1
    {
        new void Method();//без new буде попередження компілятора
    }

    class MyClass: MyI2
    {
		//реалізація методів інтерфейса (техніка явного вказання імені інтерфейса)
        void MyI1.Method()
        {
            Console.WriteLine("interface 1");
        }

        void MyI2.Method()
        {
            Console.WriteLine("interface 2");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass ins = new MyClass();
            //ins.Method();//error

            MyI1 ins1 = ins as MyI1;
            ins1.Method();//interface 1

            MyI2 ins2 = ins as MyI2;
            ins2.Method();//interface 2

            Console.ReadKey();
        }
    }
}
