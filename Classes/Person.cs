using System;

namespace Classes
{
    public class Person
    {
        public static int _pnr=0;
        public string Name;
        public int pnr = ++ _pnr;
        public void Introduce(string to)
        {

            Console.WriteLine("PersonsNumber {2} Hi {1}, I am {0} !", to, Name, pnr);
        }
    }
}
