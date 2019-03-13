using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp.LINQ
{
    
    class Adress
    {
        public Adress(string country, int postalCode, int state, string city, string street)
        {
            Country = country;
            PostalCode = postalCode;
            State = state;
            City = city;
            Street = street;
        }
       public string Country { get; set; }
       public int PostalCode { get; set; }
       public int State { get; set; }
       public string City { get; set; }
       public string Street { get; set; } 
    }

    class Customer
    {
        public Customer(int id, string firstName, string lastName, string email, string phoneNumber, Adress adress)
        {
            ID = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
            Adress = adress;
        }
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public Adress Adress { get; set; }
    }
    public class ToObjects
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>()
            {
              10,2,3,55,22,75,30,11,22,89  
            };
            //Option 1
            var result = (from number in list select number).Distinct(); // Distinct: delete duplicated element
            //Option 2
            var result1 = list.Select(
                delegate(int number){
                    return number;
                });
            // Option 3
            Func<int, int> selector = (x) => x;
            var result2 = list.Select(selector);

            foreach(var item in result){
                System.Console.WriteLine("{0}", item);
            }
            List<Customer> custList = new List<Customer>(){
                new Customer(1,"Szilvasi", "Peter", "peti.szilvasi95@gmail.com", "06306172289", new Adress("Magyarország", 3580, 0, "Tiszaújváros", "Deák tér 12. 3/4")),
                new Customer(1,"Szilvasi", "Imre", "imi.szilvasi@gmail.com", "06206172289", new Adress("Magyarország", 3580, 0, "Tiszaújváros", "Deák tér 12. 3/4")),
                new Customer(1,"Szilvasi", "Dora", "dori.szilvasi@gmail.com", "06306178922", new Adress("Magyarország", 3580, 0, "Tiszaújváros", "Deák tér 12. 3/4"))
            };
            // We get all the data even Address, but we don't need it
            var customerResult = from customer in custList select customer;
            foreach(var customer in customerResult){
                System.Console.WriteLine("Name: {0}, Email: {1}, Phone: {2}",
                customer.FirstName + " " + customer.LastName, customer.Email, customer.PhoneNumber);
            }
            // Projection with nameless class
            var customerResult1 = from customer in custList
                select new{
                    Name = customer.FirstName + " " + customer.LastName,
                    Email = customer.Email,
                    Phone = customer.PhoneNumber
                };

            string[] poem = new string[]
            {
                "Ej mi a kõ! tyúkanyó, kend",
                "A szobában lakik itt bent?",
                "Lám, csak jó az isten, jót ád,",
                "Hogy fölvitte a kend dolgát!"
            };
            // Declare variable with the 'let' keyword
            var poemResult = from line in poem let words = line.Split(' ') from word in words select word;
            // Selection
            var selection1 = from number in list where number > 30 select number;
            var selection2 = list.Where(number => number > 30);
            var selection3 = (from number in list select number).Where(number => number > 30);
            Func<int, bool> predicate = (x) => x > 30; // where predicate(number) or .Where(predicate)
            foreach(var item in selection1){System.Console.WriteLine(item);}
            // Ordering
            var ordering1 = list.OrderBy(x => x); // ascending
            var ordering2 = from number in list orderby number ascending select number; // ascending
            var ordering3 = from number in list orderby number descending select number; // descending
            OrderNames();
            //Grouping
            GroupNames();

        }
        private static List<string> names = new List<string>()
            {
                "Szandra", "István", "Iván", "Jolán", "Jenő", "Béla",
                "Balázs", "Viktória", "Vazul", "Töhötöm", "Tamás"
            };

        static void OrderNames(){
            var names = ToObjects.names;
            var result1 = names.OrderBy(name => name[0]).ThenBy(name => name[1]).ThenBy(name => name[2]);
            var result2 = from name in names orderby name[0], name[1], name[2] select name;
            
            foreach (var item in result1)
            {
                Console.WriteLine(item);
            }
        }

        static void GroupNames(){
            var names = ToObjects.names;
            var result1 = names.OrderBy(name => name[0]).GroupBy(name => name[0]);
            var result2 = from name in names orderby name[0] group name by name[0] into namegroup select namegroup;
            // Dealing with null value
            var result3 = from name in names 
                orderby name[0] 
                group name by 
                name == null ? '0' : name[0] 
                into namegroup 
                select namegroup;

            foreach(var group in result2){
                System.Console.WriteLine(group.Key);
                foreach(var name in group){
                    System.Console.WriteLine("-- {0}", name);
                }
            }
        }
    }
}