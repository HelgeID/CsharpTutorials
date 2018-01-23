//класи-абстракція (наслідування від абстрактного класа та реалізація їх методів)

    //абстрактний клас A
    abstract class AbstractA
    {
        public abstract void OperationA();
    }

    //абстрактний клас B
    abstract class AbstractB : AbstractA
    {
        public abstract void OperationB();
    }

    //конкретний клас
    class Concrete : AbstractB
    {
        //реалізація методів обов'язкова
        public override void OperationA()
        {
            Console.WriteLine("OperationA");
        }

        public override void OperationB()
        {
            Console.WriteLine("OperationB");
        }
    }

...
AbstractA objA = new Concrete();
objA.OperationA();

AbstractB objB = new Concrete();
objB.OperationA();
objB.OperationB();
