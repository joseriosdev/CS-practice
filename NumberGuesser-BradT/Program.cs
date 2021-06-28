using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace practicaC { // this namespace is basically a container of classes and functions
	class Program {
		static void Main(string[] args) {
			GetAppInfo();

			Console.WriteLine("What's your name?");
			string inputName = Console.ReadLine();
			Console.WriteLine($"Hello {inputName}, let's play a game...");
			
			PlayNumberGuesserGame(inputName);
		}

		static void GetAppInfo() {
			string appName = "Number Guesser";
			string appVersion = "v0.1.0";
			string appAuthor = "Jose Rios";
			string inspiredBy = "based on Brad's tutorial";
			
			Console.ForegroundColor = ConsoleColor.Blue;
			Console.WriteLine("{0}: {1} by {2} {3}", appName, appVersion, appAuthor, inspiredBy);
			Console.ResetColor();
		}

		static void PlayNumberGuesserGame(string name) {
			while(true) {
				Random random = new Random();
				int numberToGuess = random.Next(1, 11);
				int guess = -1;

				Console.WriteLine("Guess a number between 1 and 10");

				while(guess != numberToGuess) {
					string input = Console.ReadLine();
					
					if(!Int32.TryParse(input, out guess)) {
						PrintColoredMessage(ConsoleColor.Red, "Please, use an actual number");
						continue;
					}

					guess = Int32.Parse(input);

					if(guess != numberToGuess) {
						PrintColoredMessage(ConsoleColor.Red, "Wrong number, please try again");
					}
				}

				PrintColoredMessage(ConsoleColor.Green, $"{name} your guess is CORRECT!");
				Console.WriteLine("Wnat to play again? [Y or N]");
				string playAgainAnswer = Console.ReadLine().ToUpper();

				if(playAgainAnswer == "Y") {
					continue;
				} else {
					return;
				}
			}
		}

		static void PrintColoredMessage(ConsoleColor color, string message){
			Console.ForegroundColor = color;
			Console.WriteLine(message);
			Console.ResetColor();
		}
	}
}
