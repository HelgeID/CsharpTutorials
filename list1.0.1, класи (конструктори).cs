//класи, конструктори

    //приклад1
    class MyClass
    {
        private string myField;

        //конструктор по-замовчуванню (явно створений)
        public MyClass()
        {
        }

        //конструктор з параметром
        public MyClass(string myField)
        {
            this.myField = myField;
        }

        public void Show()
        {
            Console.WriteLine(myField);
        }
    }

    ...
    MyClass obj1 = new MyClass();
    obj1.Show();//
    MyClass obj2 = new MyClass("Hello!");
    obj2.Show();//Hello!

    //приклад2
    class MyClass
    {
        private string myStr;
        private int myNumber1;
        private int myNumber2;

        public MyClass(int myNumber1, int myNumber2)
        {
            this.myNumber1 = myNumber1;
            this.myNumber2 = myNumber2;
        }

        public MyClass(string myStr)
            : this(100, 200)//виклик конструктора MyClass(int, int)
        {
            this.myStr = myStr;
        }

        public void Show()
        {
            Console.WriteLine("{0} {1} {2}", myStr, myNumber1, myNumber2);
        }
    }

    ...
    MyClass obj1 = new MyClass("Hello!");
    obj1.Show();//Hello! 100 200
    MyClass obj2 = new MyClass(100, 200);
    obj2.Show();// 100 200
    