//статичний конструктор та перегрузка статичних методів
    class MyClass
    {
        private static int myField;

        public static int MyField
        {
            get { return myField; }
            private set { myField = value; }
        }

        //статичний конструктор
        static MyClass()
        {
            Console.WriteLine("launch of constructor");
            myField = 100;
        }

        //статичний метод
        public static void MyMethod()
        {
            myField = 100;
        }

        //статичний метод (перегрузка)
        public static void MyMethod(int myField)
        {
            MyField = myField;
        }

        //нестатичний метод
        public void NoStatic()
        {
            Console.WriteLine("no static method");
        }
    }

...
//спрацьовує конструктор

//v1
MyClass obj = new MyClass();//launch of constructor
obj.NoStatic();//no static method

//v2
Console.WriteLine(MyClass.MyField);//launch of constructor 100
MyClass.MyMethod(200);
Console.WriteLine(MyClass.MyField);//200
MyClass.MyMethod();
Console.WriteLine(MyClass.MyField);//100

//v3
MyClass obj = new MyClass();//launch of constructor
obj.NoStatic();//no static method
Console.WriteLine(MyClass.MyField);//100
MyClass.MyMethod(200);
Console.WriteLine(MyClass.MyField);//200
MyClass.MyMethod();
Console.WriteLine(MyClass.MyField);//100
