/*
 * Created by SharpDevelop.
 * User: 7071-111
 * Date: 4/5/2018
 * Time: 11:28 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace hangman
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("welcome to Video Game Hangman!!");
			string[] videoGames = new string[3];
			videoGames[0] = "Dark Souls";
			videoGames[1] = "Cuphead";
			videoGames[2] = "Shovel Knight";
				
			Random rand = new Random();
			var wordChoice = rand.Next(0, 3);
			string mysteryWord = videoGames[wordChoice];
			char[] guess = new char[mysteryWord.Length];
			Console.Write("enter your letter: ");
			
			for (int x = 0; x < mysteryWord.Length; x++) {
				guess[x] = '*';
			}
			
			while (true) {
				char playerGuess = char.Parse(Console.ReadLine());
				for (int j = 0; j < mysteryWord.Length; j++) {
					if (playerGuess == mysteryWord[j]) {
						guess[j] = playerGuess;
					}
			    }
		
				Console.WriteLine(guess);
			}
			
				
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}