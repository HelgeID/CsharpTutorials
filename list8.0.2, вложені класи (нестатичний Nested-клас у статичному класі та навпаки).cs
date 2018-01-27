//нестатичний Nested-клас у статичному класі
    public static class MyClass
    {
        static MyClass()
        {
            Console.WriteLine("Static Constructor");
        }

        public static void StaticMethod()
        {
            Console.WriteLine("Static Method");
        }

        //статичні класи можуть у собі містити нестатичні Nested-класи
        public class Nested
        {
            public void Method()
            {
                Console.WriteLine("Method of Nested Class");
            }
        }
    }

...
MyClass.Nested ins = new MyClass.Nested();
ins.Method();//Method Nested Class
MyClass.StaticMethod();
/*
Static Constructor
Static Method
*/



//статичний Nested-клас у нестатичному класі
    public class MyClass
    {
        public static class Nested
        {
            public static void Method()
            {
                Console.WriteLine("Static Method of Nested Class");
            }
        }
    }

...
MyClass.Nested.Method();//Static Method of Nested Class
