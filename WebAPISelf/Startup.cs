using System;
using Owin;
using System.Web.Http;

namespace WebAPIMono
{
	public class Startup
	{
		public void Configuration(IAppBuilder appBuilder)
		{
			HttpConfiguration httpConfiguration = new HttpConfiguration();
			WebApiConfig.Register(httpConfiguration);
			appBuilder.UseWebApi(httpConfiguration);
		}
	}
}

