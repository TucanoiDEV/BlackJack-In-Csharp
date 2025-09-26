using CreateName;

namespace Gameplay
{
    public class GameplayClass
    {
        public static void GameplayFunction()
        {
            int chips = 500;
            int bet;

            //Alocação de variável name de CreateName para o arquivo de Gameplay
            string playerName = CreateNameClass.name;

            do
            {
                Console.WriteLine($"You have {chips} chips");
                Console.Write($"{playerName}, Enter the amount to bet: ");
                bet = Console.ReadLine();

                if (!int.TryParse(input, out bet) || bet <= 0 || bet > chips)
                {
                    Console.WriteLine("Invalid bet, please try again");
                    Console.WriteLine("[Press any key to continue]");
                    Console.ReadKey();
                    bet = -1;
                }
            } while(bet <= 0 || bet > chips);
        }
    }
}