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
        public void EditContact()
        {
            Console.WriteLine("To Edit Contact Enter  First Name");
            string name = Console.ReadLine();
            foreach (var record in data)
            {
                if (record.Firstname == name)
                {
                    while (true)
                    {
                        Console.WriteLine("Enter the option to Edit the Contact: ");
                        Console.WriteLine("1 to Change First name \n2 to Change Last name \n3 to Change Address  \n4 to Change City  \n5 to Change State  \n6 to Change Zip  \n7 to Change Phonenumber  \n8 to Change Email \n9 Exit");

                        int Check = Convert.ToInt32(Console.ReadLine());
                        switch (Check)
                        {
                            case 1:
                                Console.WriteLine("Enter the New First Name: ");
                                record.Firstname = Console.ReadLine();
                                break;
                            case 2:
                                Console.WriteLine("Enter the New Last Name: ");
                                record.Lastname = Console.ReadLine();
                                break;
                            case 3:
                                Console.WriteLine("Enter the New Address: ");
                                record.Address = Console.ReadLine();
                                break;
                            case 4:
                                Console.WriteLine("Enter the New City: ");
                                record.City = Console.ReadLine();
                                break;
                            case 5:
                                Console.WriteLine("Enter the New State: ");
                                record.State = Console.ReadLine();
                                break;
                            case 6:
                                Console.WriteLine("Enter the New Pin Code: ");
                                record.Zip = Convert.ToInt32(Console.ReadLine());
                                break;
                            case 7:
                                Console.WriteLine("Enter the New Phone Number: ");
                                record.Phonenumber = Convert.ToInt64(Console.ReadLine());
                                break;
                            case 8:
                                Console.WriteLine("Enter the New Email: ");
                                record.Email = Console.ReadLine();
                                break;
                            case 9:
                                return;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Enter the valid name!");
                }
            }
        }
    }
}