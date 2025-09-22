namespace CreateName
{
    public class CreateNameClass
    {
        // Variável pública e estática para ser acessada de fora
        public static string name = "";

        public static void CreateNameFunction()
        {
            //Var for the player name and confirmation
            char answer = 'N';

            do
            {
                Console.Write("Type your name: ");
                name = Console.ReadLine().ToUpper();
                if (string.IsNullOrWhiteSpace(name))
                {
                    Console.Clear();
                    Console.WriteLine("Name cannot be empty. Please try again.");
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                }

                Console.Clear();
                Console.WriteLine($"Is your name {name} ?");
                Console.WriteLine("'y' for yes / 'any other key' for no");
                string input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                {
                    answer = 'N';
                }
                else
                {
                    answer = char.ToUpper(input[0]);
                }

                if (answer == 'Y')
                {
                    Console.Clear();
                    Console.WriteLine($"OK {name} !");
                }
                else
                {
                    Console.Clear();
                    continue;
                }
            } while (answer != 'Y');
        }
    }
}
