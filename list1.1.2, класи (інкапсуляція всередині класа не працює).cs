//класи (інкапсуляція всередині класа не працює)

    class MyClass
    {
        MyClass my = null;

        private void MyMethod()
        {
            Console.WriteLine("Hello, World!");
        }

        public void CallMyMethod()
        {
            my = new MyClass();
            my.MyMethod();//доступно
        }
    }

    ...
    MyClass my = new MyClass();
    my.CallMyMethod();
    //my.MyMethod();//недоступно
