using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp.LINQ2
{
    public class ListJoin
    {
        static void Main(string[] args)
        {
 
            var result = (from order in DataClass.GetOrderList()
                join customer in DataClass.GetCustomerList() on order.CustomerID equals customer.ID
                select new
                {
                    Name = customer.FirstName + " " + customer.LastName,
                    Products = DataClass.GetProductList().Where(product => (order.ProductID == product.ID))
                });
            //System.Console.WriteLine("Count: " + result.Count() + "Length: " + result.ElementAt(0) + result.ElementAt(1) + result.ElementAt(2));
            foreach (var orders in result)
            {
                Console.WriteLine(orders.Name);
                foreach (var product in orders.Products)
                {
                    Console.WriteLine("-- {0}", product.ProductName);
                }
            }
        }
    }
}