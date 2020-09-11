using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BCOM.API.Entities
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string LastName { get; set; }
        public int Dni { get; set; }
    }
}
