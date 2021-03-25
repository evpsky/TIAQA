using System;

namespace OOP_task1.Helpers
{
	public class TriesCheckHelper
	{
		private static readonly Random _random = new Random();
		private const int NumberOfTries = 3;
		private const double MinBorderValue = 0.5;
		private const double MaxBorderValue = 5;
		public double GetEnteredValue()
		{
			for (int i = 0; i <= NumberOfTries - 1; i++)
			{
				try
				{
					Console.ForegroundColor = ConsoleColor.Blue;
					Console.WriteLine("\nTry №{0}", i + 1);
					double entry = double.Parse(Console.ReadLine());
					double enteredValue = entry;

					if (enteredValue == 0)
                    {
						Console.ForegroundColor = ConsoleColor.Red;
						Console.Write("Error: You entered zero.\n");
						continue;
					}
					else if (enteredValue <= -1)
					{
						Console.ForegroundColor = ConsoleColor.Red;
						Console.Write("Error: You entered a negative value.\n");
						continue;
					}
					Console.ForegroundColor = ConsoleColor.Blue;
					return enteredValue;
				}
				catch (FormatException)
				{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.Write("Error: Only numbers are allowed.\n");
					continue;
				}
			}
			Console.ForegroundColor = ConsoleColor.Blue;
			double randomValue = Math.Round(GetRandomNumberBetween(MinBorderValue, MaxBorderValue), 2);
			Console.WriteLine("\nYou exceeded the number of tries. We will set default random value to  {0}", randomValue);
			return randomValue;
		}

		private static double GetRandomNumberBetween(double minValue, double maxValue)
		{
			return (_random.NextDouble() * (maxValue - minValue) + minValue);
		}
	}
}
