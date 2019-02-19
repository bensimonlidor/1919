using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lid1902
{
	class Program
	{
		static void Main(string[] args)
		{
			int a, b;
			Console.WriteLine("Please enter 2 numbers:");
			a = Convert.ToInt32(Console.ReadLine());
			b = Convert.ToInt32(Console.ReadLine());
			if (a > b)
			{
				Console.WriteLine(a);
			}
			else
			{
				Console.WriteLine(b);
			}
		}
	}
}
