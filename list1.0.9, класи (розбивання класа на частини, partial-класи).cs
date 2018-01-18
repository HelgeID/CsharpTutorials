//класи (розбивання класа на частини, partial-класи)

//приклад1
    partial class MyClass
    {
        public void MyMethod1()
        {
            Console.WriteLine("Call the first method!");
        }
    }

    partial class MyClass
    {
        public void MyMethod2()
        {
            Console.WriteLine("Call the second method!");
        }
    }

...
MyClass obj = new MyClass();
obj.MyMethod1();//Call the first method!
obj.MyMethod2();//Call the second method!



//приклад2
    //file 1
    partial class MyClass
    {
        public string str;
    }

    //file 2
    partial class MyClass
    {
        public MyClass(string str)
        {
            this.str = str;
        }

        public void Show()
        {
            Console.WriteLine(str);
        }
    }

...
MyClass obj = new MyClass("Hello, World!");
obj.Show();//Hello, World!



//приклад3
    //file 1
    partial class MyClass
    {
        //прототип метода
        partial void MyMethod(string str = "Hello, World!");
    };

    //file 2
    partial class MyClass
    {
        //реалізація метода
        partial void MyMethod(string str)
        {
            Console.WriteLine(str);
        }

        //викликаємо частинний метод
        public void CallMyMethod()
        {
            MyMethod();
        }
    };

...
MyClass obj = new MyClass();
obj.CallMyMethod();//Hello, World!
