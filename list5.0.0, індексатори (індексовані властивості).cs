//індексатори (індексовані властивості)

//приклад1
    class MyClass
    {
        private int[] array = new int[3];

        public int this[int index]
        {
            get { return array[index]; }//аксесор
            set { array[index] = value; }//мутатор
        }
    }

...
MyClass my = new MyClass();
my[0] = 10;
my[1] = 20;
my[2] = 30;

Console.WriteLine("{0}, {1}, {2}", my[0], my[1], my[2]);//10, 20, 30



//приклад2 (заборона установки значення)
    class MyClass
    {
        private int[] array = new int[3];

        public int this[int index]
        {
            get { return array[index]; }
            set
            {
                if (value != 100)
                    array[index] = value;
            }
        }
    }

...
MyClass my = new MyClass();
my[0] = 100;//не установиться

Console.WriteLine(my[0]);//0
