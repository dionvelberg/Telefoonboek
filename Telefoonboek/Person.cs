using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telefoonboek
{
    public class Person
    {
        private string? firstName;
        private string? lastName;
        private string? age;
        private string? phone;
        private string? email;
        public string FirstName {
            get => firstName ?? "";
            set => firstName = value;   
        }
        public string LastName {
            get => lastName ?? "";
            set => lastName = value;
        }
        public string Age {
            get => age ?? "";
            set => age = value;
        }
        public string PhoneNumber {
            get => phone ?? "";
            set => phone = value;
        }

        public string Email {
            get => email ?? "";
            set => email = value;
        }
        public PersonAddress? Address { get; set; }
    }
}

