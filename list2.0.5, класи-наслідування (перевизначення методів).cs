//класи-наслідування (перевизначення методів)
using System;

namespace ConsoleApplication
{
    class Base
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public Base(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        public virtual void Show()
        {
            Console.WriteLine(Name + " - " + Surname);
        }
    }

    class Derived: Base
    {
        public string Hometown { get; set; }

        public Derived(string name, string surname, string hometown)
            :base(name, surname)
        {
            Hometown = hometown;
        }

        public override void Show()
        {
			//base.Show();//звернення до метода базового класа
            Console.WriteLine(Name + " - " + Surname + " - " + Hometown);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Base obj1 = new Base("Ivan", "Ivanov");
            obj1.Show();//Ivan - Ivanov

            Base obj2 = new Derived("Anton", "Antonov", "Lviv");
            obj2.Show();//Anton - Antonov - Lviv

            Derived obj3 = new Derived("Vadym", "Vadymov", "Kyiv");
            obj3.Show();//Vadym - Vadymov - Kyiv

            Console.ReadKey();
        }
    }
}

/*
        public new void Show()
        {
            Console.WriteLine(Name + " - " + Surname + " - " + Hometown);
        }

    ...

            Base obj2 = new Derived("Anton", "Antonov", "Lviv");
            obj2.Show();//Anton - Antonov
 */

 //sealed - як заборона перевизначення метода та властивостей
/*  
 public override sealed void Display()
 {
 } */
 