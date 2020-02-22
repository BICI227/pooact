﻿using System;

namespace Pelicula
{
   public class Pelicula
   {

	private string titulo;
	private int año;
	private string pais;
	private string director;
	
	public void SetTitulo(string n){
		titulo = n;	
        
	}


	public string GetTitulo(){
		return titulo;	
	}
	

	public void SetAño(int y){
		año = y;	
	}
	

	public int GetAño(){
		return año;	
	}
	
}


public class Program
{
	
	public static void Main()
	{
		Pelicula p1 = new Pelicula();
		p1.SetTitulo("Joker");
		p1.SetAño(2019);
		
		Pelicula p2 = new Pelicula();
		p2.SetTitulo("Titanic");
		p2.SetAño(1997);
		
		Console.WriteLine(p1.GetTitulo() + "\t" + p1.GetAño() + "\n" + p2.GetTitulo() + "\t" + p2.GetAño());
		
	}
} 
        

    
}
