//Program.cs

//інтерфейси, множинне наслідування від одного класа та декількох інтерфейсів
using System;

namespace ConsoleApplication
{
    class Derived : Base, Interface1, Interface2
    {
        //реалізація метода Show1(), Interface1
        public void Show1()
        {
            Console.WriteLine("use Interface1");
        }

        //реалізація метода Show2(), Interface2
        public void Show2()
        {
            Console.WriteLine("use Interface2");
        }

        //реалізація однойменного метода Show()
        void Interface1.Show()
        {
            Console.WriteLine("use Interface1");
        }

        void Interface2.Show()
        {
            Console.WriteLine("use Interface2");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Interface1 obj1 = new Derived();//використовується інкапсуляція (метод Show2() не бачить)
            Interface2 obj2 = new Derived();//використовується інкапсуляція (метод Show1() не бачить)

            //obj1
            obj1.Show1();//use Interface1
            //obj1.Show2();//error

            //obj2
            //obj2.Show1();//error
            obj2.Show2();//use Interface2

            Console.WriteLine(new string('-', 20));

            //////////////////////////////////////////////////
            Derived ins = new Derived();
            ins.Show();//use Base
            ins.Show1();//use Interface1
            ins.Show2();//use Interface2
            Console.WriteLine(new string('-', 20));

            //////////////////////////////////////////////////
            Base ins0 = ins as Base;
            ins0.Show();//use Base

            Interface1 ins1 = ins as Interface1;
            ins1.Show();//use Interface1
            ins1.Show1();//use Interface1

            Interface2 ins2 = ins as Interface2;
            ins2.Show();//use Interface2
            ins2.Show2();//use Interface2

            Console.ReadKey();
        }
    }
}
