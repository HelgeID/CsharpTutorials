//вложені класи

//приклад1
    class MyClass
    {
        public class NestedClass
        {
            public void MyMethod()
            {
                Console.WriteLine("Nested Method");
            }
        }
    }

...
MyClass.NestedClass obj = new MyClass.NestedClass();
obj.MyMethod();//Nested Method



//приклад2
    class MyClass
    {
        private static int myField = 0;
        public class NestedClass
        {
            public void MyMethod(int _myField)
            {
                myField = _myField;
                Console.WriteLine(myField);
            }
        }
    }

...
MyClass.NestedClass obj = new MyClass.NestedClass();
obj.MyMethod(100);//100



//приклад3
    class MyClass
    {
        private int myField = 0;//поле не статичне
        public class NestedClass
        {
            MyClass ins = new MyClass();//екземпляр класа
            public void MyMethod(int _myField)
            {
                ins.myField = _myField;
                Console.WriteLine(ins.myField);
            }
        }
    }

...
MyClass.NestedClass obj = new MyClass.NestedClass();
obj.MyMethod(100);//100
