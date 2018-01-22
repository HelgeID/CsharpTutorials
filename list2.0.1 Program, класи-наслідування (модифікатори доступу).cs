//класи-наслідування (модифікатори доступу)
using System;

namespace ConsoleApplication
{
    class Program
    {
        static void Main()
        {
            string field;

            Base objBase = new Base();
            field = objBase.publicField;
            //field = objBase.privateField;//error (недоступно)
            //field = objBase.protectedField;//error (недоступно)

            Derived objDerived = new Derived();
            field = objDerived.publicField;
            //field = objDerived.privateField;//error (недоступно)
            //field = objDerived.protectedField;//error (недоступно)

            Console.ReadKey();
        }
    }
}
