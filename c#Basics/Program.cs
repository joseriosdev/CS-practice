using System;

namespace c_Basics
{
	class Program
	{
		static void Main(string[] args)	{
			Console.ForegroundColor = ConsoleColor.Blue;

			TypeConversionAndVars();
		}

		static void TypeConversionAndVars() {
			// We need to specify the variable type and remember that is different to say C# vs .NET
			// Overflowing exits (when a var on his bytes exceeds the memory storage) and might be data loss
			// Casting looks like this:
			int i = 1;
			byte b = (byte) i;
			System.Console.WriteLine(b);

			char s = '2';
			var str = "12";
			int num = Convert.ToInt32(s); // converts it to UTF-8 value (50)
			int number = Int32.Parse(str);
			const float PI = 3.14f;

			Console.WriteLine("");
			// Console.WriteLine("{0}, {1}", decimal.MinValue, decimal.MaxValue);
			System.Console.WriteLine(number + PI);
			

			// Let's do a try catch
			try {
				var randomNum = "1230";
				byte j = Convert.ToByte(randomNum);
				System.Console.WriteLine(j);
			} catch(Exception) {
				System.Console.WriteLine("unable to convert number to byte");
			}
		}
	}
}
