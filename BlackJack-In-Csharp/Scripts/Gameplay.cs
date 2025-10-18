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

            if(chips > 0)
            {
            betMoment:
                Console.Clear();
                Console.WriteLine($"{playerName} you have {chips} chips.\nHow many chips do you want to bet?");
                if (int.TryParse(Console.ReadLine(), out bet))
                {
                    if(bet > chips)
                    {
                        Console.WriteLine("You cannot bet more chips than you have.");
                        Console.WriteLine("Press any key to try again");
                        Console.ReadKey();
                    }
                    if(bet == 0)
                    {
                        Console.WriteLine("you need to bet at least 1 chip");
                        Console.WriteLine("Press any key to try again");
                        Console.ReadKey();
                    }
                    else
                    {

                    }
                }
                else
                {
                    Console.WriteLine("Invalid bet amount, press eny key to try again");
                    Console.ReadKey();
                    goto betMoment;
                }


            }
            else
            {
                Console.WriteLine("You don´t have any tips ;(");
            }
        }
    }
}