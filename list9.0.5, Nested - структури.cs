//Nested - структури
    struct MyStruct
    {
        public struct Nested //також можуть бути класи
        {
            public void NestedMethod()
            {
                Console.WriteLine("Nested Method");
            }
        }
    }

...
MyStruct.Nested ins = new MyStruct.Nested();
ins.NestedMethod();//Nested Method
