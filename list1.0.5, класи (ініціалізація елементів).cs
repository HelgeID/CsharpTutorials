//класи (ініціалізація елементів)

//за допомогою конструктора
    class MyClass
    {
        private string myField;

        public MyClass(string myField)
        {
            this.myField = myField;
        }

        public void MyMethod()
        {
            Console.WriteLine(myField);
        }
    }

...
MyClass obj = new MyClass("Hello, World!");
obj.MyMethod();//Hello, World!



//за допомогою метода
    class MyClass
    {
        private string myField;

        public MyClass()
        {
        }

        public void MyMethod(string myField)
        {
            this.myField = myField;
            Console.WriteLine(this.myField);
        }
    }

...
MyClass obj = new MyClass();
obj.MyMethod("Hello, World!");//Hello, World!



//ініціалізація, приклад
    class MyClass
    {
        public int a;
        public int b;
        public int c;

        public MyClass()
        {
            a = 0;
            b = 0;
            c = 0;
        }

        public MyClass(int aA, int bB, int cC)
        {
            a = aA;
            b = bB;
            c = cC;
        }

        public void Show()
        {
            Console.WriteLine("{0}, {1}, {2}", a, b, c);
        }

    }

...
MyClass obj1 = new MyClass();
obj1.Show();//0, 0, 0

MyClass obj2 = new MyClass(10, 20, 30);
obj2.Show();//10, 20, 30

MyClass obj3 = new MyClass();
obj3.a = 100;
obj3.b = 200;
obj3.c = 300;
obj3.Show();//100, 200, 300

MyClass obj4 = new MyClass { a = 111, b = 222, c = 333 };
obj4.Show();//111, 222, 333
