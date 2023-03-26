using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klinika
{
    public class Adres
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Street { get; set; }

        public Adres(string firstName, string lastName, string street)
        {
            FirstName = firstName;
            LastName = lastName;
            Street = street;
        }
    }
}
