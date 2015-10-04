using System;
using System.Web.Http;
using System.Collections.Generic;

namespace WebAPIMono
{
	/// <summary>
	/// Customers controller.
	/// </summary>
	public class CustomersController : ApiController
	{
		/// <summary>
		/// Get a list of customers
		/// </summary>
		public IHttpActionResult Get()
		{
			IList<Customer> customers = new List<Customer>();
			customers.Add(new Customer() { Name = "Nice customer", Address = "USA", Telephone = "123345456" });
			customers.Add(new Customer() { Name = "Good customer", Address = "UK", Telephone = "9878757654" });
			customers.Add(new Customer() { Name = "Awesome customer", Address = "France", Telephone = "34546456" });
			return Ok<IList<Customer>>(customers);
		}
	}
}

