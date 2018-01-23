//класи-абстракція (реалізація абстрактного метода в похідному класі)

    abstract class Abstract
    {
        public Abstract()
        {
            Console.WriteLine("1 Abstract class");

            this.AbstractMethod();//Викликається реалізація методу з похідного класу

            Console.WriteLine("2 Abstract class");
        }

        public abstract void AbstractMethod();//оголошення
    }

    class Concrete : Abstract
    {
        string str = "value 1";

        public Concrete()
        {
            Console.WriteLine("3 Concrete class");
            str = "value 2";
        }

        //реалізація
        public override void AbstractMethod()
        {
            Console.WriteLine("{0}", str);
        }
    }

...
Abstract obj = new Concrete();
Console.WriteLine(new string('-', 10));
obj.AbstractMethod();

/*
1 Abstract class
value 1
2 Abstract class
3 Concrete class
----------
value 2

 */
