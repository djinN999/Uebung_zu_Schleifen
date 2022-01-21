using System;

namespace einfuehrungschleifen
{
	class schleifeneins
	{
		public static void Main(string[] args)
		{
			int rowone, rowtwo, rowthree, rowfour, rowfive, rowsix, rowseven;

			for (rowone = 13; rowone < 30; rowone += 4){
				Console.Write(rowone + " ");
			}

			Console.WriteLine();

			for (rowtwo = 2; rowtwo > -5; rowtwo -= 1){
				Console.Write(rowtwo + " ");
            }

			Console.WriteLine();

			for (rowthree = 2000; rowthree < 6001; rowthree += 1000){
				Console.Write(rowthree + " ");
			}

			Console.WriteLine();

			for (rowfour = 5; rowfour < 14; rowfour += 2){
				Console.Write("Z" + rowfour + " ");
			}

			Console.WriteLine();

			for (rowfive = 1; rowfive <4; rowfive += 1){
				Console.Write("ab" + rowfive + " ");
			}

			Console.WriteLine();

			for (rowsix = 2; rowsix < 23; rowsix += 9){
				Console.Write("c" + rowsix + " ");
				rowsix += 1;
				Console.Write("c" + rowsix + " ");
			}

			Console.WriteLine();

			for (rowseven = 13; rowseven < 46; rowseven += 4){

				if (rowseven < 25 && rowseven > 20){
					rowseven += 12;
                }
				Console.Write(rowseven + " ");
			}
		}
	}
}