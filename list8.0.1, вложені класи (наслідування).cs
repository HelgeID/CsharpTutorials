//вложені класи (наслідування)

//приклад1
    public class Base
    {
        public void MethodBase()
        {
            Console.WriteLine("Base Method");
        }
    }

    class MyClass
    {
        public class Nested : Base
        {
            public void MethodNested()
            {
                Console.WriteLine("Nested Method");
            }
        }
    }

...
MyClass.Nested ins = new MyClass.Nested();
ins.MethodBase();//Base Method
ins.MethodNested();//Nested Method



//приклад2
    public class Base
    {
        public void MethodBase()
        {
            Console.WriteLine("Base Method");
        }
    }

    class MyClass : Base
    {
        public class Nested //наслідування із Base недопустимо
        {
            public void MethodNested()
            {
                Console.WriteLine("Nested Method");
            }
        }
    }

...
MyClass.Nested ins = new MyClass.Nested();
//ins.MethodBase();//Base Method
ins.MethodNested();//Nested Method
