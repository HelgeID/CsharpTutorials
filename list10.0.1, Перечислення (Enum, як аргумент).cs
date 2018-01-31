//перечислення (Enum, як аргумент)
using System;

namespace ConsoleApplication
{
    enum EnumType
    {
        Zero, // = 0
        One,  // = 1
        one = One,
        Two = 2,
        Three,// = 3
        Four, // = 4
        Five = 5,
        Six = Nine,
        //Seven         //якщо забрати коментар то "Seven = 10", бо "Six = Nine"
        Eight = 8,      //якщо не вказати явно, то на "Six = Nine" буде помилка
        Nine,
        Ten = 10,
        inf = 255
    }

    class Program
    {
        public static void MyMethod(EnumType e)
        {
            switch (e)
            {
                case EnumType.Zero:
                    Console.WriteLine(0); break;
                case EnumType.Two:
                    Console.WriteLine(2); break;
                case EnumType.Five:
                    Console.WriteLine(5); break;
                case EnumType.Ten:
                    Console.WriteLine(10); break;
                default: break;
            }
        }

        static void Main()
        {
            MyMethod(EnumType.Five);//5

            EnumType digit = EnumType.Ten;
            MyMethod(digit);//10

            int d = (int)(++digit);
            Console.WriteLine(d);//11

            Console.WriteLine(digit);//11  (змінна змінилася)
            Console.WriteLine((int)EnumType.Ten);//10  (константа не змінилася)
            Console.ReadKey();
        }
    }
}
