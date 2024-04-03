namespace BlackJack
{
    internal class Program
    {

        static int[] rozdanieKart()
        {
            Console.WriteLine("1.The cards are dealt.");
            int[] karty = { 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10 };
            int rekaGracza = 0;
            int rekaKrupiera = 0;
            int los;
            int[] wartosciKartGraczy = { 0, 0 };
            for (int i = 0; i < 2; i++)
            {
                los = new Random().Next(0, 11);
                rekaGracza += karty[los];
            }
            los = new Random().Next(0, 11);
            rekaKrupiera += karty[los];
            if (rekaGracza == 21)
            {
                Console.WriteLine("==========================================================================");
                Console.WriteLine("                      Dealer's Deck: " + rekaKrupiera);
                Console.WriteLine("==========================================================================");
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("==========================================================================");
                Console.WriteLine("                      Your hand: " + rekaGracza + " - You win!");
                Console.WriteLine("==========================================================================");
                wartosciKartGraczy[0] = rekaGracza;
                wartosciKartGraczy[1] = rekaKrupiera;
                return wartosciKartGraczy;
            }
            else
            {
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("==========================================================================");
                Console.WriteLine("                      Dealer's Deck: " + rekaKrupiera);
                Console.WriteLine("==========================================================================");
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("==========================================================================");
                Console.WriteLine("                      Your hand: " + rekaGracza);
                Console.WriteLine("==========================================================================");
            }
            wartosciKartGraczy[0] = rekaGracza;
            wartosciKartGraczy[1] = rekaKrupiera;
            return wartosciKartGraczy;
        }



        static int[] ruchGracza(int rekaGracza, int rekaKrupiera)
        {
            int[] wartosci = { 0, 0 };
            int odp = 1;
            while (odp == 1)
            {
                Console.WriteLine("Your move:");
                Console.WriteLine("1 - Hit");
                Console.WriteLine("2 - Stand");
                odp = Convert.ToInt32(Console.ReadLine());
                if (odp == 1)
                {
                    rekaGracza = dobierzGracz(rekaGracza);
                    Console.Clear();
                    Console.WriteLine("1.The cards are dealt.");
                    Console.WriteLine("==========================================================================");
                    Console.WriteLine("                      Dealer's Deck: " + rekaKrupiera);
                    Console.WriteLine("==========================================================================");
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("==========================================================================");
                    Console.WriteLine("                      Your hand: " + rekaGracza);
                    Console.WriteLine("==========================================================================");
                }
                if (rekaGracza == 21)
                {
                    Console.Clear();
                    Console.WriteLine("1.The cards are dealt.");
                    Console.WriteLine("==========================================================================");
                    Console.WriteLine("                      Dealer's Deck: " + rekaKrupiera);
                    Console.WriteLine("==========================================================================");
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("==========================================================================");
                    Console.WriteLine("                      Your hand: " + rekaGracza + " - You win!");
                    Console.WriteLine("==========================================================================");
                    odp = 2;
                }
                if (rekaGracza > 21)
                {
                    Console.Clear();
                    Console.WriteLine("1.The cards are dealt.");
                    Console.WriteLine("==========================================================================");
                    Console.WriteLine("                      Dealer's Deck: " + rekaKrupiera);
                    Console.WriteLine("==========================================================================");
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("==========================================================================");
                    Console.WriteLine("                      Your hand: " + rekaGracza + " - You lose");
                    Console.WriteLine("==========================================================================");
                    wartosci[0] = rekaGracza;
                    wartosci[1] = rekaKrupiera;
                    return wartosci;
                }
            }
            wartosci[0] = rekaGracza;
            wartosci[1] = rekaKrupiera;
            return wartosci;
        }

        static void ruchKrupiera(int rekaGracza, int rekaKrupiera)
        {
            int[] odp = { 0, 0 };
            int whileRun = 1;
            while (whileRun == 1)
            {
                if (rekaKrupiera < rekaGracza)
                {
                    rekaKrupiera = dobierzKrupier(rekaKrupiera);
                }

                if (rekaKrupiera > rekaGracza && rekaKrupiera <= 21)
                {
                    whileRun = 0;
                    Console.WriteLine("==========================================================================");
                    Console.WriteLine("                      Dealer's Deck: " + rekaKrupiera);
                    Console.WriteLine("==========================================================================");
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("==========================================================================");
                    Console.WriteLine("                      Your hand: " + rekaGracza + " - You lose");
                    Console.WriteLine("==========================================================================");
                }

                if (rekaKrupiera > 21)
                {
                    whileRun = 0;
                    Console.WriteLine("==========================================================================");
                    Console.WriteLine("                      Dealer's Deck: " + rekaKrupiera);
                    Console.WriteLine("==========================================================================");
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("==========================================================================");
                    Console.WriteLine("                      Your hand: " + rekaGracza + " - You win");
                    Console.WriteLine("==========================================================================");
                }
            }
        }

        static int dobierzGracz(int rekaGracza)
        {
            int[] karty = { 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10 };
            int los = new Random().Next(0, 11);
            rekaGracza += karty[los];
            return rekaGracza;
        }

        static int dobierzKrupier(int rekaKrupiera)
        {
            int[] karty = { 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10 };
            int los = new Random().Next(0, 11);
            rekaKrupiera += karty[los];
            return rekaKrupiera;
        }


        static void Main(string[] args)
        {
            int[] aktualnyStan = new int[2];
            aktualnyStan = rozdanieKart();
            aktualnyStan = ruchGracza(aktualnyStan[0], aktualnyStan[1]);
            if (aktualnyStan[0] > 21)
            {

            }
            else
            {
                ruchKrupiera(aktualnyStan[0], aktualnyStan[1]);
            }
        }
    }
}
