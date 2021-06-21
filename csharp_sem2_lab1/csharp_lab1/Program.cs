using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_lab1
{
	public class Program
	{
		public static void Main()
		{
			static int Method(out int a) { a = 2; return a * 2; }
			static void Main()
			{
				int operand = 3;
				int result = Method(out operand);
				Console.WriteLine("{0}; {1};", operand, result);

			}
		}
	}
}
