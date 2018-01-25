//поля readonly
    class MyClass
    {
        public readonly int rField = 0;

        public MyClass()
        {
            rField = 1;//можна змінювати чи ініціалізувати тільки в конструкторі
        }

        public MyClass(int rField)
        {
            this.rField = rField;//можна змінювати чи ініціалізувати тільки в конструкторі
        }

        public void Change(int rField)
        {
            //this.rField = rField;//error
        }
    }

...
MyClass obj1 = new MyClass();
Console.WriteLine(obj1.rField);//1
MyClass obj2 = new MyClass(10);
Console.WriteLine(obj2.rField);//10
