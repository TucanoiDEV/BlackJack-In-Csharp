namespace Randomizer
{
    public class Randomizer
    {
        public static void cardReceived()
        {
            //string Spades = "\u2660"; ou "♠"
            //string Clubs = "\u2663"; ou "♣"
            //string Hearts = "\u2665"; ou "♥"
            //string Diamonds = "\u2666"; ou "♦"

            //Cards List
            List<string> cheap = new List<string> 
            {
                "A ♠", "2 ♠", "3 ♠", "4 ♠", "5 ♠", "6 ♠", "7 ♠", "8 ♠", "9 ♠", "10 ♠", "J ♠", "Q ♠", "K ♠",
                "A ♣", "2 ♣", "3 ♣", "4 ♣", "5 ♣", "6 ♣", "7 ♣", "8 ♣", "9 ♣", "10 ♣", "J ♣", "Q ♣", "K ♣",
                "A ♥", "2 ♥", "3 ♥", "4 ♥", "5 ♥", "6 ♥", "7 ♥", "8 ♥", "9 ♥", "10 ♥", "J ♥", "Q ♥", "K ♥",
                "A ♦", "2 ♦", "3 ♦", "4 ♦", "5 ♦", "6 ♦", "7 ♦", "8 ♦", "9 ♦", "10 ♦", "J ♦", "Q ♦", "K ♦"
            };

            Random randomCard = new Random();
            
            //Preciso continuar o loop
        }
    }
}
