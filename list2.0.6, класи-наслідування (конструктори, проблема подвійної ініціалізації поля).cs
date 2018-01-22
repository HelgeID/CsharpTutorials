//класи-наслідування (конструктори, проблема подвійної ініціалізації поля)

//приклад1 (з подвійною ініціалізацією)
    class Base
    {
        public int baseNum;

        //конструктор по замовчуванню
        public Base()
        {
        }

        //користувацький конструктор
        public Base(int baseNum)
        {
            this.baseNum = baseNum;
        }
    }

    class Derived: Base
    {
        public int derivedNum;

        //користувацький конструктор
        public Derived(int baseNum, int derivedNum)
        {
            //виконується подвійна ініціалізація baseNum. Спочатку 0 (конструктором базового класа), а потім 100 (конструктором похідного класа).
            this.baseNum = baseNum;
            this.derivedNum = derivedNum;
        }
    }

    ...
    Derived ins = new Derived(100, 200);
    Console.WriteLine(ins.baseNum);//100
    Console.WriteLine(ins.derivedNum);//200

//приклад2 (без подвійної ініціалізації)
    class Base
    {
        public int baseNum;

        //конструктор по замовчуванню
        public Base()
        {
        }

        //користувацький конструктор
        public Base(int baseNum)
        {
            this.baseNum = baseNum;
        }
    }

    class Derived: Base
    {
        public int derivedNum;

        //конструктор по замовчуванню
        public Derived()
        {
        }

        //користувацький конструктор
        public Derived(int baseNum, int derivedNum)
            :base(baseNum) //викликається конструктор базового класа з параметром
        {
            this.derivedNum = derivedNum;
        }
    }

    ...
    Derived ins = new Derived(100, 200);
    Console.WriteLine(ins.baseNum);//100
    Console.WriteLine(ins.derivedNum);//200
