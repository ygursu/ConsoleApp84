using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace klavyedikdortgenprizmasininhacmi
{
    class Program
    {
        static void Main(string[] args)
        {
           

            Console.WriteLine("Dikdörtgenler prizmasının a kenarını giriniz");
            int a = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Dikdörtgenler prizmasının b kenarını giriniz");
            int b = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Dikdörtgenler prizmasının c kenarını giriniz");
            int c = Int32.Parse(Console.ReadLine());

            int hacim = a * b * c;

            Console.WriteLine("Dikdörtgenler prizmasının hacmi={0}", hacim);
            Console.ReadLine();
        }
    }
}