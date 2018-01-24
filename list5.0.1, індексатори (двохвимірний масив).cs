//індексатори (двохвимірний масив)
    class MyClass
    {
        private int[,] array = new int[3, 3];

        public int this[int index1, int index2]
        {
            get { return array[index1, index2]; }
            set { array[index1, index2] = value; }
        }
    }

...
MyClass my = new MyClass();
my[1, 1] = 20;

Console.WriteLine(my[1, 1]);//20
Console.WriteLine(my[0, 0]);//0
