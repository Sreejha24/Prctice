using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryPattern.Data
{
    public class RepositoryContext:DbContext
    {
        public RepositoryContext(DbContextOptions options)
            : base(options)
        {

        }
        public DbSet<RepositoryPattern.Models.Employee> Employee { get; set; }
        public DbSet<RepositoryPattern.Models.Department> Department { get; set; }
        public DbSet<RepositoryPattern.Models.Person> Person { get; set; }
        public DbSet<RepositoryPattern.Models.PAddresss> PAddress { get; set; }
        public DbSet<RepositoryPattern.Models.View.PersonAddressView> PersonAddressView { get; set; }

    }
}
