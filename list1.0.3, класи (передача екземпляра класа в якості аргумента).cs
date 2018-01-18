//класи, передача екземпляра класа в якості аргумента

    class MyClass
    {
        public void Method()
        {
            Console.WriteLine("Call Method");
        }
    }

    class MyClass2
    {
        public void CallMethod(MyClass my)
        {
            my.Method();
        }
    }

    ...
    MyClass my = new MyClass();
    MyClass2 my2 = new MyClass2();

    my2.CallMethod(my);
    