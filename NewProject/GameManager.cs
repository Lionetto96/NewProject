using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewProject
{
    internal class GameManager
    {
        public static void getNumber()
        {
            Console.WriteLine("inserisci un numero tra 2 e 12");
            Random random = new Random();
            int dado1 = random.Next(1, 7);
            int dado2 = random.Next(1, 7);
            if(num<12 && num > 2)
            {
                int somma=dado1 + dado2;
                Console.WriteLine("la somma dei 2 dadi è " + somma);
            }
            else
            {
                Console.WriteLine("il numero inserito non è  corretto");
            }


        }
        public static void Control()
        {

        }
    }
}
