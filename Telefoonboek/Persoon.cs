using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telefoonboek
{
    public class Persoon
    {
        private string? firstName;
        private string? lastName;
        private string? age;
        private string? phone;
        private string? email;
        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (value == null)
                    firstName = "";
                else
                    firstName = value;
            }
        }

        public string LastName
        {
            get { return lastName; }
            set
            {
                if (value == null)

                    lastName = "";
                else
                    lastName = value;
            }
        }
        public string Age
        {
            get { return age; }
            set
            {
                if (value == null)

                    age = "";
                else
                    age = value;
            }
        }
        public string PhoneNumber
        {
            get { return phone; }
            set
            {
                if (value == null)

                    phone = "";
                else
                    phone = value;
            }
        }

        public string Email
        {
            get { return email; }
            set
            {
                if (value == null)

                    email = "";
                else
                    email = value;
            }
        }
    }
}

