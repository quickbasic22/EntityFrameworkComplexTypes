using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ComplexTypes.Models
{
    
    public class Person
    {
        public Person(Address address)
        {
            Address = new Address();
        }

        [Key]
        //public int PersonID { get; set; }
        public int SocialSecurityNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address Address { get; set; }

    }
}