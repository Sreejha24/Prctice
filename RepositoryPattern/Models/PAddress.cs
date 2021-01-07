using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RepositoryPattern.Models
{
    [Table("Addresses")]
    public class PAddresss
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AddressId { get; set; }

        public string AddressLine { get; set; }

        public string City { get; set; }

        public string Pin { get; set; }
    }
}

    
