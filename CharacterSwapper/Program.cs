using System;

namespace CharacterSwapper
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Bir string ifade girin: ");
            string input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Girdi boş olamaz.");
                return;
            }

            string result = SwapCharacters(input);

            Console.WriteLine(result);

            Console.WriteLine("Devam etmek için herhangi bir tuşa basın...");
            Console.ReadKey();
        }

        private static string SwapCharacters(string text)
        {
            char[] characters = text.ToCharArray();

            for (int i = 1; i < characters.Length; i++)
            {
                char temp = characters[i];
                characters[i] = characters[i - 1];
                characters[i - 1] = temp;
            }

            return new string(characters);
        }
    }
}
