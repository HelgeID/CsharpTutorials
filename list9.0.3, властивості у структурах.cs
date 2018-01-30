//властивості у структурах
    struct MyStruct
    {
        public int MyProperty { get; set; }
    }

...
MyStruct obj = new MyStruct();
obj.MyProperty = 500;
Console.WriteLine(obj.MyProperty);//500
