//класи-абстракція (наслідування конкретного класа від абстрактного та навпаки)

//приклад1 (конкретний від абстрактного)

    //абстрактний клас
    abstract class Abstract
    {
        public abstract void MyMethod();//те ж саме, що: public virtual void MyMethod() {}
    }

    //конкретний клас
    class Concrete : Abstract
    {
        //переопреділення метода MyMethod()
        public override void MyMethod()
        {
            Console.WriteLine("Hello, World!");
        }
    }

...
Abstract obj = new Concrete();
obj.MyMethod();//Hello, World!



//приклад2 (абстрактний від конкретного)

    //конкретний клас
    class Concrete
    {
        public void Operation()
        {
        }
    }

    //абстрактний клас
    abstract class Abstract : Concrete
    {
        public abstract void MyMethod();
    }

    //мій клас
    class MyClass : Abstract
    {
        public override void MyMethod()
        {
            Console.WriteLine("Hello, World!");
        }
    }

...
Abstract obj = new MyClass();
obj.Operation();
obj.MyMethod();
