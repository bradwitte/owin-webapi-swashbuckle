using System;
using Microsoft.Owin.Hosting;
using System.Configuration;
using System.Threading;
using WebAPIMono;

namespace WebAPISelf
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string baseAddress = "http://*:" + ConfigurationManager.AppSettings["PORT"]; 

			// Start OWIN host 
			using (WebApp.Start<Startup>(url: baseAddress))
			{
				Console.WriteLine("Press [enter] to quit...");
				while (1==1) {
					Thread.Sleep (1000);
				}
				Console.ReadLine();
			}
		}
	}
}
