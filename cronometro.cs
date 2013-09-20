/*
 * Created by SharpDevelop.
 * User: Juan Carlos
 * Date: 19/09/2013
 * Time: 07:57 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace practica2
{
	/// <summary>
	/// Description of cronometro.
	/// </summary>
	public class cronometro
	{
		public cronometro()
		{
			for (int w=0;w<24;w++){
		    	for (int x=0;x<60;x++){
		    		for (int z=0;z<60;z++){
						
						Console.Clear ();
		    			Console.WriteLine (w+":"+x+":"+z);	
		    			System.Threading.Thread.Sleep (1000);
		}
	}
}
		}
	}
}
