using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ButtonProject.Models
{
    public class CustomerInfoContext:DbContext
    {
        public CustomerInfoContext(DbContextOptions<CustomerInfoContext> options): base(options)
        {
        }
        public DbSet<ButtonInfo> Customers { get; set; }
    }
    
}
