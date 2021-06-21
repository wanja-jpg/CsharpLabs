using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_lab2
{
    class Program
    {
        static void Main(string[] args)
        {
			int nn, nk;
			do
			{
				Console.WriteLine("nn=");
				nn = int.Parse(Console.ReadLine());
				Console.WriteLine("nk=");
				nk = int.Parse(Console.ReadLine());
				if (0 > nn || nn > nk)
				{
					Console.WriteLine("Невірні значення nn та nk");
				}
			} while (0 > nn || nn > nk);

			int a = 0;
			for (int k = nn; k < nk; k++)
			{
				a = (((-1) ^ k) * k + 8) / ((2 * k ^ 2) + k + 7);
			}
			Console.WriteLine("a=" + a);
		}
    }
}
