using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingAddressBook
{
    internal class Contact
    {
        public String Firstname { get; set; }
        public String Lastname { get; set; }
        public String Address { get; set; }
        public String City { get; set; }
        public String State { get; set; }
        public int Zip { get; set; }
        public long Phonenumber { get; set; }
        public String Email { get; set; }
    }
}
