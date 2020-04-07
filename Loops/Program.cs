using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    public class Program
    {
        static void Main(string[] args)
        {
			int data;


			Console.Write("\n\n");
			Console.Write("Ditet e javes se dyte te prillit 6-12 prill  : \n");
			Console.Write("-------------------------------------------");
			Console.Write("\n\n");


			Console.Write("Jep daten: ");
			data = Convert.ToInt32(Console.ReadLine());
				switch (data)
				{
					case 6:
						Console.Write("E Hene\n");
						break;
					case 7:
						Console.Write("E Marte \n");
						break;
					case 8:
						Console.Write("E Merkure \n");
						break;
					case 9:
						Console.Write("E Enjte \n");
						break;
					case 10:
						Console.Write("E Premte \n");
						break;
					case 11:
						Console.Write("E Shtune \n");
						break;
					case 12:
						Console.Write("E Diele \n");

						break;

					default:
						Console.Write(" Data nuk i perket kesaj jave . \n Provo brenda dates 6-12 prill....\n");
						break;

				}
				Console.ReadKey();
		}
		
	}
	
}

