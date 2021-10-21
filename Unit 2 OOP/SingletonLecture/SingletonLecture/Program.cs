using System;

namespace SingletonLecture
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton singleton = Singleton.Instance;

            Singleton signleton2 = Singleton.Instance;
        }
    }
}
