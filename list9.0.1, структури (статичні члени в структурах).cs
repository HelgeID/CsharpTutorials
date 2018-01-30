//структури (статичні члени в структурах)

    struct MyStruct//статична структура не допустима
    {
        //статична автовластивість myField
        public static int MyField
        {
            get;
            set;
        }

        public static void Show()
        {
            Console.WriteLine(MyField);
        }
    }

...
MyStruct.Show();//0
MyStruct.MyField = 100;
MyStruct.Show();//100
