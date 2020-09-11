using BCOM.API.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BCOM.API.Context
{
    public class DB:DbContext
    {
        public DB(DbContextOptions<DB> options) : base(options)
        {
        }

        public DbSet<Customer> Customer { get; set; }
        public DbSet<CustomerTransaction> CustomerTransaction { get; set; }
    }
}
