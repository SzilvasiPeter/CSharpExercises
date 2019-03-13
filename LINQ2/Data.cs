using System;
using System.Collections.Generic;

static class DataClass
{
	static public List<Customer> GetCustomerList()
	{
		return new List<Customer>()
		{
			new Customer()
			{
				ID = 1, FirstName = "Istvan", LastName = "Reiter", Email = "reiteristvan@reiter.hu",
				PhoneNumber = null, Address = new Address()
				{
					Country = "Magyarország", PostalCode = 2252, State = "Pest",
					City = "Tóalmás", Street = "Titok 52."
				}
			},
			new Customer()
			{
				ID = 2, FirstName = "József", LastName = "Fekete", Email = "feketej@freemail.hu",
				PhoneNumber = "+362014785633", Address = new Address()
				{
					Country = "Magyarország", PostalCode = 3456, 
					State = "Pest", City = "Szolnok", Street = "Hajó 67."
				}
			},
			new Customer()
			{
				ID = 3, FirstName = "Balázs", LastName = "Kiss", Email = "kissbalazs@aludjel.hu",
				PhoneNumber = "+36501214000", Address = new Address()
				{
					Country = "Magyarország", PostalCode = 5678, State = "BAZ",
					City = "Bivajbasznód", Street = "T�zolt� 40."
				}
			},
			new Customer()
			{
				ID = 4, FirstName = "János", LastName = "Kovács", Email = null,
				PhoneNumber = "+36559864756", Address = new Address()
				{
					Country = "Magyarország", PostalCode = 5599, State = "Tolna",
					City = "Százholdas Pagony", Street = "Medve 22."
				}
			}
		};
	}
	
	static public List<Product> GetProductList()
	{
		return new List<Product>()
		{
			new Product() { ID = 1, ProductName = "Elektromos vízforraló", Quantity = 10 },
			new Product() { ID = 2, ProductName = "Pénztárca", Quantity = 100 },
			new Product() { ID = 3, ProductName = "Elosztó", Quantity = 50 },
			new Product() { ID = 4, ProductName = "Papírzsebkendő", Quantity = 100 }
		};
	}
	
	static public List<Order> GetOrderList()
	{
		return new List<Order>()
		{
			new Order() { CustomerID = 1, ProductID = 3, OrderDate = new DateTime(2010, 3, 26),
				DeliverDate = new DateTime(2010, 4, 7), Note = null },
			new Order() { CustomerID = 1, ProductID = 4, OrderDate = new DateTime(2010, 6, 2),
				DeliverDate = null },
			new Order() { CustomerID = 2, ProductID = 1, OrderDate = new DateTime(2010, 6, 1),
				DeliverDate = null, Note = "blabla"  }
		};
	}
}

class Address
{
	public string Country { get; set; }
	public int PostalCode { get; set; }
	public string State { get; set; }
	public string City { get; set; }
	public string Street { get; set; }
}

class Customer
{
	public int ID { get; set; }
	public string FirstName { get; set; }
	public string LastName { get; set;}
	public string Email { get; set; }
	public string PhoneNumber { get; set; }
	public Address Address { get; set; }
}

class Order
{
	public int CustomerID { get; set; }
	public int ProductID { get; set; }
	public DateTime OrderDate { get; set; }
	public DateTime? DeliverDate { get; set; }
	public string Note { get; set; }
}

class Product
{
	public int ID { get; set; }
	public string ProductName { get; set; }
	public int Quantity { get; set; }
}