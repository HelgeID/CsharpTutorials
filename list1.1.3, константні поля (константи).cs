//константні поля (константи)
    class MyClass
    {
        //константи не можуть бути статичними
        public const double PI = 3.14;

        public MyClass()
        {
        }
    }

...
MyClass obj = new MyClass();

Console.WriteLine(MyClass.PI);
