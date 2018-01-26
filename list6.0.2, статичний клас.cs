//статичний клас
    static class StaticClass// :object //наслідування від Object(явно та неявно)
    {
        //Конструктор не доступний (видає error при реалізації)
        //public StaticClass()
        //{
        //}

        //Статичний конструктор
        static StaticClass()
        {
            Console.WriteLine("Static Constructor");
        }

        //Статичний метод
        public static void StaticMethod()
        {
            Console.WriteLine("Static Method");
        }

        //Не статичний метод (видає error при реалізації)
        //public void NoStaticMethod()
        //{
        //}
    }

...
StaticClass.StaticMethod();
