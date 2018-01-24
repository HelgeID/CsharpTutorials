//Base.cs
namespace ConsoleApplication
{
    class Base
    {
        private string[] baseArray = null;

        //конструктор
        public Base()
        {
            baseArray = new string[3];
            baseArray[0] = "null";
            baseArray[1] = "one";
            baseArray[2] = "two";
        }

        //віртуальний індексатор
        public virtual string this[int index]
        {
            get { return baseArray[index]; }
        }
    }
}
