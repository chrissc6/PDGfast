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
            Run();
        }

        static void Run()
        {
            var BestTotal = 0;
            var BestRolls = 0;
            var counter = 0;
            var gp = 0;
            var GamesToPlay = 10000000000;
            while (counter++ < GamesToPlay)
            {
                var (Total, Rolls) = RunPigDiceGame();
                gp++;
                if (Total > BestTotal)
                {
                    BestTotal = Total;
                    BestRolls = Rolls;
                    Console.WriteLine($"Score: {BestTotal} in {BestRolls} rolls. Played Games: {gp}");
                }
                
            }
            
        }

        static (int, int) RunPigDiceGame()
        {
            Random rnd = new Random();
            var Total = 0;
            var Rolls = 0;
            int Die = 0;

            while (Die != 1)
            {
                Total += Die;
                Die = rnd.Next(6) + 1;
                Rolls++;
            }
            return (Total, Rolls);
        }
    }
}
