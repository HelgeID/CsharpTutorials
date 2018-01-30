//структури, простий приклад ініціалізації
    public struct MyStruct
    {
        public int a, b, c;
        public MyStruct(int A, int B, int C)
        {
            a = A; b = B; c = C;
        }
    }

...
MyStruct s = new MyStruct();
Console.WriteLine("a={0}, b={1}, c={2}", s.a, s.b, s.c);//0 0 0

MyStruct s1;
s1.a = 10; s1.b = 20; s1.c = 30;
Console.WriteLine("a={0}, b={1}, c={2}", s1.a, s1.b, s1.c);//10 20 30

MyStruct s2 = new MyStruct(10, 20, 30);
Console.WriteLine("a={0}, b={1}, c={2}", s2.a, s2.b, s2.c);//10 20 30
