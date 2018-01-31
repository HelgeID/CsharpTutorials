//перечислення (приклади роботи з Enum)
    enum EnumType: byte
    {
        Zero = 0,
        One = 1,
        Two = 2,
        Tree = 3
    }

...
EnumType Five = (EnumType)5;
Console.WriteLine(Five);//5

object element = Enum.Parse(typeof(EnumType), "Two");
EnumType number = (EnumType)element;
Console.WriteLine("{0} - {1}", number, (byte)number);//Two - 2

bool flag;
flag = Enum.IsDefined(typeof(EnumType), "one");
Console.WriteLine(flag);//False
flag = Enum.IsDefined(typeof(EnumType), "One");
Console.WriteLine(flag);//True

//поміщаємо в масив елементи перечислення
Array array = Enum.GetValues(typeof(EnumType));
Console.WriteLine("Length: {0}", array.Length);//Length: 4

for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine("{0:D} - {0}", array.GetValue(i));
    /*
    0 - Zero
    1 - One
    2 - Two
    3 - Tree
    */
}

//порівняння елементів
EnumType Two = EnumType.Two;
EnumType Tree = EnumType.Tree;

if (EnumType.Two < EnumType.Tree)//if (Two < Tree)
    Console.WriteLine("Two < Tree");
else
    Console.WriteLine("Tree < Two");//warning
