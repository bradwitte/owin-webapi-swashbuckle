using System;
using Microsoft.Owin.Hosting;
using WebAPIMono;

namespace WebAPISelf
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string baseAddress = "http://localhost:9000/"; 

			// Start OWIN host 
			using (WebApp.Start<Startup>(url: baseAddress))
			{
				Console.WriteLine("Press [enter] to quit...");
				Console.ReadLine();
			}
		}
	}
}
