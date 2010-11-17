using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Podminky
{
    class Program
    {
        static void Main(string[] args)
        {

            // Deklarace proměnných
            int promennaA = 10;
            int promennaB = 20;

            // Deklarace řetězců
            string retezec1 = "ahoj", retezec2 = "ahoj";

            // Nějaké další přiřazení...
            promennaA = 5;

            // Podmínky
            if (promennaA < promennaB)
                Console.WriteLine("Proměnná A je menší než proměnná B");
            else if (promennaB < promennaA)
                Console.WriteLine("Proměnná A je větší než proměnná B");
            else Console.WriteLine("Proměnné jsou stejné");

            // Porovnání
            if (retezec1 == retezec2)
            {
                Console.WriteLine("Řetězce jsou stejné");

                string spoj = retezec1 + retezec2 + " !";
                
                Console.WriteLine("Spojený řetězec je {0}", spoj);
            }


            Console.Read(); // Neumírej...
        }
    }
}
