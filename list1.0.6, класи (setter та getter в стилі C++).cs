//класи (setter та getter в стилі C++)

    class MyClass
    {
        string str = string.Empty;//private

        //метод доступу set
        public void set(string _str)
        {
            str = _str;
        }

        //метод доступу get
        public string get()
        {
            return str;
        }
    }

...
MyClass obj = new MyClass();
obj.set("Hello, World!");
string str = obj.get();
Console.WriteLine(str);//Hello, World!
