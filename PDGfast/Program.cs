using System;

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
            //ulong counter = 0;
            ulong GamesToPlay = 10000000000;

            while (10000000001 > GamesToPlay)
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
                    Console.WriteLine($"Score: {BestTotal} in {BestRolls} rolls");
                    
                }               
            }
            Console.ReadKey();
        }
    }
}
