using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RepositoryPattern.Models.View
{
    public class PersonAddressView
    {
        [Key]
        public int PersonID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public long Mobile { get; set; }

        public int AddressId { get; set; }

        public string AddressLine { get; set; }

        public string City { get; set; }

        public int Pin { get; set; }

    }
}
