namespace HelloWorld
{
	class Program
	{
		static void Main(string[] args)
		{
			// Kon'nichiwa World
			// Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");
			Console.WriteLine("What is your name?");
			var name = Console.ReadLine();
			var currentDate = DateTime.Now;
			Console.WriteLine($"{Environment.NewLine}Hello, {name}, on {currentDate:d} at {currentDate:t}!");

			var a = 1;
			var b = 2;
			var c = 7;
			int d;
			int e;

			d = c / (a + b);
			e = c % (a + b);

			Console.WriteLine($"{c}/({a}+{b})={d}");
			if (e!=0){
				Console.WriteLine($"The remainder is {e}");
			}


			Console.Write($"{Environment.NewLine}Press any key to exit...");
			Console.ReadKey(true);
		}
	}
}