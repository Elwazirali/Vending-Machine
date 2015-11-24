using System;

namespace VendingMachine
{
	public class DrinkMachine
	{
		const int COST_OF_DRNK = 150;
		public int RunningTotal{ get; set;}

		public DrinkMachine ()
		{
			this.RunningTotal = 0;
		}


		public void DepositCoin(int money_entered)
		{
			
			switch (money_entered) 
			{
			case(5): 
				RunningTotal += 5;
				if(RunningTotal<COST_OF_DRNK){Console.WriteLine ("{0} more to go!", COST_OF_DRNK-RunningTotal);}
				break;
			case(25): 
				RunningTotal += 25;
				if(RunningTotal<COST_OF_DRNK){Console.WriteLine ("{0} more to go!", COST_OF_DRNK-RunningTotal);}
				break;
			case(50): 
				RunningTotal += 50;
				if(RunningTotal<COST_OF_DRNK){Console.WriteLine ("{0} more to go!", COST_OF_DRNK-RunningTotal);}
				break;
			case(100): 
				RunningTotal += 100;
				if(RunningTotal<COST_OF_DRNK){Console.WriteLine ("{0} more to go!", COST_OF_DRNK-RunningTotal);}
				break;
			default:
				Console.WriteLine ("Invalid entry");
				break;
			}

		}

		public bool CheckTotal()
		{
			if (RunningTotal >= COST_OF_DRNK) {
				return true;
			} 
			else 
			{
				return false;
			}
		}

		public void DisplayDrinkSelection()
		{
			Console.WriteLine ("****************");
			Console.WriteLine("C - Coka Cola   *");
			Console.WriteLine("P - Pepsi       *");
			Console.WriteLine("S - Sprite      *");
			Console.WriteLine ("****************");
			Console.WriteLine ();
			Console.WriteLine ("please make your selection!");
			MakeDrinkSelection (Convert.ToChar (Console.ReadLine ().ToUpper())); //Calling the MakeDrinkSelection method and passing in a parameter (Char) that determines what drink has been chosen...
		}

		public void MakeDrinkSelection(char selection)
		{
			bool SelectionOk = false;
			while (!SelectionOk)
			{
				switch (selection) 
				{
				case('C'):
					Console.WriteLine ("Thank you for choosing Coca Cola, enjoy your drink!");
					ReturnChange();
					SelectionOk = true;
					break;
				case('P'):
					Console.WriteLine ("Thank you for choosing Pepsi, enjoy your drink!");
					ReturnChange();
					SelectionOk = true;
					break;
				case('S'):
					Console.WriteLine ("Thank you for choosing Sprite, enjoy your drink!");
					ReturnChange();
					SelectionOk = true;
					break;
				default:
					Console.WriteLine("Please make a valid selection from the menu displayed above...");
					selection = Convert.ToChar(Console.ReadLine().ToUpper());
					SelectionOk = false;
					break;
				}
			}


		}

		public void ReturnChange()
		{
			if (RunningTotal > COST_OF_DRNK) 
			{
				Console.WriteLine ("Your Change is {0:C}", (RunningTotal - COST_OF_DRNK) * 0.01);
			}
		}
	}
}

