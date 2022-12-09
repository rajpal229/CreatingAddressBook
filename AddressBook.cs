using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingAddressBook
{
    internal class AddressBook
    {
        public void CreatContact()
        {
            Contact contact= new Contact(); 
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
            contact.Zip =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Phonenumber");
            contact.Phonenumber = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter Email");
            contact.Email = (Console.ReadLine());
        }
    }
}
