using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DefaultMVCCore.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<DefaultMVCCore.Models.Employee> Employee { get; set; }
        public DbSet<DefaultMVCCore.Models.Department> Department { get; set; }
        public DbSet<DefaultMVCCore.Models.Person> Person { get; set; }
        public DbSet<DefaultMVCCore.Models.PAddresss> PAddress { get; set; }
        public DbSet<DefaultMVCCore.Models.View.PersonAddressView> PersonAddressView { get; set; }

    }
}
