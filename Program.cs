using System;

namespace VendingMachine
{
	class MainClass
	{
		
		 static void Main()
		{
			DrinkMachine drinkMachine  = new DrinkMachine();

			Console.WriteLine ("Hello, this is our selection of drinks:");
			Console.WriteLine ("****************");
			Console.WriteLine("C - Coka Cola   *");
			Console.WriteLine("P - Pepsi       *");
			Console.WriteLine("S - Sprite      *");
			Console.WriteLine ("****************");
			Console.WriteLine ("A drink costs 150 If you would like a drink please enter a valid amount of money (5,25,50,100)");

			while(!drinkMachine.CheckTotal())
			{
				
				drinkMachine.DepositCoin(Convert.ToInt32(Console.ReadLine()));
			}

			drinkMachine.DisplayDrinkSelection();
			Console.WriteLine ();
		}

	}
}
