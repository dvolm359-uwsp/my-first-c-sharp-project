using System;

namespace LocalDB_assign
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c = CustomerDB.GetCustomer(1234);
            Console.WriteLine("CustomerID");
            Console.WriteLine(c.CustomerID);
            Console.WriteLine("CompanyName");
            Console.WriteLine(c.CompanyName);
            Console.WriteLine("ContactName");
            Console.WriteLine(c.ContactName);
        }
    }
}
