using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_task1.Helpers
{
	public class HelperStepsTriesCheck
	{
		public double GetEnteredValue()
		{
			for (int i = 0; i <= 2; i++)
			{
				try
				{
					Console.WriteLine("\nTry №{0}", i + 1);
					double entry = double.Parse(Console.ReadLine());
					double enteredValue = entry;

					if (enteredValue <= 0)
					{
						Console.Write("Error: You entered a negative value.\n");
						continue;
					}
					return enteredValue;
				}
				catch (FormatException)
				{
					Console.Write("Error: Only numbers are allowed.\n");
					continue;
				}
			}
			double randomValue = Math.Round(GetRandomNumberBetween(0.5, 5), 2);
			Console.WriteLine("\nYou exceeded the number of tries. We will set default random value to  {0}", randomValue);
			return randomValue;
		}
		private static readonly Random random = new Random();

		private static double GetRandomNumberBetween(double minValue, double maxValue)
		{
			double next = random.NextDouble();
			return (next * (maxValue - minValue) + minValue);
		}
	}
}
