namespace CreatingAddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AddressBook addressbook = new AddressBook();
            while (true)
            {
                Console.WriteLine("1 Create contact \n2 Display Contact\n3 Edit Contact");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        addressbook.CreateContact();
                        break;
                    case 2:
                        addressbook.DisplayContact();
                        break;
                    case 3:
                        addressbook.DisplayContact();
                        break;

                }
            }
        }
    }
}