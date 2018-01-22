//класи-наслідування

//приклад1
    //створення класа Base
    class Base
    {
        public string BaseField;
        public void BaseMethod()
        {
        }
    }

    //створення класа Derived, та наслідування від Base
    class Derived : Base
    {
        public void DerivedMethod()
        {
        }
    }

...
Derived obj = new Derived();
obj.BaseField = "Hello, World!";
obj.BaseMethod();
obj.DerivedMethod();



//приклад2
    class Base
    {
        public string Str { get; set; }
    }

    class Derived : Base
    {
    }

...
Base obj = new Base { Str = "uses Base class" };
Console.WriteLine(obj.Str);//uses Base class
obj = new Derived { Str = "uses Derived class" };
Console.WriteLine(obj.Str);//uses Derived class
