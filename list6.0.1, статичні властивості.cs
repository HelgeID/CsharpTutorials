//статичні властивості

//приклад1
    class MyClass
    {
        static int myField;

        public static int MyField1
        {
            get { return myField; }
            set { myField = value; }
        }

        public int MyField2
        {
            get { return myField; }
            set { myField = value; }
        }
    }

...
MyClass.MyField1 = 100;
Console.WriteLine(MyClass.MyField1);//100

MyClass obj = new MyClass();
obj.MyField2 = 200;
Console.WriteLine(MyClass.MyField1);//200
Console.WriteLine(obj.MyField2);//200

//приклад2
    class MyClass
    {
        private static int number = 100;

        public int Number
        {
            get { return number; }
            set { number = value; }
        }

        public static int sNumber
        {
            get { return number; }
            set { number = value; }
        }
    }

...
MyClass obj1 = new MyClass();
MyClass obj2 = new MyClass();
Console.WriteLine("{0}, {1}", obj1.Number, obj2.Number);//100, 100

obj1.Number = 200;
Console.WriteLine("{0}, {1}", obj1.Number, obj2.Number);//200, 200
obj2.Number = 150;
Console.WriteLine("{0}, {1}", obj1.Number, obj2.Number);//150, 150
MyClass.sNumber = 300;
Console.WriteLine("{0}, {1}", obj1.Number, obj2.Number);//300, 300
