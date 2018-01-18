//класи, доступ до закритих полів (private)

    class MyClass
    {
        private string myField = null;

        //Метод-мутатор
        public void SetField(string value)
        {
            myField = value;
        }

        //Метод-аксесор
        public string GetField()
        {
            return myField;
        }
    }

    ...
    MyClass ins = new MyClass();
    ins.SetField("Hello, World!");
    string @string = ins.GetField();
    Console.WriteLine(@string);//Hello, World!
    