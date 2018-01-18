//класи, екземпляр по слабому посиланню (анонімні об'єкти)

    class MyClass
    {
        public void Method()
        {
            Console.WriteLine("Hello, World!");
        }
    }

    ...
    new MyClass().Method();
    