//структури, перевірка однакових значень обєктів
    public struct MyStruct
    {
        public int myNumber;
        public string myStr;

        public MyStruct(int _myNumber, string _myStr)
        {
            myNumber = _myNumber;
            myStr = _myStr;
        }
    }

...
MyStruct s1 = new MyStruct(100, "Hello!");

MyStruct s2;
s2.myNumber = 100;
s2.myStr = "Hello!";

if (s2.Equals(s1))
    Console.WriteLine("s1 and s2 have same value");
