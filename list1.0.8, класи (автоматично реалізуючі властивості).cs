//класи (автоматично реалізуючі властивості)

//приклад1
    public class MyClass
    {
        public string MyField { get; set; }
    }

...
MyClass obj = new MyClass()
{
    MyField = "Hello, World!"
};

string myField = obj.MyField;
Console.WriteLine(myField);//Hello, World!



//приклад2
    class MyClass
    {
        public int Number1 { get; set; } = 100;
        public int Number2 { get; set; } = 200;
        public int Number3 { get; set; } = 300;
    }

...
MyClass obj = new MyClass();
Console.WriteLine(obj.Number1);//100
Console.WriteLine(obj.Number2);//200
Console.WriteLine(obj.Number3);//300



//приклад3
    class MyClass
    {
        public string MyField
        {
            get;
            private set;
        }

        public void InitField(string myField)
        {
            MyField = myField;
        }

        //установка контрольного поля (тільки для читання)
        public string Check { get; } = "Hello, World!";
    }

...
MyClass obj = new MyClass();
obj.InitField("Hello, World!");
if (obj.MyField == obj.Check)
    Console.WriteLine(obj.MyField);//Hello, World!



//приклад4
    class MyClass
    {
        public string MyField { get; }

        public MyClass(string myField)
        {
            MyField = myField;//запис поля для читання значенням myField
        }

        //error (MyField - тільки для читання)
        //public void InitField(string myField)
        //{
        //    MyField = myField;
        //}
    }

...
MyClass obj = new MyClass("Hello, World!");
Console.WriteLine(obj.MyField);//Hello, World!



//приклад5
    public class MyClass
    {
        public string MyField1 { get; set; }
        public int MyField2 { get; set; }
    }

    ...
    MyClass obj1 = new MyClass()
    {
        MyField1 = "one",
        MyField2 = 1
    };

    MyClass obj2 = new MyClass
    {
        MyField1 = "two",
        MyField2 = 2
    };

    Console.WriteLine("{0}, {1}", obj1.MyField1, obj1.MyField2);
    Console.WriteLine("{0}, {1}", obj2.MyField1, obj2.MyField2);

//приклад6
    public class MyClass
    {
        int myField2;
        public string MyField1 { get; set; }
        public int MyField2
        {
            get { return myField2; }
            set
            {
                if (value < 0)
                    Console.WriteLine("error: value is negative");
                else
                    myField2 = value;
            }
        }
    }

    ...
    MyClass obj1 = new MyClass()
    {
        MyField1 = "ten",
        MyField2 = -10
    };

    MyClass obj2 = new MyClass
    {
        MyField1 = "two",
        MyField2 = 2
    };

    Console.WriteLine("{0}, {1}", obj1.MyField1, obj1.MyField2);
    Console.WriteLine("{0}, {1}", obj2.MyField1, obj2.MyField2);
