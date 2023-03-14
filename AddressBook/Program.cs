using System;
namespace AddressBook
{
    public class program
    {
        public void Main(string[] args)
        {
            Contact contact = new Contact();
            Console.WriteLine("Enter FirstName");
            contact.firstName = Console.ReadLine();
            Console.WriteLine("Enter lastName");
            contact.lastName = Console.ReadLine();
            Console.WriteLine("Enter Address");
            contact.Address = Console.ReadLine();
            Console.WriteLine("Enter City");
            contact.City = Console.ReadLine();
            Console.WriteLine("Enter State");
            contact.state = Console.ReadLine();
            Console.WriteLine("Enter Zip");
            contact.Zip = Console.ReadLine();
            Console.WriteLine("Enter PhoneNumber");
            contact.PhoneNumber = Console.ReadLine();
            Console.WriteLine("Enter Email");
            contact.Email = Console.ReadLine();
        }
    }
}