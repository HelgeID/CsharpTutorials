//заміщення статичних методів

//      1. Статичні методи можна заміщати.
//      2. Cтатичні методи не можуть бути віртуальними, абстрактними, переоприділеними.

    abstract class Base
    {
        //error - StaticMethod не може бути поміченим, як virtual
        //public static virtual void StaticMethod()
        //{
        //}

        public static void StaticMethod()
        {
            Console.WriteLine("Base Static Method");
        }
    }

    class Derived: Base
    {
        //error - StaticMethod не може бути поміченим, як override
        //public static override void StaticMethod()
        //{
        //}

        //new - робиться заміщення
        public static new void StaticMethod()
        {
            Console.WriteLine("Derived Static Method");
        }
    }

...
Base.StaticMethod();//Base Static Method
Derived.StaticMethod();//Derived Static Method
