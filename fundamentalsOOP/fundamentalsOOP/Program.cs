using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace fundamentalsOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello world");
            Customer c1 = new Customer();
            Customer c2 = new Customer();
            Customer c3 = new Customer();

            Console.WriteLine("Customer count : "+ Customer.MyInstanceCount);

            Console.WriteLine("c1 valid: "+c1.Validate());

            c2.FirstName = "patricia";
            c2.LastName = "molina";

            Console.WriteLine("c2 valid: " + c2.Validate());
            Console.WriteLine("c2 money default : " + c2.Money);

            Console.WriteLine("c2 to string : "+ c2.ToString());
			Console.WriteLine("c2 to string : "+ c2.ToString());

            Console.ReadLine();
        }
    }
}
