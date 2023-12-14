using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ArrayList Kolekcija

            ArrayList kolekcija = new ArrayList();

            kolekcija.Add(1);   
            kolekcija.Add("Ovo je string");
            kolekcija.Add('a');
            kolekcija.Add(10.32);

            kolekcija.Insert(2, "I ovo je string");

            if (kolekcija.Contains(1))
            {
                kolekcija.Remove(1);
            }

            if (!kolekcija.Contains(1))
            {
                kolekcija.Add(1);
            }

            kolekcija.RemoveAt(3);

            foreach(var item in kolekcija)
            {
                Console.WriteLine(item.ToString());
            }
            Console.ReadKey();
        }
    }
}
