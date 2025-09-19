using Gameplay;

public class BlackJackMain
{
    static void Main()
    {
        //Var for the player name
        string name;

        Console.WriteLine("WELCOME TO MY NEW BLACKJACK GAME!!!");
        Console.ReadKey();
        Console.WriteLine("Press any key when you are ready!");
        Clear();


    }

    public static void Clear()
    {
        Console.ReadKey();
        Console.Clear();
    }
}