using System;

namespace MoreDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
			var random = new Random();
			var randomNumber = random.Next(1, 50);
			int userInput;

			do
			{
				Console.WriteLine($"Please guess a number between 1 - 50:");

				userInput = int.Parse(Console.ReadLine());

				if (userInput > randomNumber)
				{
					Console.WriteLine("Too High");
				}
				else if (userInput < randomNumber)
				{
					Console.WriteLine("Too Low");
				}
				else
				{
					Console.WriteLine("Nice Work!");
				}
			} while (userInput != randomNumber);
		}
    }
}
