//статичний конструктор

//приклад1
    class MyClass
    {
        static MyClass()
        {
            Console.WriteLine("launch of constructor");
        }
    }

...
MyClass obj1 = new MyClass();//тут спрацьовує статичний конструктор
MyClass obj2 = new MyClass();



//приклад2
    static class MyClass
    {
        private static int number;

        public static int Number
        {
            set
            {
                number = value;
            }
            get
            {
                return number;
            }
        }
    }

...
//MyClass obj = new MyClass();//error
MyClass.Number = 100;
Console.WriteLine(MyClass.Number);//100



//приклад3
    static class MyClass
    {
        //статичне поле readonly повинно бути проініціалізоване
        static readonly int rMyField = 10;

        //статична властивість тільки для читання
        public static int RMyField
        {
            get { return MyClass.rMyField; }
        }

        //статичний конструктор - спрацьовує автоматично
        static MyClass()
        {
            rMyField = 100;
        }
    }

...
Console.WriteLine(MyClass.RMyField);//100
