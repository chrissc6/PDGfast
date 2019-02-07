using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDGfast
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine($"Start");


            Random rnd = new Random();
            int BestTotal = 0;
            int BestRolls = 0;
            int counter = 0;
            int gp = 0;
            long GamesToPlay = 10000000000;



            while (counter++ < GamesToPlay)
            {
                int Total = 0;
                int Rolls = 0;
                int Die = 0;

                do
                {
                    Total += Die;
                    Die = rnd.Next(6) + 1;
                    Rolls++;
                }
                while (Die != 1);


                if (Total > BestTotal)
                {
                    BestTotal = Total;
                    BestRolls = Rolls;
                    Console.WriteLine($"Score: {BestTotal} in {BestRolls} rolls. Played Games: {counter}");
                }
                //continue;



            }

            Console.ReadKey();


        }
    }
}
