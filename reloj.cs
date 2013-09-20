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
	/// Description of reloj.
	/// </summary>
	public class reloj
	{
		
		public reloj()
		{
		int h=DateTime.Now.Hour;
        int m=DateTime.Now.Minute;
        int s=DateTime.Now.Second;

			for (int a=h;a<24;a++){
		    	for (int b=m;b<60;b++){
		    		for (int c=s;c<60;c++){
						
						Console.Clear ();
		    			Console.WriteLine (a+":"+b+":"+c);	
		    			System.Threading.Thread.Sleep(1000);
		    			
		}
	}
}
		}
	}
}
