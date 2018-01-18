//класи (техніка фабричних методів)

    class MyClass
    {
        //конструктор
        public MyClass()
        {
            Console.WriteLine("MyClass created!");
        }
    }

    class Factory
    {
        //даний метод є фабричним, бо вертає значення породженого продукта (MyClass)
        public MyClass FactoryMethod()
        {
            return new MyClass();
        }
    }

...
Factory factory = new Factory();
MyClass my = factory.FactoryMethod();



//не фабричні методи

    class MyClass
    {
        public MyClass()
        {
            Console.WriteLine("MyClass created!");
        }
    }

    class Second
    {
        private MyClass obj = null;

        //даний метод не є фабричним
        public void Method()
        {
            obj = new MyClass();
        }
    }

...
Second my = new Second();
my.Method();
