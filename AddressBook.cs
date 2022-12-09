using CreatingAddressBook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingAddressBook
{
    internal class AddressBook
    {
        List<Contact> data = new List<Contact>();
        public void CreateContact()
        {
            Contact contact = new Contact();
            Console.WriteLine("Enter Firstname");
            contact.Firstname = Console.ReadLine();
            Console.WriteLine("Enter Lastname");
            contact.Lastname = Console.ReadLine();
            Console.WriteLine("Enter Address");
            contact.Address = Console.ReadLine();
            Console.WriteLine("Enter City");
            contact.City = Console.ReadLine();
            Console.WriteLine("Enter State");
            contact.State = Console.ReadLine();
            Console.WriteLine("Enter Zip");
            contact.Zip = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Phonenumber");
            contact.Phonenumber = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter Email");
            contact.Email = (Console.ReadLine());
            data.Add(contact);
        }
        public void DisplayContact()
        {
            foreach (Contact record in data)
            {
                Console.WriteLine("Firstname - " + record.Firstname);
                Console.WriteLine("Lastname - " + record.Lastname);
                Console.WriteLine("Address - " + record.Address);
                Console.WriteLine("City - " + record.City);
                Console.WriteLine("State - " + record.State);
                Console.WriteLine("Zip - " + record.Zip);
                Console.WriteLine("Phonenumber - " + record.Phonenumber);
                Console.WriteLine("Emai - " + record.Email);
            }

        }
    }
}