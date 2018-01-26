//singleton - вказання екзкмплярів на один і той же об'єкт
    class Singleton
    {
        private static Singleton ins = null;

        // Конструктор - "protected"
        protected Singleton()
        {
        }

        // Фабричний метод
        public static Singleton Instance()
        {
            //якщо об'єкт ще не створений
            if (ins == null)
            {
                //створюємо новий екземпляр
                ins = new Singleton();
            }

            //повертаємо силку
            return ins;
        }
    }

...
Singleton ins1 = Singleton.Instance();
Singleton ins2 = Singleton.Instance();

if (ins1 == ins2)
    Console.WriteLine("Links => object");//силки вказують на один і той об'єкт
