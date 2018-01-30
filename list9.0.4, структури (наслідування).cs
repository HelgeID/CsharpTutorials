//структури (наслідування)

//наслідування від інтерфейсів
    interface MyInterface
    {
        void MyMethod();
    }

    struct MyStruct: MyInterface //(наслідування від класів та структур заборонено)
    {
        //реалізація метода
        public void MyMethod()
        {
            Console.WriteLine("My Interface Method");
        }
    }

...
MyStruct ins;
ins.MyMethod();



//перевірка наслідування від ValueType
    struct MyStruct// :ValueType
    {
        public void Method()
        {
            Console.WriteLine("Method");
        }
    }

...
MyStruct ins = new MyStruct();
ValueType vt = ins as ValueType;
Console.WriteLine(ins.GetHashCode());
Console.WriteLine(vt.GetHashCode());



//від структур не можна наслідуватися
    struct MyStruct
    {
        //protected int myField;//error
    }

    //error
    //struct MyClass : MyStruct
    //{
    //}
