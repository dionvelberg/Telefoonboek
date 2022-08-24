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
        public string FirstName
        {
            get { return firstName ?? ""; }
            set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get { return lastName ?? ""; }
            set
            {
                lastName = value;
            }
        }
        public string Age
        {
            get { return age ?? ""; }
            set
            {
                age = value;
            }
        }
        public string PhoneNumber
        {
            get { return phone ?? ""; }
            set
            {
                phone = value;
            }
        }

        public string Email
        {
            get { return email ?? ""; }
            set
            {
                email = value;
            }
        }
    }
}

