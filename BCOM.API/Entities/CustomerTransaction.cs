using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BCOM.API.Entities
{
    public class CustomerTransaction
    {
        [Key]
        public int Id { get; set; }
        public DateTime TransactionDate { get; set; }
        public string TransactionStatus { get; set; }
        public int IdCustomer { get; set; }
        [ForeignKey("IdCustomer")]
        public Customer Customer { get; set; }
    }

    public class SearchQuery
    {
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
    }
}
