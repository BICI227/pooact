using System;
using System.Collections.Generic;

class Peliculas

	{
		private string nombre;

		private int año;

		private string pais;

		private string director;

		public void imprime()

			{

			Console.WriteLine(nombre + año + pais + director);

			}

			public  Peliculas(string n, int a, string p, string d)
			{

			this.nombre = n;
			this.año = a;
           	this.pais = p;
           	this.director = d;

			}

		}

		public class Program

		{
			static void Main(String[] args)
			{
				Console.WriteLine("|----------------------------------------------------------------|");
				List<Peliculas> P = new List<Peliculas>();
				P.Add(new Peliculas("|       Joker          (", 2019,")  |USA|  ", "      Todd Phillips        |"));
				P.Add(new Peliculas("|The Lord Of The Rings (", 2003,")  |USA|  ", "      Peter Jackson        |"));
				P.Add(new Peliculas("|      Titanic         (", 1997,")  |USA|  ", "      James Cameron        |"));
				P.Add(new Peliculas("|     La La Land       (", 2016,")  |USA|  " ,"     Damien Chazelle       |" ));
				P.Add(new Peliculas("|    Toy Story 4       (", 2019,")  |USA|  ", "       Josh Cooley         |"));
				
				
				foreach(Peliculas a in P)
					{
					a.imprime();
					}
				Console.WriteLine("|----------------------------------------------------------------|");
			}    
    
}