//класи-наслідування (UpCast, DownCast, virtual-override)

//приклад1
    class Base
    {
        public int myField1;
        public int myField2;
    }

    class Derived : Base
    {
        public int myField3;
    }

...
Derived objDerived = new Derived();
objDerived.myField1 = 100;
objDerived.myField2 = 200;
objDerived.myField3 = 300;

//приведення екземпляра похідного класа до базового типу
Base objBase = (Base)objDerived;//UpCast

Console.WriteLine(objBase.myField1);//100
Console.WriteLine(objBase.myField2);//200
//Console.WriteLine(objBase.myField3);//error

Console.WriteLine("id objDerived  {0}", objDerived.GetHashCode());
Console.WriteLine("id objBase     {0}", objBase.GetHashCode());



//приклад2 (заміщання)
    class Base
    {
        public void MyMethod()
        {
            Console.WriteLine("uses method of base class");
        }
    }

    class Derived : Base
    {
        //void MyMethod() - заміщає метод базового класа.
        new public void MyMethod()
        {
            Console.WriteLine("uses method of derived class");
        }
    }

...
Derived obj = new Derived();
obj.MyMethod();//uses method of derived class

//UpCast
Base objUp = obj;
objUp.MyMethod();//uses method of base class

//DownCast (неможливий без UpCast)
Derived objDown = (Derived)objUp;
objDown.MyMethod();//uses method of derived class



//приклад3 (переоприділення)
    class Base
    {
        public virtual void MyMethod()
        {
            Console.WriteLine("uses method of base class");
        }
    }

    class Derived : Base
    {
        //void MyMethod() - переоприділяє метод базового класа. Задача - замінити метод базового класа новим.
        public override void MyMethod()
        {
            Console.WriteLine("uses method of derived class");
        }
    }

...
Derived obj = new Derived();
obj.MyMethod();//uses method of derived class

//UpCast
Base objUp = obj;
objUp.MyMethod();//uses method of derived class

//DownCast
Derived objDown = (Derived)objUp;
objDown.MyMethod();//uses method of derived class



//приклад4 (виклик метода базового класа)

    class Base
    {
        public virtual void MyMethod()
        {
            Console.WriteLine("uses method of base class");
        }
    }

    class Derived : Base
    {
        public override void MyMethod()
        {
            base.MyMethod();//виклик метода базового класа
            Console.WriteLine("uses method of derived class");
        }
    }

...
Derived obj = new Derived();
obj.MyMethod();
