//розширяющі методи
    static class MyClass
    {
        //this - повідомляє компілятору, що метод є розширяющий
        public static void MyMethod(this string value)
        {
            Console.WriteLine(value);
        }
    }

...
string str = "Hello, World!";
//v1
MyClass.MyMethod(str);//виклик метода, як статичний
//v2
str.MyMethod();//виклик метода, як розширяющий



//аргументи розширяющих методів
    static class MyClass
    {
        public static void MyMethod(this string value1, string value2)
        {
            Console.WriteLine(value1);
            Console.WriteLine(value2);
        }
    }

...
string str = "stroka1";
str.MyMethod("stroka2");



//перегрузка розширяющих методів
    static class MyClass
    {
        public static void MyMethod(this string value)
        {
            Console.WriteLine(value);
        }

        public static void MyMethod(this string value1, string value2)
        {
            Console.WriteLine(value1 + value2);
        }

        public static void MyMethod(this int value)
        {
            Console.WriteLine(value);
        }
    }

...
string text = "Hello,";
text.MyMethod(" World!");//Hello, World!

"Hello,".MyMethod(" World!");//Hello, World!

100.MyMethod();//100



//рекурсія розширяющих методів
    static class MyClass
    {
        public static void MyMethod(this string value, int counter)
        {
            counter--;
            Console.WriteLine("in  " + value + counter);

            if (counter != 0)
                value.MyMethod(counter);

            Console.WriteLine("out " + value + counter);
        }
    }

...
string text = "stroka";
text.MyMethod(3);

//використання ref out аргументів
    static class MyClass
    {
        public static void MyMethod(this int value1, ref int value2, out int res)
        {
            res = value1 + value2;
            Console.WriteLine("{0} + {1} = {2}", value1, value2, res);
        }
    }

int value1 = 10, value2 = 20, res = 0;
value1.MyMethod(ref value2, out res);
