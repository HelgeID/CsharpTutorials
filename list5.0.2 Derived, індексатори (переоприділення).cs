//Derived.cs
namespace ConsoleApplication
{
    class Derived: Base
    {
        private int[] derivedArray = null;

        //конструктор
        public Derived()
        {
            derivedArray = new int[3];
            derivedArray[0] = 0;
            derivedArray[1] = 1;
            derivedArray[2] = 2;
        }

        //переоприділений індексатор
        public override string this[int index]
        {
            get { return base[index] + "\t- " + derivedArray[index].ToString(); }
        }
    }
}
