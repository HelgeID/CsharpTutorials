//статичний метод в абстрактному класі

    abstract class Abstract
    {
        //статичний фабричний метод
        public static Abstract CreateObject()
        {
            //на куче створює екземпляр класа та приводе його до типу Abstract
            return new Concrete();
        }

        public abstract void Method();
    }

    class Concrete: Abstract
    {
        public override void Method()
        {
            Console.WriteLine("Hello, World!");
        }
    }

...
Abstract ins = Abstract.CreateObject();
ins.Method();//Hello, World!
