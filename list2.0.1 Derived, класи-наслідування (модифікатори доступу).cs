namespace ConsoleApplication
{
    class Derived : Base
    {
        public Derived()
        {
            publicField = "derived public field";
            //privateField = "derived private field";//error (недоступно)
            protectedField = "derived protected field";
        }
    }
}
