using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_task1.Helpers
{
    public class RandomNubmer
    {
        public double GetEnteredValue()
        {
            for (int i = 0; i <= 2; i++)
            {
				try
				{
					var entry = Console.ReadLine();
					var enteredValue = double.Parse(entry);

					if (enteredValue <= 0)
					{
						Console.Write("ERR:You entered a negative value.\n");
						continue;
					}
					return enteredValue;
				}
				catch (FormatException)
				{
					Console.Write("ERR:Only numbers are allowed.\n");
					continue;
				}
			}
        }
    }
}
