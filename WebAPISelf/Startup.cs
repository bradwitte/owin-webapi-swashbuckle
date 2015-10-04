using System;
using Owin;
using System.Web.Http;
using Swashbuckle.Application;

namespace WebAPIMono
{
	public class Startup
	{
		public void Configuration(IAppBuilder appBuilder)
		{
			HttpConfiguration httpConfiguration = new HttpConfiguration();
			WebApiConfig.Register(httpConfiguration);

			httpConfiguration
				.EnableSwagger(c => c.SingleApiVersion("v1", "Customer API"))
				.EnableSwaggerUi(); 

			appBuilder.UseWebApi(httpConfiguration);
		}
	}
}

