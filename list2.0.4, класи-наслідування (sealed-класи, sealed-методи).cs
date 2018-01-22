//класи-наслідування (sealed-класи, sealed-методи)

//заборона наслідування класа (запечатаний клас)
    sealed class MyClass
    {
        public int x;
        public int y;
    }

    //error
    //class Derived : MyClass
    //{
    //}

...
MyClass obj = new MyClass();
obj.x = 100;
obj.y = 200;



//заборона переоприділення метода (запечатаний метод)
    class ClassA
    {
        public virtual void MyMethod1() { }
        public virtual void MyMethod2() { }
    }

    class ClassB : ClassA
    {
        sealed public override void MyMethod1() { } //sealed, як заборона переоприділення метода
        public override void MyMethod2() { }
    }

    class ClassC : ClassB
    {
        //public override void MyMethod1() {} //error: спроба переоприділення метода (метод запечатаний)
        public override void MyMethod2() { }
    }
