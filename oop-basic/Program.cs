using System;

namespace Oop_basic{
	class Program	{
		static void Main(string[] args)	{
			Console.ForegroundColor = ConsoleColor.Blue;
			var alfonso = new Person("Ramirez", "Alfonso", 30);
			Person natalia = new Person("Acevedo", "Natalia", 20);
			var jaimito = new Estudiante("Moreno", "Jaime", 15, true);

			alfonso.Saludo();
			natalia.Saludo();

			Console.Read();

			jaimito.Saludo();
		}
	}
}
