/*
 * Created by SharpDevelop.
 * User: Worker_2
 * Date: 21.06.2022
 * Time: 11:54
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace dasd
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			string symbols = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
			string result = "";
			Random rnd = new Random();
			for(int i = 0; i<4;i++){
				if (i==0 || i==2){
					result+=Convert.ToString(rnd.Next(111,1000));
							
				}
				
				else{
					var index = rnd.Next(symbols.Length);
    				result+=symbols[index];
				}
			}
			
			
			Console.WriteLine(result);
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}