﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    class Program
    {
        static void Main(string[] args)
        {
            var persoon = new Person();
            persoon.Name = "John";
            var zelf = "Polleke";
            persoon.Introduce("Polleke");
            var p1 = new Person();
            p1.Name = "Pee 1";
            p1.Introduce(zelf);
            var p2 = new Person();
            p2.Name = "Pee 2";
            p2.Introduce(zelf);
            var p3 = new Person();
            p3.Name = "Pee 3";
            p3.Introduce(zelf);
            var p4 = new Person();
            p4.Name = "Pee 4";
            p4.Introduce(zelf);


        }
    }
}
