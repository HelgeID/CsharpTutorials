//структури (створення та ініціалізація)

//приклад1
    struct MyStruct
    {
        public int myField;//тут ініціалізувати не можна
    }

...
MyStruct ins;//створення екземпляра структурного типу
ins.myField = 100;//записуємо значення в елемент структури
Console.WriteLine(ins.myField);



//приклад2
    struct MyStruct
    {
        private int myField;

        public int MyField
        {
            get { return myField; }
            set { myField = value; }
        }

        public void Show()
        {
            Console.WriteLine(myField);
        }
    }

...
MyStruct ins = new MyStruct();//створення екземпляра структурного типу з конструктором по-замовчуванню
ins.MyField = 100;//записуємо значення
Console.WriteLine(ins.MyField);



//приклад3
    struct MyStruct
    {
        public int myField;

        //конструктор по-замовчуванню явно задавати не можна
        //public MyStruct()
        //{
        //}

        public MyStruct(int value)
        {
            Console.WriteLine("Constructor");
            this.myField = value;//обов'язково треба проініціалізувати
        }
    }

...
MyStruct ins1 = new MyStruct();
Console.WriteLine(ins1.myField);//0
MyStruct ins2 = new MyStruct(100);
Console.WriteLine(ins2.myField);//100
