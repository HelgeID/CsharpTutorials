//перечислення
    struct MyStruct
    {
        public const byte zero = 0;
        public const byte one = 1;
        public const byte two = 2;
        public const byte three = 3;
    }

    enum EnumType : byte //явно вказуємо тип
    {
        Zero = 0,
        One = 1,
        Two = 2,
        Three = 3
    }

...
Console.WriteLine(EnumType.One);//One
Console.WriteLine((byte)EnumType.One);//1
EnumType digit = EnumType.Zero;
Console.WriteLine(digit);//Zero
Console.WriteLine((byte)digit);//0

Enum one = EnumType.One;
Console.WriteLine(one);//One
EnumType digit = EnumType.Zero;
Enum zero = digit;
Console.WriteLine(zero);//Zero

Console.WriteLine(new string('-', 10));
for (EnumType n = EnumType.Zero; n <= EnumType.Three; n++)
    Console.WriteLine(n);

/*
Zero
One
Two
Three

*/
