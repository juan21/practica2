/*
 * Created by SharpDevelop.
 * User: Juan Carlos
 * Date: 19/09/2013
 * Time: 07:56 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace practica2
{
	public class menuprincipal
	{
		public static void Main(string[] args)
       
		{
			reloj r;
			cronometro c;
			Console.WriteLine("Menu");
		    Console.WriteLine("1.Hora");
		    Console.WriteLine("2.Cronometro");
		    
		    int opc=int.Parse(Console.ReadLine());
		    
		    switch (opc)
		    {
		    		case 1: r= new reloj();
		    		r.GetHashCode();
		    
		    break;
		    
		   case 2:  c= new cronometro();
		   c.GetHashCode();
		            break;
		           default:Console.WriteLine("NO VALIDO");
		            break;
		    }
		    Console.WriteLine("Press any key to continue . . .");
		    Console.ReadKey(true);
		}
	}
}
