//інтерфейси - як альтернатива абстракції

    interface IInterface
    {
        void Show();//метод по-замовчуванню відкритий (немає смисла робити закритим)
    }

    class MyClass : IInterface
    {
        public void Show()
        {
            Console.WriteLine("Hello, World!");
        }
    }

...
MyClass obj = new MyClass();
obj.Show();//Hello, World!
