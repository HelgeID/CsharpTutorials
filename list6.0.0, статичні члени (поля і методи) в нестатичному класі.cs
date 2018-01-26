//статичні члени (поля і методи) в нестатичному класі
    class MyClass
    {
        //відкрите статичне поле, що розташоване в області пам'яті, та відноситься до об'єкта
        public static int myField;

        public MyClass()
        {
            //ініціалізація статичного поля
            myField = 100;
        }
    }

...
MyClass obj = new MyClass();//створюємо екземпляр класа - obj
int field = MyClass.myField;//зчитування статичного поля
Console.WriteLine(field);//100



//статичні поля
    class MyClass
    {
        //статичні поля належать екземплярам, нестатичні - об'єктам
        public static string myField = string.Empty;

        public MyClass()
        {
        }

        //звернення з нестатичних методів до статичних полів
        public void Set(string _myField) { myField = _myField; }
        public string Get() { return myField; }

    }

...
MyClass obj1 = new MyClass();
MyClass obj2 = new MyClass();

obj1.Set("stroka 1");
Console.WriteLine(obj1.Get());//stroka 1
Console.WriteLine(obj2.Get());//stroka 1

obj2.Set("stroka 2");
Console.WriteLine(obj1.Get());//stroka 2
Console.WriteLine(obj2.Get());//stroka 2

MyClass.myField = "stroka 3";
Console.WriteLine(obj1.Get());//stroka 3
Console.WriteLine(obj2.Get());//stroka 3



//статичні методи
    class MyClass
    {
        //нестатичне поле
        public string myField = string.Empty;

        public MyClass()
        {
        }

        public static void MyMethod()
        {
            //В статичних методах неможна звертатися до нестатичних полів
            //Console.WriteLine(myField);//error
        }
    }

...
MyClass obj = new MyClass();
MyClass.MyMethod();
//obj.MyMethod();//error
