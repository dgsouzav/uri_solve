using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uri_1049
{
    class Program
    {
        static void Main(string[] args)
        {
            string P1 = Console.ReadLine();
            string P2 = Console.ReadLine();
            string P3 = Console.ReadLine();


            if (P1 == "vertebrado" && P2 == "ave" && P3 =="carnivoro" )
            {
                Console.WriteLine("aguia");
            }

            else if (P1 == "vertebrado" && P2 == "ave" && P3 == "onivoro")
            {
                Console.WriteLine("pomba");
            }
            else if (P1 == "vertebrado" && P2 == "mamifero" && P3 == "onivoro")
            {
                Console.WriteLine("homem");
            }
            else if (P1 == "vertebrado" && P2 == "mamifero" && P3 == "herbivoro")
            {
                Console.WriteLine("vaca");
            }

            if (P1 == "invertebrado" && P2 == "inseto" && P3 == "hematofago")
            {
                Console.WriteLine("pulga");
            }

            else if (P1 == "invertebrado" && P2 == "inseto" && P3 == "herbivoro")
            {
                Console.WriteLine("lagarta");
            }
            else if (P1 == "invertebrado" && P2 == "anelideo" && P3 == "hematofago")
            {
                Console.WriteLine("sanguessuga");
            }
            else if (P1 == "invertebrado" && P2 == "anelideo" && P3 == "onivoro")
            {
                Console.WriteLine("minhoca");
            }




            Console.ReadKey();
        }
    }
}