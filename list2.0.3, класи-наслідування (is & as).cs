//класи-наслідування (is & as)

//приклад1
    class Base {/* ... */}
    class Derived : Base {/* ... */}

...
Derived objDerived = new Derived();
Base objBase = null;

//чи можна objDerived привести до базового типу, тобто, чи клас Derived наслідується від класа Base - is вертає true

//v1
if (objDerived is Base)
    objBase = (Base)objDerived;
else
    objBase = null;

//v2
objBase = objDerived as Base;



//приклад2 (безпечне приведення типа через as)

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
            Console.WriteLine("uses method of derived class");
        }
    }

...
Derived obj = new Derived();
obj.MyMethod();//uses method of derived class

//безпечне приведення типа через as

//UpCast
Base objUp = obj as Base;
if (objUp != null)
    objUp.MyMethod();//uses method of derived class

//DownCast
Derived objDown = objUp as Derived;
if (objDown != null)
    objDown.MyMethod();//uses method of derived class
