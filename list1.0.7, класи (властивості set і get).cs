//класи (властивості set і get)

//приклад1
    class MyClass
    {
        private string myField;

        public string MyField
        {
            set { myField = value; } //властивість, тільки для запису
            get { return myField; }  //властивість, тільки для читання
        }
    }

...
MyClass obj = new MyClass();
obj.MyField = "Hello, World!";//set
string str = obj.MyField;//get
Console.WriteLine(str);//Hello, World!



//приклад2
    class MyClass
    {
        private int myNumber;

        public int MyNumber
        {
            set
            {
                //установлюємо умову
                if (value < 0)
                    Console.WriteLine("Number is negative");
                else
                {
                    Console.WriteLine("Number is positive");
                    myNumber = value;
                }
            }
            get
            {
                return myNumber;
            }
        }
    }

...
MyClass obj = new MyClass();
obj.MyNumber = 200;//Number is positive
Console.WriteLine(obj.MyNumber);//200
obj.MyNumber = -200;//Number is negative
Console.WriteLine(obj.MyNumber);//200



//приклад3
    class MyClass
    {
        private string myField;

        //властивість тільки для читання
        public string FieldRead
        {
            get { return myField; }
        }

        //властивість тільки для запису
        public string FieldWrite
        {
            set { myField = value; }
        }
    }

...
MyClass obj = new MyClass();
obj.FieldWrite = "Hello, World!";
Console.WriteLine(obj.FieldRead);//Hello, World!

//obj.FieldRead = "Hello, World!";//error
//Console.WriteLine(obj.FieldWrite);//error



//приклад4
    class MyClass
    {
        private string myField;

        public string MyField
        {
            //установлюємо модифікатор доступу private
            private set
            {
                myField = value;
            }

            //модифікатор доступу по-замовчуванню
            get
            {
                return myField;
            }
        }

        //ініціалізуємо значення через конструктор
        public MyClass(string myField)
        {
            MyField = myField;
        }
    }

...
MyClass obj = new MyClass("Hello, World!");
//obj.MyField = "Hello, World!";//error
Console.WriteLine(obj.MyField);//Hello, World!
