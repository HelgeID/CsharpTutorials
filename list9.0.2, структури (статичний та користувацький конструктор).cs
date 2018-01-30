//структури (статичний та користувацький конструктор)

    struct MyStruct
    {
        public int myField;

        //статичний конструктор
        static MyStruct()
        {
            Console.WriteLine("Static Constructor");
        }

        //користувацький конструктор
        public MyStruct(int value)
        {
            Console.WriteLine("Constructor");
            this.myField = value;
        }
    }

...
MyStruct ins1 = new MyStruct { myField = 100 };
Console.WriteLine(ins1.myField);//100

//статичний конструктор визивається тільки разом з користувацьким конструктором
MyStruct ins2 = new MyStruct(888) { myField = 100 };
Console.WriteLine(ins2.myField);
/*
Static Constructor
Constructor
100
*/



//без конструкторів
    struct MyStruct
    {
        public int myField;

        public MyStruct(int value)
        {
            this.myField = value;
            Console.WriteLine(value);
        }
    }

...
MyStruct ins = new MyStruct(100);//100
ins.myField = 200;
Console.WriteLine(ins.myField);//200
