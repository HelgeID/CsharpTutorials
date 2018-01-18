//класи, дві силки, які вказують на один і той же об'єкт

    public class MyClass
    {
        public int myNumber;

        public int takeNumber()
        {
            return myNumber;
        }
    }

...
MyClass obj1 = new MyClass();
MyClass obj2 = obj1;

obj1.myNumber = 100;
Console.WriteLine(obj1.takeNumber());//100
Console.WriteLine(obj2.takeNumber());//100

obj2.myNumber = 200;
Console.WriteLine(obj1.takeNumber());//200
Console.WriteLine(obj2.takeNumber());//200
