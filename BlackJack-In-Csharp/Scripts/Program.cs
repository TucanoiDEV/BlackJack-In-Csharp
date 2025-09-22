using Gameplay;
using CreateName;
using System.Threading;

public class BlackJackMain
{
    static void Main()
    {
        Console.WriteLine("WELCOME TO MY NEW BLACKJACK GAME!!!");
        Console.WriteLine("press any key when you are ready!");
        Clear();

        CreateNameClass.CreateNameFunction();
        GameplayClass.GameplayFunction();


    }

    public static void Clear()
    {
        Console.ReadKey();
        Console.Clear();
    }
}